/*
* Thiago Diniz Maia
* dinizthiagobr@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Tinderino
{
    public class TinderAPI
    {
        public int likes_remaining = 999;
        public string location;
        private string auth_token = "YOUR TOKEN HERE";

        public TinderAPI()
        {
            //...
        }

        /*
        * return 0 : empty response
        * return 1 : got at least one profile
        * return 2 : request error
        * return 3 : no more profiles
        */
        public int GetPotentialMatches(List<TinderProfile> profiles)
        {
            string response;

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.UserAgent] = "Tinder Android Version 4.3.1";
                    wc.Headers.Add("X-Auth-Token", auth_token);
                    wc.Headers.Add("os-version", "21");
                    wc.Headers.Add("app-version", "825");
                    wc.Headers.Add("platform", "android");
                    response = wc.DownloadString("https://api.gotinder.com/user/recs");
                }
            }
            catch
            {
                return 2;
            }

            //response = System.IO.File.ReadAllText(@"C:\Users\Thiago\Documents\Projetos Visual Studio\2015\Tinderino\json.txt");

            if (!string.IsNullOrWhiteSpace(response))
            {               
                dynamic rj = JObject.Parse(response); 
                if (rj.status == "200")
                {
                    foreach(dynamic r in rj.results)
                    {
                        TinderProfile tmpProfile = new TinderProfile();
                        tmpProfile.id = r._id;
                        tmpProfile.distance = r.distance_mi;
                        tmpProfile.bio = r.bio;
                        tmpProfile.name = r.name;

                        string bd = r.birth_date;
                        bd = bd.Substring(6, 4);
                        int year = Int32.Parse(bd);
                        tmpProfile.age = 2015 - year;

                        foreach(dynamic p in r.photos)
                        {
                            string photoPath = p.processedFiles[0].url;
                            tmpProfile.photos.Add(photoPath);
                        }
                        
                        tmpProfile.ConvertDistanceToKm();

                        profiles.Add(tmpProfile);
                    }
                        return 1;                    
                }
                else
                {
                    return 3;
                }           
            }
            return 0;
        }

        /*
        * return 0 : empty response
        * return 1 : it's a match
        * return 2 : request error
        * return 3 : not a match :(
        */
        public int LikeUser(string userId)
        {
            string uri = "https://api.gotinder.com/like/" + userId;
            string response;

            try {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.UserAgent] = "Tinder Android Version 4.3.1";
                    wc.Headers.Add("X-Auth-Token", auth_token);
                    wc.Headers.Add("os-version", "21");
                    wc.Headers.Add("app-version", "825");
                    wc.Headers.Add("platform", "android");
                    response = wc.DownloadString(uri);
                }
            }
            catch
            {
                return 2;
            }

            if (!string.IsNullOrWhiteSpace(response))
            {
                dynamic rj = JObject.Parse(response);
                this.likes_remaining = rj.likes_remaining;
                Type t = rj.match.GetType();
                if (t.Name.Equals("Object"))
                {
                    return 1;
                } else
                {
                    return 3;
                }
            }
            return 0;
        }

        /*
        * return 0 : empty response
        * return 1 : request successful
        * return 2 : request error
        * return 3 : request status isn't 200 ? ?
        */
        public int PassUser(string userId)
        {
            string uri = "https://api.gotinder.com/pass/" + userId;
            string response;

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.UserAgent] = "Tinder Android Version 4.3.1";
                    wc.Headers.Add("X-Auth-Token", auth_token);
                    wc.Headers.Add("os-version", "21");
                    wc.Headers.Add("app-version", "825");
                    wc.Headers.Add("platform", "android");
                    response = wc.DownloadString(uri);
                }
            }
            catch
            {
                return 2;
            }

            if (!string.IsNullOrWhiteSpace(response))
            {
                dynamic rj = JObject.Parse(response);
                if (rj.status == "200")
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            return 0;
        }

        /*
        * return 0 : empty response
        * return 1 : request successful
        * return 2 : request error
        * return 3 : request status isn't 200 ? ?
        * return 4 : location change not accepted
        */
        public int changeLocation(string lat, string lon)
        {
            string uri = "https://api.gotinder.com/user/ping";
            string response;
            string latlon = "{\"lat\":" + lat + ",\"lon\":" + lon + "}";

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.UserAgent] = "Tinder Android Version 4.3.1";
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    wc.Headers.Add("X-Auth-Token", auth_token);
                    wc.Headers.Add("os-version", "21");
                    wc.Headers.Add("app-version", "825");
                    wc.Headers.Add("platform", "android");
                    response = wc.UploadString(uri, latlon);
                }
            }
            catch
            {
                return 2;
            }

            if (!string.IsNullOrWhiteSpace(response))
            {
                dynamic rj = JObject.Parse(response);
                if (rj.status == "200")
                {
                    if (rj.error != null)
                    {
                        return 4;
                    }
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            return 0;
        }

        /*
        * return 0 : empty response
        * return 1 : max distance changed
        * return 2 : request error
        * return 3 : max distance change not accepted
        */
        public int changeDistance(int distance)
        {
            string uri = "https://api.gotinder.com/profile";
            string response;
            string data = "{\"discoverable\":true,\"gender_filter\":1,\"age_filter_min\":18,\"age_filter_max\":1000,\"distance_filter\":" + distance + "}";

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.UserAgent] = "Tinder Android Version 4.3.1";
                    wc.Headers[HttpRequestHeader.ContentType] = "application/json; charset=utf-8";
                    wc.Headers.Add("X-Auth-Token", auth_token);
                    wc.Headers.Add("os-version", "21");
                    wc.Headers.Add("app-version", "825");
                    wc.Headers.Add("platform", "android");
                    response = wc.UploadString(uri, data);
                }
            }
            catch
            {
                return 2;
            }

            if (!string.IsNullOrWhiteSpace(response))
            {
                JObject rj = JObject.Parse(response);
                if (rj.Count > 0)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
            return 0;
        }
    }
}
