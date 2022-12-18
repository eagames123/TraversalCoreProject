using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using TraversalCoreProject.Areas.Admin.Models;
using Newtonsoft.Json;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiMovieController : Controller
    {

        List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();


        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "9ee90010f2msh8169e8121c2b19ep180b72jsncbdbb0fc46a1" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
            }

            return View(apiMovieViewModels);
        }
    }
}
