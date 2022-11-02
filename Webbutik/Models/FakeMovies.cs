using Newtonsoft.Json.Linq;
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
                    tempmovie.ImDbRating = item["imDbRating"].ToString();
                    tempmovie.Genres = item["genres"].ToString();
                    tempmovie.ContentRating = item["contentRating"].ToString();
                    tempmovie.Description = item["plot"].ToString();
                    tempmovie.RunTimeStr = item["runtimeStr"].ToString();
                    tempmovie.ReleaseDate = item["description"].ToString();
                    tempmovie.ImdbId = item["id"].ToString();

                    tempmovie.Stars = item["stars"].ToString();

                    tempmovie.Directors = item["stars"].ToString();
                    int index = tempmovie.Directors.IndexOf(",");
                    if (index >= 0)
                    {
                        tempmovie.Directors = tempmovie.Directors.Substring(0, index);
                    }

                    movielist.Add(tempmovie);
                }
            }
            return movielist;
        }
    }
}
