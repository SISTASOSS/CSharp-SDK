# o2g-sdk

This C# SDK allows to create applications using [OpenTouch Open Gateway API](https://api.dspp.al-enterprise.com/omnipcx-open-gateway-02g/).
It provides access to all the services available in O2G.

To connect to an O2G server, you create an O2G application, use your credential to connect and use services.

## Installation

Use the package manager to install o2g-sdk.

```bash
Install-Package o2g-sdk -Version 1.1.0
```

## Usage
```c#
# Create the application
O2G.Application myApp = new("MyApplication");

# Configure O2G host
myApp.SetHost(new()
{
    PrivateAddress = "123.25.112.119"
});

# Login using your credential
await myApp.LoginAsync(your-loginName, your-password);

# Use a service
IAnalytics analyticService = myApp.AnalyticsService;
List<Incident> incidents = await analyticService.GetIncidentsAsync(7);
```



## License
[MIT](https://choosealicense.com/licenses/mit/)
