using CoreApi.Models;

namespace CoreApi.Services
{
    public interface ISerieMarvelService
    {
        Task<SeriesDataWrapper> GetSeriesAsync();
    }
}
