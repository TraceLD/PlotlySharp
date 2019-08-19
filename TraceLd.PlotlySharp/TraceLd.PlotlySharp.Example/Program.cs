using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using TraceLd.PlotlySharp;
using TraceLd.PlotlySharp.NestedPayloadModels;

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
            PlotlyCredentials Func() => new PlotlyCredentials {Username = "my_username", Token = "my_token"};

            // create a plotly client that will communicate with Plotly API
            PlotlyClient plotlyClient = new PlotlyClient(Client, Func);
            
            // create a chart
            PlotlyChart myChart = new PlotlyChart
            {
                Figure = new Figure
                {
                    Data = new List<Trace> { new Trace
                    {
                        X = new List<int> {1, 2, 3},
                        Y = new List<int> {1, 2, 3},
                        Type = "bar"
                    }, new Trace
                    {
                        X = new List<int> {1, 2, 3},
                        Y = new List<int> {1, 2, 3},
                        Type = "bar"
                    }},
                    Layout = new Layout
                    {
                        Colorway = new List<string> { "#636efa","#EF553B","#00cc96","#ab63fa","#19d3f3","#e763fa","#fecb52","#ffa15a","#ff6692","#b6e880" },
                        Title = new Title
                        {
                            Text = ""
                        },
                        PaperBgColor = "#1a1a23",
                        PlotBgColor = "#1a1a23",
                        Font = new PlotlyFont
                        {
                            Color = "#ebebeb"
                        }
                    }
                },
                Format = "png",
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
        }
    }
}