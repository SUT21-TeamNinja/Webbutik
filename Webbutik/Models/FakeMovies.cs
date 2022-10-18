using Newtonsoft.Json.Linq;

namespace Webbutik.Models
{
    public class FakeMovies
    {



        public static async Task<List<Movie>> GetMoviesFromApi()
        {
            var movielist = new List<Movie>();
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://imdb8.p.rapidapi.com/auto-complete?q=game%20of%20thr"),

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
                    tempmovie.ImageUrl = item["imageLinks"]["thumbnail"].ToString();
                    tempmovie.ReleaseDate = DateTime.Parse(item["releasedate"].ToString());
                    tempmovie.Stars = item["stars"].ToString();
                    tempmovie.Writers = item["writers"].ToString();
                    tempmovie.Directors = item["directors"].ToString();
                    movielist.Add(tempmovie);
                }
            }
            return movielist;
        }
    }
}
