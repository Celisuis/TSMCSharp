# TradeSkillMaster C# Wrapper

The TradeSkillMaster C# Wrapper is a client based .dll file that allows you to pull and parse the JSON information from the API.

### Releases

Up-To-Date Releases can now be found in the Release Tab.


## Usage

### Connecting
```c#
TSMClient client = new TSMClient("key")
```

### Retrieving Singular Item Information from One Realm
```c#
Item item = Client.TSM.RetrieveRealmItem(itemID, realmName, region)
```

### Retrieving Singular Item Information Across All Regions
```c#
Item item = Client.TSM.RetrieveItem(itemID)
```

### Retrieving All Regional Auctions
```c#
List<Item> ItemList = Client.TSM.RetrieveAllRegionItems(region)
```

### Retrieving All Realm Auctions
```c#
List<Item> ItemList = Client.TSM.RetrieveAllRealmItems(realm, region)
```

### Downloading Regional Information
```c#
Client.TSM.DownloadRegionData(region, appName, DownloadType, filePath)
```

### Downloading Realm Information
```c#
Client.TSM.DownloadRealmData(realm, region, DownloadType, appName, filePath)
```

FilePath variable is optional, if it isn't set, Downloads default to:

- AppData\Roaming\AppName\Region\Region Auction Data.json
- AppData\Roaming\AppName\Region\Realm\Auction Data.json 

respectively.

DownloadType is an optional enum property that allows you to choose whether to download the Auction Data as a JArray(Standard) or parse it into a JObject. The Default Settings for this is Array.

## Build
Open the Solution in VS Studio and Build. Pre-Built DLL Files are located in the bin\debug folder currently.

