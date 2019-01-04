using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotAPI.Models
{
    public class Champions
    {
        public string Type { get; set; }
        public string Format { get; set; }
        public string Version { get; set; }
        public IDictionary<string, ChampionData> Data { get; set; }
    }
}