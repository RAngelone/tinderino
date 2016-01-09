/*
* Thiago Diniz Maia
* dinizthiagobr@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinderino
{
    public class TinderProfile
    { 
        public string id;
        public string name;
        public List<string> photos;
        public string bio;
        public int distance;
        public int age;

        public TinderProfile()
        {
            this.photos = new List<string>();
        }

        public void ConvertDistanceToKm()
        {
            this.distance = (int)(this.distance * 1.6);
        }
    }
}
