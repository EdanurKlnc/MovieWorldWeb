using Microsoft.AspNetCore.Mvc;
using MovieWorldWeb.Models;
using MovieWorldWebEL.ResultModels;
using MovieWorldWebEL.ViewModels;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Policy;

namespace MovieWorldWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HomeUser()
        {
            try
            {
                string url = "https://api.themoviedb.org/3/movie/popular";
                List<string> movies = new List<string>();
                using (WebClient client = new WebClient()) // HttpClient WebClient
                {
                    //request.AddHeader("content-type", "application/json");
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    client.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMzQyY2MxMjliN2E1MTQzNWNmOTkwMDQ0NTM5MmYyYyIsInN1YiI6IjYyNGM4NjYzY2MyNzdjMDBhOTA5MDhhYyIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.YSjieGErqHj6xpEzpBnAFx_Ui2TdHkwIFdNBU5mGp_k");
                    string resultJSON = client.DownloadString(url);

                    var data = JsonConvert.DeserializeObject<ApiResultModel<List<ApiMovieVM>>>(resultJSON);

					return View(data.Results);

                }

			}
			catch (Exception ex)
            {

                return View();
            }

         

        }

        public IActionResult Privacy()
        {
            return View();
        }
		public IActionResult Login()
		{
			return View();
		}
		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}