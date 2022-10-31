﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Microsoft.EntityFrameworkCore;

namespace Webbutik.Models
{
    public class FakeMovies
    {



        public static async Task<List<Movie>> GetMoviesFromApi()
        {
            var movielist = new List<Movie>();
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://imdb-api.com/API/AdvancedSearch/k_acv9rwo6?title_type=feature")
            };

            var response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var strResponse = await response.Content.ReadAsStringAsync();
                var trimlist = JObject.Parse(strResponse)["results"].Children().ToList();

                foreach (var item in trimlist)
                {
                    var tempmovie = new Movie();
                    

                    tempmovie.Title = item["title"].ToString();
                    tempmovie.ImageUrl = item["image"].ToString();
                    movielist.Add(tempmovie);
                }
            }
            return movielist;
        }
    }
}
