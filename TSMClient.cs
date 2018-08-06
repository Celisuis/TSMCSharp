using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSMCSharp
{
   public class TSMClient
    {
        public bool isConnected;

        private readonly string API_URL;
        private string API_Key;

        const string User_Agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0";

        public TradeSkillMaster TSM;

        public TSMClient(string key)
        {
            API_Key = key;

            API_URL = $@"http://api.tradeskillmaster.com/v1/";

            TSM = new TradeSkillMaster(this, API_URL, API_Key, User_Agent);
        }


    }
}
