using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSMCSharp
{
    public class TradeSkillMaster
    {
        private readonly TSMClient TSMClient;

        private readonly string API_URL, User_Agent;

        private string API_Key;

        public TradeSkillMaster(TSMClient client, string api_url, string api_key, string user_agent)
        {
            TSMClient = client;
            API_URL = api_url;
            API_Key = api_key;
            User_Agent = user_agent;
        }


        #region API Connections

        public Item RetrieveItem(int itemID)
        {
            Request request = new Request(User_Agent);
            request.Get($"{API_URL}item/{itemID}?format=json&apiKey={API_Key}");

            return new Item(JObject.Parse(request.Response));
        }

        public List<Item> RetrieveAllRegionItems(string region)
        {
            string regionID = region.ToUpper();

            Request request = new Request(User_Agent);
            request.Get($"{API_URL}item/region/{regionID}?format=json&apiKey={API_Key}");
            JArray itemArray = JArray.Parse(request.Response);

            List<Item> AllItems = new List<Item>();

            foreach(JObject itemObj in itemArray)
            {
                Item item = new Item(itemObj);
                AllItems.Add(item);
            }

            return AllItems; 
        }

        public List<Item> RetrieveAllRealmItems(string realm, string region)
        {
            string regionID = region.ToUpper();
            string realmID = realm.Replace(" ", "-").ToLower();

            Request request = new Request(User_Agent);

            request.Get($"{API_URL}item/{regionID}/{realmID}?format=json&apiKey={API_Key}");

            JArray itemArray = JArray.Parse(request.Response);

            List<Item> AllItems = new List<Item>();

            foreach (JObject itemObj in itemArray)
            {
                Item item = new Item(itemObj);
                AllItems.Add(item);
            }

            return AllItems;

        }

        public void DownloadRegionData(string region, string appName, string filePath = null)
        {

            string savePath = string.Empty;

            if (filePath == null)
            {
                savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + $@"\{appName}\{region}\Region Auction Data.json";
            }
            else
                savePath = filePath;
            string regionID = region.ToUpper();

            Request request = new Request(User_Agent);

            request.Get($"{API_URL}item/region/{regionID}?format=json&apiKey={API_Key}");

            string firstPass = request.Response.Replace("[", @"{ ""Auctions"": [");
            string secondPass = firstPass.Replace("]", "]}");

            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            File.WriteAllText(savePath, secondPass);
        }
        public void DownloadRealmData(string realm, string region, string appName, string filePath = null)
        {
            string savePath = string.Empty;

            if (filePath == null)
            {
                savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + $@"\{appName}\{region}\Region Auction Data.json";
            }
            else
                savePath = filePath;

            string regionID = region.ToUpper();
            string realmID = realm.Replace(" ", "-").ToLower();

            Request request = new Request(User_Agent);

            request.Get($"{API_URL}item/{regionID}/{realmID}?format=json&apiKey={API_Key}");

            string firstPass = request.Response.Replace("[", @"{ ""Auctions"": [");
            string secondPass = firstPass.Replace("]", "]}");

            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            File.WriteAllText(savePath, secondPass);
            
        }
        public string ReturnAPIKey()
        {
            return API_Key;
        }

        public string ParseDownloadLink(string realm, string region, string url)
        {
            string regionID = region.ToUpper();
            string realmID = realm.Replace(" ", "-").ToLower();


            string output = $"{url}";

            return output;
        }

        public Item RetrieveRealmItem(int itemID, string realm, string region)
        {
            string regionID = region.ToUpper();
            string realmID = realm.Replace(" ", "-").ToLower();

            Request request = new Request(User_Agent);
            request.Get($"{API_URL}item/{regionID}/{realmID}/{itemID}?format=json&apiKey={API_Key}");

            return new Item(JObject.Parse(request.Response));
        }

        #endregion

    }
}
