using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotAPI.Models
{
    public class ChampionImage
    {
        public string Full { get; set; }
        public string Sprite { get; set; }
        public string Group { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public long W { get; set; }
        public long H { get; set; }
    }
}