using CoreApi.Models;
using CoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SeriesMarvelController : Controller
    {
        private readonly SerieMarvelService _serieMarvelService;

        public SeriesMarvelController(SerieMarvelService serieMarvelService)
        {
            _serieMarvelService = serieMarvelService;
        }
        [HttpGet(Name = "GetSeries")]
        public async Task<ActionResult<List<SeriesDataWrapper>>> GetSeries()
        {
            var series = await _serieMarvelService.GetSeriesAsync();
            if (series == null )
            {
                return NotFound();
            }

            return Ok(series);
        }
    }
}
