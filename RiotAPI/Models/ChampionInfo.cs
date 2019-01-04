using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotAPI.Models
{
    public class ChampionInfo
    {
        public long Attack { get; set; }
        public long Defense { get; set; }
        public long Magic { get; set; }
        public long Difficulty { get; set; }
    }
}