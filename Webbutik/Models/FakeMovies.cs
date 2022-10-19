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
                BaseAddress = new Uri("https://movie-database-alternative.p.rapidapi.com/?r=json&i=tt4154796&plot=short"),

            };

            var response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                var strResponse = await response.Content.ReadAsStringAsync();
                var trimlist = JObject.Parse(strResponse)["items"].Children()["volumeInfo"].ToList();

                foreach (var item in trimlist)
                {
                    var tempmovie = new Movie();
                    var tempTitleList = new List<string>();
                    var tempDescriptionList = new List<string>();

                    foreach (var author in item["title"])
                    {
                        tempTitleList.Add(author.ToString());

                    }
                    try
                    {
                        foreach (var cat in item["description"])
                        {
                            tempDescriptionList.Add(cat.ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        tempDescriptionList.Add("Undefined");
                    }
                    tempmovie.Title = string.Join(", ", tempTitleList);
                    tempmovie.Description = string.Join(", ", tempDescriptionList);
                    tempmovie.ImageUrl = item["imageLinks"]["Posters"].ToString();
                    tempmovie.ReleaseDate = DateTime.Parse(item["Release date"].ToString());
                    tempmovie.Stars = item["actors"].ToString();
                    tempmovie.Writers = item["writers"].ToString();
                    tempmovie.Directors = item["directors"].ToString();
                    movielist.Add(tempmovie);
                }
            }
            return movielist;
        }
    }
}
