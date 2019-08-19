using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using TraceLd.PlotlySharp;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<PlotlyCredentials> f = () => new PlotlyCredentials
            {
                Username = "private_plotly",
                Token = "k0yy0ztssk"
            };

            var h = new HttpClient();
            var c = new PlotlyClient(h, f);
            var reqBody = "{\"figure\": {\"data\": [{\"y\": [10, 10, 2, 20]}], \"layout\": {\"width\": 700}}, \"width\": 1000, \"height\": 500, \"format\": \"png\", \"encoded\": false}";

            var reqBody2 = new PlotPayload
            {
                Figure = new Figure
                {
                    Data = new List<Datum>() { new Datum
                    {
                        X = new List<int>() {1, 2, 3},
                        Y = new List<int>() {1, 2, 3},
                        Type = "bar"
                    }}
                },
                Format = "png",
                Height = 1000,
                Width = 1000
            };
            
            var img = c.GetPlotAsByteArray(reqBody2).GetAwaiter().GetResult();

            var imgS = new MemoryStream(img);
            
            using (var fileStream = File.Create("file.png"))
            {
                imgS.CopyTo(fileStream);
            }
        }
    }
}