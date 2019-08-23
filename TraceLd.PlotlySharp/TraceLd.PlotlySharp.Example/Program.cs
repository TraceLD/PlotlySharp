using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TraceLd.PlotlySharp;
using TraceLd.PlotlySharp.Api;
using TraceLd.PlotlySharp.Api.Traces;

namespace TraceLd.PlotlySharp.Example
{
    class Program
    {
        public static readonly HttpClient Client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            /*
             * Example 1
             * 
             * Example of how to generate a chart using the built-in PlotlyChart type
             * and save it to a PNG file
             */
            
            // very basic example, hardcoding credentials is HIGHLY not recommended
            PlotlyCredentials Func() => new PlotlyCredentials { Username = "plotly_username", Token = "plotly_token" };

            // create a plotly client that will communicate with Plotly API
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
            
            Thread.Sleep(2000);
            
            /*
             * Example 2
             * 
             * Example of how to generate a chart using a JSON object string
             * and save it to a PNG file
             */
            
            // must be escaped
            var escapedJsonObjectString = "{\"figure\": {\"data\": [{\"y\": [10, 10, 2, 20]}], \"layout\": {\"width\": 700}}, \"width\": 1000, \"height\": 500, \"format\": \"png\", \"encoded\": false}";

            byte[] myImg2 = await plotlyClient.GetChartAsByteArray(escapedJsonObjectString);
            
            // save it to a file
            MemoryStream imgStream2 = new MemoryStream(myImg2);
            
            using (FileStream fileStream = File.Create("example2.png"))
            {
                imgStream2.CopyTo(fileStream);
            }
        }
    }
}