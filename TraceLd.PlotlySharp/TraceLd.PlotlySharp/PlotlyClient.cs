using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TraceLd.PlotlySharp
{
    public class PlotlyClient : IDisposable, IPlotlyClient
    {
        private readonly HttpClient _httpClient;
        private readonly bool _ownsHttpClient;
        private readonly Func<PlotlyCredentials> _credProvider;
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore
        };
        
        public PlotlyClient(Func<PlotlyCredentials> credProvider)
        {
            _credProvider = credProvider;
            _httpClient = new HttpClient();
            _ownsHttpClient = true;
        }
        
        public PlotlyClient(HttpClient httpClient, Func<PlotlyCredentials> credProvider)
        {
            _httpClient = httpClient;
            _credProvider = credProvider;
            _ownsHttpClient = false;
        }
        
        private async Task<byte[]> PostReceiveByteArray(string reqContent, string uri)
        {
            if (_credProvider is null)
            {
                throw new AuthenticationException("credProvider can't be null");
            }
            
            var creds = _credProvider();
            var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{creds.Username}:{creds.Token}"));

            using (var req = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(uri),
                Content = new StringContent(reqContent, Encoding.UTF8, "application/json")
            })
            {
                req.Headers.Authorization = new AuthenticationHeaderValue("Basic", auth);
                req.Headers.Add("Plotly-Client-Platform", "csharp");

                using (var res = await _httpClient.SendAsync(req))
                {
                    if (!res.IsSuccessStatusCode)
                    {
                        throw new PlotlyResponseErrorException(res.StatusCode.ToString());
                    }

                    return await res.Content.ReadAsByteArrayAsync();
                }
            }
        }
        
        public async Task<byte[]> GetChartAsByteArray(string chartJsonObjectString)
        {
            var imgRes = await PostReceiveByteArray(chartJsonObjectString, "https://api.plot.ly/v2/images/");

            return imgRes;
        }
        
        public async Task<byte[]> GetChartAsByteArray(PlotlyChart plotlyChart)
        {
            var serializedPayload = JsonConvert.SerializeObject(plotlyChart, 
                Formatting.None, _serializerSettings);
            
            var imgRes = await PostReceiveByteArray(serializedPayload, "https://api.plot.ly/v2/images/");
            
            return imgRes;
        }


        #region IDisposable Support
        private bool _disposedValue; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    if(_ownsHttpClient)
                    {
                        _httpClient.Dispose();
                    }
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}