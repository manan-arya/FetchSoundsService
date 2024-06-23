using FetchSoundsService.Interfaces;
using FetchSoundsService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace FetchSoundsService.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWishlistAgent mWishlistAgent;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWishlistAgent wishlistAgent)
        {
            _logger = logger;
            mWishlistAgent = wishlistAgent;
        }

        [Authorize(Roles = "Everyone")]
        //[AllowAnonymous]
        [HttpGet(Name = "GetSounds")]
        public IEnumerable<SoundsData> Get()
        {
            int id = Convert.ToInt32(User.Claims.First(x => x.Type == "ID").Value);
            IList<SoundsData> result = mWishlistAgent.GetWishlist(id);
            return result;
            
        }
    }
}