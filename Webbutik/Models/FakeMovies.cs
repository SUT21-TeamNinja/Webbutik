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
                BaseAddress = new Uri("https://imdb-api.com/en/API/Top250Movies/k_acv9rwo6")
            };

            var response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var strResponse = await response.Content.ReadAsStringAsync();
                var trimlist = JObject.Parse(strResponse)["items"].Children().ToList();

                foreach (var item in trimlist)
                {
                    var tempmovie = new Movie();
                    var tempTitleList = new List<string>();

                    foreach (var title in item["title"])
                    {
                        tempTitleList.Add(title.ToString());

                    }
                    try
                    {
                       
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    tempmovie.Title = string.Join(", ",tempTitleList);



                    
                    tempmovie.Directors = item["crew"].ToString();
                    tempmovie.ImageUrl = item["image"].ToString();
                    movielist.Add(tempmovie);
                }
            }
            return movielist;
        }
    }
}
