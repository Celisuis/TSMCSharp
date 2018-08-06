using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSMCSharp
{
    public class Item
    {
        public long ID { get; internal set; }

        public string Name { get; internal set; }

        public long Level { get; internal set; }

        public string Class { get; internal set; }

        public string SubClass { get; internal set; }

        public long BuyPrice { get; internal set; }

        public long SellPrice { get; internal set; }

        public long MarketValue { get; internal set; }

        public long MinimumBuyoutPrice { get; internal set; }

        public long Quantity { get; internal set; }

        public long NumberOfAuctions { get; internal set; }

        public long HistoricalPrice { get; internal set; }

        public long AverageRegionMarketPrice { get; internal set; }

        public long AverageRegionMinimumBuyoutPrice { get; internal set; }

        public long RegionQuantity { get; internal set; }

        public long RegionHistoricalPrice { get; internal set; }

        public long AverageRegionSaleRate { get; internal set; }

        public double AverageRegionDailySold { get; internal set; }

        public double RegionSaleRate { get; internal set; }

        public string URL { get; internal set; }

        public long LastUpdated { get; internal set; }

        #region EU
        public long AverageEUMarketValue { get; internal set; }

        public long AverageEUMinimumBuyout { get; internal set; }

        public long EUQuantity { get; internal set; }

        public long EUHistoricalPrice { get; internal set; }

        public double AverageEUSaleRate { get; internal set; }

        public double AverageEUDailySold { get; internal set; }

        public long EULastModified { get; internal set; }
        #endregion

        #region US
        public long AverageUSMarketValue { get; internal set; }

        public long AverageUSMinimumBuyout { get; internal set; }

        public long USQuantity { get; internal set; }

        public long USHistoricalPrice { get; internal set; }

        public double AverageUSSaleRate { get; internal set; }

        public double AverageUSDailySold { get; internal set; }

        public long USLastModified { get; internal set; }
        #endregion

        public Item(JObject rawData)
        {
            if (rawData["Id"] != null)
                ID = long.Parse(rawData["Id"].ToString());
            if (rawData["ItemId"] != null)
                ID = long.Parse(rawData["ItemId"].ToString());
            if (rawData["Name"] != null)
                Name = rawData["Name"].ToString();
            if (rawData["Level"] != null)
                Level = long.Parse(rawData["Level"].ToString());
            if (rawData["Class"] != null)
                Class = rawData["Class"].ToString();
            if (rawData["SubClass"] != null)
                SubClass = rawData["SubClass"].ToString();
            if (rawData["VendorBuy"] != null)
                BuyPrice = long.Parse(rawData["VendorBuy"].ToString());
            if (rawData["VendorSell"] != null)
                SellPrice = long.Parse(rawData["VendorSell"].ToString());
            if (rawData["MarketValue"] != null)
                MarketValue = long.Parse(rawData["MarketValue"].ToString());
            if (rawData["MinBuyout"] != null)
                MinimumBuyoutPrice = long.Parse(rawData["MinBuyout"].ToString());
            if (rawData["Quantity"] != null)
                Quantity = long.Parse(rawData["Quantity"].ToString());
            if (rawData["NumAuctions"] != null)
                NumberOfAuctions = long.Parse(rawData["NumAuctions"].ToString());
            if (rawData["HistoricalPrice"] != null)
                HistoricalPrice = long.Parse(rawData["HistoricalPrice"].ToString());
            if (rawData["RegionMarketAvg"] != null)
                AverageRegionMarketPrice = long.Parse(rawData["RegionMarketAvg"].ToString());
            if (rawData["RegionMinBuyoutAvg"] != null)
                AverageRegionMinimumBuyoutPrice = long.Parse(rawData["RegionMinBuyoutAvg"].ToString());
            if (rawData["RegionQuantity"] != null)
                RegionQuantity = long.Parse(rawData["RegionQuantity"].ToString());
            if (rawData["RegionHistoricalPrice"] != null)
                RegionHistoricalPrice = long.Parse(rawData["RegionHistoricalPrice"].ToString());
            if (rawData["RegionSaleAvg"] != null)
                AverageRegionSaleRate = long.Parse(rawData["RegionSaleAvg"].ToString());
            if (rawData["RegionAvgDailySold"] != null)
                AverageRegionDailySold = double.Parse(rawData["RegionAvgDailySold"].ToString());
            if (rawData["RegionSaleRate"] != null)
                RegionSaleRate = double.Parse(rawData["RegionSaleRate"].ToString());
            if (rawData["URL"] != null)
                URL = rawData["URL"].ToString();
            if (rawData["LastUpdated"] != null)
                LastUpdated = long.Parse(rawData["LastUpdated"].ToString());

            #region EU
            if (rawData["EUMarketAvg"] != null)
                AverageEUMarketValue = long.Parse(rawData["EUMarketAvg"].ToString());
            if (rawData["EUMinBuyoutAvg"] != null)
                AverageEUMinimumBuyout = long.Parse(rawData["EUMinBuyoutAvg"].ToString());
            if (rawData["EUQuantity"] != null)
                EUQuantity = long.Parse(rawData["EUQuantity"].ToString());
            if (rawData["EUHistoricalPrice"] != null)
                EUHistoricalPrice = long.Parse(rawData["EUHistoricalPrice"].ToString());
            if (rawData["EUSaleAvg"] != null)
                AverageEUSaleRate = double.Parse(rawData["EUSaleAvg"].ToString());
            if (rawData["EUAvgDailySold"] != null)
                AverageEUDailySold = double.Parse(rawData["EUAvgDailySold"].ToString());
            if (rawData["EULastModified"] != null)
                EULastModified = long.Parse(rawData["EULastModified"].ToString());
            #endregion

            #region US
            if (rawData["USMarketAvg"] != null)
                AverageUSMarketValue = long.Parse(rawData["USMarketAvg"].ToString());
            if (rawData["USMinBuyoutAvg"] != null)
                AverageUSMinimumBuyout = long.Parse(rawData["USMinBuyoutAvg"].ToString());
            if (rawData["USQuantity"] != null)
                USQuantity = long.Parse(rawData["USQuantity"].ToString());
            if (rawData["USHistoricalPrice"] != null)
                USHistoricalPrice = long.Parse(rawData["USHistoricalPrice"].ToString());
            if (rawData["USSaleAvg"] != null)
                AverageUSSaleRate = double.Parse(rawData["USSaleAvg"].ToString());
            if (rawData["USAvgDailySold"] != null)
                AverageUSDailySold = double.Parse(rawData["USAvgDailySold"].ToString());
            if (rawData["USLastModified"] != null)
                USLastModified = long.Parse(rawData["USLastModified"].ToString());

            #endregion

        }
    }





}
