namespace TraceLd.PlotlySharp
{
    using System;

    public class PlotlyResponseErrorException : Exception
    {
        public PlotlyResponseErrorException()
        {
        }

        public PlotlyResponseErrorException(string message)
            : base(message)
        {
        }

        public PlotlyResponseErrorException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}