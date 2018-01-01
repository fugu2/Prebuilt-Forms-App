using System;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;

namespace App
{
    public class Velopumpe
    {
        string id;
        double longitude;
        double latitude;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "longitude")]
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [JsonProperty(PropertyName = "latitude")]
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
