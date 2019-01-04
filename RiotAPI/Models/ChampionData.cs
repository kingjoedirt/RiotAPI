﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotAPI.Models
{
    public class ChampionData
    {
        public string Version { get; set; }
        public string Id { get; set; }
        public int Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public ChampionInfo Info { get; set; }
        public ChampionImage Image { get; set; }
        public IList<string> Tags { get; set; }
        public string Partype { get; set; }
        public IDictionary<string, double> Stats { get; set; }
    }
}