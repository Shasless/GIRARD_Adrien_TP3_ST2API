using System;
using System.Net.Http;
using Newtonsoft.Json;


namespace ApiControler
{
    
    public class APIcontrol
    {
        private static readonly HttpClient Client = new HttpClient();
        public Root objectRes { get; set; }
        public Root objectRes2 { get; set; }

        
        public  async void GetCity(string lat, string lon)
        {
            var responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/weather?lat="+lat+"&lon="+lon+"&appid=02f51cc081aaadce756d51caf9911932&units=metric").Result;
            var res = await responseBody.Content.ReadAsStringAsync();
            //Console.WriteLine(res);
            objectRes = JsonConvert.DeserializeObject<Root>(res);

            
        }
        public  async void GetInfo2(string city)
        {
            Console.WriteLine(city);

            var responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q="+city+"&appid=02f51cc081aaadce756d51caf9911932&units=metric").Result;
            var res = await responseBody.Content.ReadAsStringAsync();
            Console.WriteLine(res);
            if (res == "{\"cod\":\"404\",\"message\":\"city not found\"}")
            {
                city = "Paris";
                responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q="+city+"&appid=02f51cc081aaadce756d51caf9911932&units=metric").Result;
                res = await responseBody.Content.ReadAsStringAsync();
            }
            objectRes = JsonConvert.DeserializeObject<Root>(res);
            
            
            
            responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/forecast?q="+city+"&appid=02f51cc081aaadce756d51caf9911932&units=metric").Result;
            res = await responseBody.Content.ReadAsStringAsync();
            // Console.WriteLine(res);
            objectRes2 = JsonConvert.DeserializeObject<Root>(res);
        }
        
    }
}