# Instructions

### Setup the Storage Account

- Create a Storage Account
- Add a Table called 'events'

### Setup the Azure Web App

- Create an Azure Web App
- Add a connection string into the app Settings for the Azure Web App

```
EventData  DefaultEndpointsProtocol=https;AccountName=<your_account>;AccountKey=<your_key>
```

### Publish the WebJob to Azure

- Right Click and Publish to Azure to the Web Site created.

