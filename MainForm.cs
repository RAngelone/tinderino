/*
* Thiago Diniz Maia
* dinizthiagobr@gmail.com
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinderino
{
    public partial class MainForm : Form
    {
        private TinderAPI tinderAPI;
        private List<TinderProfile> profiles;
        private int curProfileIndex = 0;
        private int curPictureIndex = 0;
        public MainForm()
        {
            InitializeComponent();

            this.tinderAPI = new TinderAPI();
            profiles = new List<TinderProfile>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshButton.PerformClick();
        }

        /*
        * return 0 : empty response
        * return 1 : got at least one profile
        * return 2 : request error
        * return 3 : status not 200
        * return 4 : got 0 profiles
        */

        private void Refresh_Click(object sender, EventArgs e)
        {
            GlobalStatusLabel.Text = "Refreshing profiles...";
            int r = tinderAPI.GetPotentialMatches(profiles);
            string message = "";

            switch (r)
            {
                case 0:
                    message = "Empty response";
                    break;
                case 1:
                    message = profiles.Count +  " profiles loaded";
                    break;
                case 2:
                    message = "Request error";
                    break;
                case 3:
                    message = profiles.Count + " profiles loaded";
                    break;
                default:
                    message = "What's going on";
                    break;
            }

            if (r == 1)
            {
                RefreshProfileView();
            }

            GlobalStatusLabel.Text = message;
        }

        private void NextPictureButton_Click(object sender, EventArgs e)
        {
            curPictureIndex++;
            if (curPictureIndex == profiles.ElementAt(curProfileIndex).photos.Count)
            {
                curPictureIndex = 0;
            }
            profilePicture.Load(profiles.ElementAt(curProfileIndex).photos.ElementAt(curPictureIndex));
        }

        private void PreviousPictureButton_Click(object sender, EventArgs e)
        {
            curPictureIndex--;
            if (curPictureIndex < 0)
            {
                curPictureIndex = profiles.ElementAt(curProfileIndex).photos.Count - 1;
            }
            profilePicture.Load(profiles.ElementAt(curProfileIndex).photos.ElementAt(curPictureIndex));
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            int r = tinderAPI.LikeUser(profiles.ElementAt(curProfileIndex).id);
            string message = "";

            switch (r)
            {
                case 0:
                    message = "Empty response";
                    break;
                case 1:
                    profiles.RemoveAt(curProfileIndex);
                    RefreshProfileView();
                    message = "It's a match :)";
                    break;
                case 2:
                    message = "Request error";
                    break;
                case 3:
                    profiles.RemoveAt(curProfileIndex);
                    RefreshProfileView();
                    message = "Not a match... yet?";
                    break;
                default:
                    message = "What's going on";
                    break;
            }
            LocalStatusLabel.Text = message;
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            int r = tinderAPI.PassUser(profiles.ElementAt(curProfileIndex).id);
            string message = "";

            switch (r)
            {
                case 0:
                    message = "Empty response";
                    break;
                case 1:
                    profiles.RemoveAt(curProfileIndex);
                    RefreshProfileView();
                    message = "She's not going to bother you again :)";
                    break;
                case 2:
                    message = "Request error";
                    break;
                case 3:
                    message = "Request status not 200";
                    break;
                default:
                    message = "What's going on";
                    break;
            }
            LocalStatusLabel.Text = message;
        }

        private void RefreshProfileView()
        {
            curPictureIndex = 0;
            LikesRemainingLabel.Text = tinderAPI.likes_remaining.ToString();
            if (profiles.Count > 0)
            {
                LikeButton.Enabled = true;
                PassButton.Enabled = true;
                NextPictureButton.Enabled = true;
                PreviousPictureButton.Enabled = true;

                TinderProfile tp = profiles.ElementAt(curProfileIndex);
                profilePicture.Load(tp.photos.First());

                string basicInfo = tp.name + " : " + tp.age + " : " + tp.distance + "km";
                NameLabel.Text = basicInfo;

                BioTextBox.Text = tp.bio;
            }
            else
            {
                LikeButton.Enabled = false;
                PassButton.Enabled = false;
                NextPictureButton.Enabled = false;
                PreviousPictureButton.Enabled = false;
                BioTextBox.Text = "Bio";
                profilePicture.Image = Tinderino.Properties.Resources.Koala;
                profilePicture.Refresh();
                NameLabel.Text = "No profile loaded";
            }
        }

        private void ChangeLocationButton_Click(object sender, EventArgs e)
        {
            float lat = float.Parse(LatitudeTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat);
            float lon = float.Parse(LongitudeTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat);
            string message = "";
            
            if (lat >= -90 && lat <= 90 && lon >= -180 && lon <= 180)
            {
                int r = tinderAPI.changeLocation(LatitudeTextBox.Text, LongitudeTextBox.Text);

                switch (r)
                {
                    case 0:
                        message = "Empty response";
                        break;
                    case 1:
                        RefreshButton.PerformClick();
                        message = "Location changed";
                        break;
                    case 2:
                        message = "Request error";
                        break;
                    case 3:
                        message = "Request status not 200";
                        break;
                    case 4:
                        message = "Location change not accepted";
                        break;
                    default:
                        message = "What's going on";
                        break;
                }
                LocalStatusLabel.Text = message;
            }
            LatitudeTextBox.Text = "Latitude";
            LongitudeTextBox.Text = "Longitude";
        }

        private void LatitudeTextBox_Click(object sender, EventArgs e)
        {
            if (LatitudeTextBox.Text.Equals("New Latitude"))
            {
                LatitudeTextBox.Text = "";
            }
        }

        private void LongitudeTextBox_Click(object sender, EventArgs e)
        {
            if (LongitudeTextBox.Text.Equals("New Longitude"))
            {
                LongitudeTextBox.Text = "";
            }
        }

        private void LatitudeTextBox_Leave(object sender, EventArgs e)
        {
            if (LatitudeTextBox.Text.Equals(""))
            {
                LatitudeTextBox.Text = "New Latitude";
            }
        }

        private void LongitudeTextBox_Leave(object sender, EventArgs e)
        {
            if (LongitudeTextBox.Text.Equals(""))
            {
                LongitudeTextBox.Text = "New Longitude";
            }
        }

        private void DistanceTextBox_Click(object sender, EventArgs e)
        {
            if (DistanceTextBox.Text.Equals("New Distance"))
            {
                DistanceTextBox.Text = "";
            }
        }

        private void DistanceTextBox_Leave(object sender, EventArgs e)
        {
            if (DistanceTextBox.Text.Equals(""))
            {
                DistanceTextBox.Text = "New Distance";
            }
        }

        /*
        * return 0 : empty response
        * return 1 : max distance changed
        * return 2 : request error
        * return 3 : max distance change not accepted
        */
        private void ChangeDistanceButton_Click(object sender, EventArgs e)
        {
            int dMi = Int32.Parse(DistanceTextBox.Text);
            int dKm = (int)(dMi * 1.6);
            int r = tinderAPI.changeDistance(dKm);

            string message = "";

            switch (r)
            {
                case 0:
                    message = "Empty response";
                    break;
                case 1:
                    RefreshButton.PerformClick();
                    message = "Max distance changed";
                    break;
                case 2:
                    message = "Request error";
                    break;
                case 3:
                    message = "Max distance not changed";
                    break;
                default:
                    message = "What's going on";
                    break;
            }
            LocalStatusLabel.Text = message;
        }
    }
}
