using System.Threading.Tasks;

namespace TraceLd.PlotlySharp
{
    public interface IPlotlyClient
    {
        Task<byte[]> GetChartAsByteArray(string chartJsonObjectString);
        Task<byte[]> GetChartAsByteArray(PlotlyChart plotlyChart);
    }
}