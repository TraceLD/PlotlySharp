# PlotlySharp

[![License](https://img.shields.io/badge/license-GPL--3.0-blue)](https://github.com/TraceLD/PlotlySharp/blob/master/LICENSE)
[![nuget](https://img.shields.io/nuget/vpre/TraceLd.PlotlySharp)](https://www.nuget.org/packages/TraceLd.PlotlySharp/)
[![nuget-dls](https://img.shields.io/nuget/dt/TraceLd.PlotlySharp)](https://www.nuget.org/packages/TraceLd.PlotlySharp/)
![Framework](https://img.shields.io/badge/framework-.NET%20Standard%202.0-blueviolet)
[![Build Status](https://travis-ci.org/TraceLD/PlotlySharp.svg?branch=master)](https://travis-ci.org/TraceLD/PlotlySharp)

Unofficial C# wrapper for Plotly's REST APIs

[![example](https://i.imgur.com/kza2Dlwt.png)](https://github.com/TraceLD/PlotlySharp/blob/master/MORE_EXAMPLES.md)
[![example](https://i.imgur.com/2leyBw5t.png)](https://github.com/TraceLD/PlotlySharp/blob/master/MORE_EXAMPLES.md)
[![example](https://i.imgur.com/UfAMO1lt.png)](https://github.com/TraceLD/PlotlySharp/blob/master/MORE_EXAMPLES.md)
[![example](https://i.imgur.com/pgPu4J8t.png)](https://github.com/TraceLD/PlotlySharp/blob/master/MORE_EXAMPLES.md)

## Installation

**Package Manager**
```
PM> Install-Package TraceLd.PlotlySharp
```

**.NET CLI**
```
dotnet add package TraceLd.PlotlySharp
```

**Paket CLI**
```
paket add TraceLd.PlotlySharp
```
or simply add the package via your IDE's NuGet package manager.

## Usage

### Create a chart using the built-in PlotlyChart type
This method currently supports only the following chart types:
- Bar
- Contour
- Heatmap
- Pie
- Scatter

If the chart you're using is not on that list, you can either create it using a JSON Object string (this will be explained later in this document) or you can try using the generic `Trace` type.

To see all possible properties and what they are responsible for click [here](https://plot.ly/javascript/reference/). The C# types are a direct map from plotly's JSON objects.

To see more examples of how to use the `PlotlyChart` type click [here](https://github.com/TraceLD/PlotlySharp/blob/master/MORE_EXAMPLES.md).

```cs
using TraceLd.PlotlySharp;
using TraceLd.PlotlySharp.Api;
using TraceLd.PlotlySharp.Api.Traces;
```

```cs
// very basic example, hardcoding credentials is HIGHLY not recommended
PlotlyCredentials Func() => new PlotlyCredentials {Username = "username", Token = "token"};

// create a plotly client that will communicate with Plotly API
// provide your own HttpClient
PlotlyClient plotlyClient = new PlotlyClient(Client, Func);

// create a chart
PlotlyChart myChart = new PlotlyChart
{
    Figure = new Figure
    {
        Data = new ArrayList { new BarTrace
        {
            X = new ArrayList {1, 2, 3},
            Y = new ArrayList {1, 2, 3},
        }, new BarTrace
        {
            X = new ArrayList {1, 2, 3},
            Y = new ArrayList {1, 2, 3},
        }},
    },
    Height = 1000,
    Width = 1000
};

// send the chart to Plotly to compute an image and receive it as a PNG file as byte array
byte[] myImg = await plotlyClient.GetChartAsByteArray(myChart);

// save it to a file
var imgStream = new MemoryStream(myImg);

using (var fileStream = File.Create("example1.png"))
{
    imgStream.CopyTo(fileStream);
}
```

You can see this example in more detail [here](https://github.com/TraceLD/PlotlySharp/tree/master/TraceLd.PlotlySharp/TraceLd.PlotlySharp.Example).


### Create a chart using a JSON object string
This method supports everything that the plot.ly API supports (supports all chart types that Plotly provides). For all possible chart options click [here](https://plot.ly/javascript/reference/).

```cs
using TraceLd.PlotlySharp;
```

```cs
// very basic example, hardcoding credentials is HIGHLY not recommended
PlotlyCredentials Func() => new PlotlyCredentials {Username = "username", Token = "token"};

// create a plotly client that will communicate with Plotly API
// provide your own HttpClient
PlotlyClient plotlyClient = new PlotlyClient(Client, Func);

// create a chart using a JSON object string (must be escaped)
var escapedJsonObjectString = "{\"figure\": {\"data\": [{\"y\": [10, 10, 2, 20]}], \"layout\": {\"width\": 700}}, \"width\": 1000, \"height\": 500, \"format\": \"png\", \"encoded\": false}";

byte[] myImg2 = await plotlyClient.GetChartAsByteArray(escapedJsonObjectString);

// save it to a file
var imgStream2 = new MemoryStream(myImg2);

using (var fileStream = File.Create("example2.png"))
{
    imgStream2.CopyTo(fileStream);
}
```
