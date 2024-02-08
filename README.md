# Line Bot WebAPI DEMO

## Introduct
This is a demo for line bot web api based on dotnet core.

## Getting Started


### Prerequisites
  ```sh
  nuget install LineBotWebAPI
  ```

### Usage
1) You must [register](https://developers.line.biz/) Line developer first.
2) You can find **Channel secret** in **Basic settings**
3) You can find **Channel access token** in **Messaging API settings**
4) Please replace they with **appsettings.json**

### Tips
The URI was different :
1) message base URI : https://api.line.me
2) content base URI : https://api-data.line.me
You can init LineMessagingClient like this
```csharp
LineMessagingClient("YOUR ACCESS TOKEN","URI"); 
```
## Enjoy ~