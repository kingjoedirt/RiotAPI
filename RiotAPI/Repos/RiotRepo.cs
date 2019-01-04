using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RiotAPI.Repos;
using RiotAPI.Models;
using Newtonsoft.Json;
using RiotAPI.Helpers;

namespace RiotAPI.Repos
{
    public class RiotRepo
    {
        public Champions Champions { get; set; }
        private string DataDragonBaseURL { get; set; }
        public string PatchToUse { get; set; }
        public RiotRepo()
        {
            this.Champions = GetChampions();
            this.DataDragonBaseURL = "http://ddragon.leagueoflegends.com/";
            this.PatchToUse = GetCurrentPatch();
        }
        public RiotRepo(string PatchToUse)
        {
            this.Champions = GetChampions();
            this.DataDragonBaseURL = "http://ddragon.leagueoflegends.com/";
            this.PatchToUse = PatchToUse;
        }

        public Champions GetChampions()
        {
            string s = DataAccess.GetFromREST(@"http://ddragon.leagueoflegends.com/cdn/8.24.1/data/en_US/champion.json");
            Champions champions = JsonConvert.DeserializeObject<Champions>(s);
            return champions;
        }

        private string GetCurrentPatch()
        {
            return "";
        }
    }
}