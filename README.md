# TradeSkillMaster C# Wrapper

The TradeSkillMaster C# Wrapper is a client based .dll file that allows you to pull and parse the JSON information from the API.

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
Client.TSM.DownloadRegionData(region, appName)
```

### Downloading Realm Information
```c#
Client.TSM.DownloadRealmData(realm, region, appName)
```

All Downloaded Auction Data goes into AppData\Roaming\AppName\Region\Region Auction Data.json and AppData\Roaming\AppName\Region\Realm\Auction Data.json respectively.

## Build
Open the Solution in VS Studio and Build. Pre-Built DLL Files are located in the bin\debug folder currently.

