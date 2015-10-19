namespace Tinderino
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.LikeButton = new System.Windows.Forms.Button();
            this.PassButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.NextPictureButton = new System.Windows.Forms.Button();
            this.PreviousPictureButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BioTextBox = new System.Windows.Forms.TextBox();
            this.GlobalStatusLabel = new System.Windows.Forms.Label();
            this.LikesRemainingLabel = new System.Windows.Forms.Label();
            this.LocalStatusLabel = new System.Windows.Forms.Label();
            this.LatitudeTextBox = new System.Windows.Forms.TextBox();
            this.LongitudeTextBox = new System.Windows.Forms.TextBox();
            this.ChangeLocationButton = new System.Windows.Forms.Button();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.ChangeDistanceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePicture.Image = global::Tinderino.Properties.Resources.Koala;
            this.profilePicture.Location = new System.Drawing.Point(122, 52);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(210, 320);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // LikeButton
            // 
            this.LikeButton.Location = new System.Drawing.Point(257, 396);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(75, 23);
            this.LikeButton.TabIndex = 1;
            this.LikeButton.Text = "Like";
            this.LikeButton.UseVisualStyleBackColor = true;
            this.LikeButton.Click += new System.EventHandler(this.LikeButton_Click);
            // 
            // PassButton
            // 
            this.PassButton.Location = new System.Drawing.Point(122, 396);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(75, 23);
            this.PassButton.TabIndex = 2;
            this.PassButton.Text = "Pass";
            this.PassButton.UseVisualStyleBackColor = true;
            this.PassButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 477);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // NextPictureButton
            // 
            this.NextPictureButton.Location = new System.Drawing.Point(338, 176);
            this.NextPictureButton.Name = "NextPictureButton";
            this.NextPictureButton.Size = new System.Drawing.Size(75, 23);
            this.NextPictureButton.TabIndex = 4;
            this.NextPictureButton.Text = "Next Picture";
            this.NextPictureButton.UseVisualStyleBackColor = true;
            this.NextPictureButton.Click += new System.EventHandler(this.NextPictureButton_Click);
            // 
            // PreviousPictureButton
            // 
            this.PreviousPictureButton.Location = new System.Drawing.Point(12, 176);
            this.PreviousPictureButton.Name = "PreviousPictureButton";
            this.PreviousPictureButton.Size = new System.Drawing.Size(104, 23);
            this.PreviousPictureButton.TabIndex = 5;
            this.PreviousPictureButton.Text = "Previous Picture";
            this.PreviousPictureButton.UseVisualStyleBackColor = true;
            this.PreviousPictureButton.Click += new System.EventHandler(this.PreviousPictureButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(138, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(177, 20);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name + Age + Distance";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BioTextBox
            // 
            this.BioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.BioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BioTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BioTextBox.Enabled = false;
            this.BioTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BioTextBox.Location = new System.Drawing.Point(474, 16);
            this.BioTextBox.Multiline = true;
            this.BioTextBox.Name = "BioTextBox";
            this.BioTextBox.ReadOnly = true;
            this.BioTextBox.Size = new System.Drawing.Size(190, 183);
            this.BioTextBox.TabIndex = 9;
            this.BioTextBox.Text = "Bio";
            // 
            // GlobalStatusLabel
            // 
            this.GlobalStatusLabel.AutoSize = true;
            this.GlobalStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.GlobalStatusLabel.Location = new System.Drawing.Point(594, 487);
            this.GlobalStatusLabel.Name = "GlobalStatusLabel";
            this.GlobalStatusLabel.Size = new System.Drawing.Size(70, 13);
            this.GlobalStatusLabel.TabIndex = 10;
            this.GlobalStatusLabel.Text = "Global Status";
            // 
            // LikesRemainingLabel
            // 
            this.LikesRemainingLabel.AutoSize = true;
            this.LikesRemainingLabel.ForeColor = System.Drawing.Color.Green;
            this.LikesRemainingLabel.Location = new System.Drawing.Point(9, 9);
            this.LikesRemainingLabel.Name = "LikesRemainingLabel";
            this.LikesRemainingLabel.Size = new System.Drawing.Size(17, 13);
            this.LikesRemainingLabel.TabIndex = 11;
            this.LikesRemainingLabel.Text = "xx";
            // 
            // LocalStatusLabel
            // 
            this.LocalStatusLabel.AutoSize = true;
            this.LocalStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.LocalStatusLabel.Location = new System.Drawing.Point(414, 490);
            this.LocalStatusLabel.Name = "LocalStatusLabel";
            this.LocalStatusLabel.Size = new System.Drawing.Size(66, 13);
            this.LocalStatusLabel.TabIndex = 12;
            this.LocalStatusLabel.Text = "Local Status";
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LatitudeTextBox.Location = new System.Drawing.Point(474, 220);
            this.LatitudeTextBox.Name = "LatitudeTextBox";
            this.LatitudeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LatitudeTextBox.Size = new System.Drawing.Size(150, 13);
            this.LatitudeTextBox.TabIndex = 13;
            this.LatitudeTextBox.Text = "New Latitude";
            this.LatitudeTextBox.Click += new System.EventHandler(this.LatitudeTextBox_Click);
            this.LatitudeTextBox.Leave += new System.EventHandler(this.LatitudeTextBox_Leave);
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LongitudeTextBox.Location = new System.Drawing.Point(474, 239);
            this.LongitudeTextBox.Name = "LongitudeTextBox";
            this.LongitudeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LongitudeTextBox.Size = new System.Drawing.Size(150, 13);
            this.LongitudeTextBox.TabIndex = 14;
            this.LongitudeTextBox.Text = "New Longitude";
            this.LongitudeTextBox.Click += new System.EventHandler(this.LongitudeTextBox_Click);
            this.LongitudeTextBox.Leave += new System.EventHandler(this.LongitudeTextBox_Leave);
            // 
            // ChangeLocationButton
            // 
            this.ChangeLocationButton.AutoSize = true;
            this.ChangeLocationButton.Location = new System.Drawing.Point(496, 258);
            this.ChangeLocationButton.Name = "ChangeLocationButton";
            this.ChangeLocationButton.Size = new System.Drawing.Size(98, 23);
            this.ChangeLocationButton.TabIndex = 15;
            this.ChangeLocationButton.Text = "Change Location";
            this.ChangeLocationButton.UseVisualStyleBackColor = true;
            this.ChangeLocationButton.Click += new System.EventHandler(this.ChangeLocationButton_Click);
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DistanceTextBox.Location = new System.Drawing.Point(474, 307);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(100, 13);
            this.DistanceTextBox.TabIndex = 16;
            this.DistanceTextBox.Text = "New Distance";
            this.DistanceTextBox.Click += new System.EventHandler(this.DistanceTextBox_Click);
            this.DistanceTextBox.Leave += new System.EventHandler(this.DistanceTextBox_Leave);
            // 
            // ChangeDistanceButton
            // 
            this.ChangeDistanceButton.AutoSize = true;
            this.ChangeDistanceButton.Location = new System.Drawing.Point(496, 326);
            this.ChangeDistanceButton.Name = "ChangeDistanceButton";
            this.ChangeDistanceButton.Size = new System.Drawing.Size(99, 23);
            this.ChangeDistanceButton.TabIndex = 17;
            this.ChangeDistanceButton.Text = "Change Distance";
            this.ChangeDistanceButton.UseVisualStyleBackColor = true;
            this.ChangeDistanceButton.Click += new System.EventHandler(this.ChangeDistanceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 512);
            this.Controls.Add(this.ChangeDistanceButton);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.ChangeLocationButton);
            this.Controls.Add(this.LongitudeTextBox);
            this.Controls.Add(this.LatitudeTextBox);
            this.Controls.Add(this.LocalStatusLabel);
            this.Controls.Add(this.LikesRemainingLabel);
            this.Controls.Add(this.GlobalStatusLabel);
            this.Controls.Add(this.BioTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PreviousPictureButton);
            this.Controls.Add(this.NextPictureButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.PassButton);
            this.Controls.Add(this.LikeButton);
            this.Controls.Add(this.profilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tinderino";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button LikeButton;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button NextPictureButton;
        private System.Windows.Forms.Button PreviousPictureButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox BioTextBox;
        private System.Windows.Forms.Label GlobalStatusLabel;
        private System.Windows.Forms.Label LikesRemainingLabel;
        private System.Windows.Forms.Label LocalStatusLabel;
        private System.Windows.Forms.TextBox LatitudeTextBox;
        private System.Windows.Forms.TextBox LongitudeTextBox;
        private System.Windows.Forms.Button ChangeLocationButton;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Button ChangeDistanceButton;
    }
}

