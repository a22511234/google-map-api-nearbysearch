using Newtonsoft.Json;
using System.IO;
using System.Net;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            google_map_api("", "25.022638619751678","121.47251498411259");

        }
        static void google_map_api(string userid ,string lat,string lng)
        {
            string sURL = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={lat},{lng}&radius=500&type=supermarket&keyword=%E9%A4%90%E5%BB%B3&key=AIzaSyBGAICU-ZH4QYDFSZW4jzgo9DWARe_pPrM";
            using (var client = new WebClient())
            using (var stream = client.OpenRead(sURL))
            using (var reader = new StreamReader(stream))
            using (var json = new JsonTextReader(reader))
            {
                var jObject = Newtonsoft.Json.Linq.JObject.Load(json);
                string location0_name = (string)jObject["results"][0]["name"];
                string location0_lat = (string)jObject["results"][0]["geometry"]["location"]["lat"];
                string location0_lng = (string)jObject["results"][0]["geometry"]["location"]["lng"];
                string location0_placeID = (string)jObject["results"][0]["place_id"];

            }
        }
        
    }
}
