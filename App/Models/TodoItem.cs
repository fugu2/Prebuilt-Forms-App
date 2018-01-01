using System;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;

namespace App.Models
{
    public class TodoItem
    {
        string id;
        string text;
        bool done;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "text")]
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        [JsonProperty(PropertyName = "complete")]
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
