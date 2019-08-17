using System;
using System.Net.Http;

namespace TraceLd.PlotlySharp
{
    public class PlotlyClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly bool _ownsHttpClient = false;
        private readonly Action<PlotlyCredentials> _credProvider;
        
        public PlotlyClient(Action<PlotlyCredentials> credProvider)
        {
            _credProvider = credProvider;
            _httpClient = new HttpClient();
            _ownsHttpClient = true;
        }

        public PlotlyClient(HttpClient httpClient, Action<PlotlyCredentials> credProvider)
        {
            _httpClient = httpClient;
            _credProvider = credProvider;
            _ownsHttpClient = false;
        } 

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

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