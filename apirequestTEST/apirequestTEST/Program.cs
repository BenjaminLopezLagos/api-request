using System;
using System.IO;
using System.Net;

namespace apirequestTEST
{
    class Program
    {
        public void getRequest(string comida,string key)
        {
            var url = "https://api.nal.usda.gov/fdc/v1/foods/search?query="+comida+"&pageSize=1&api_key="+key;
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            var comida = "raw lemon";
            var key = "E9vO1XjsqjPkoBaoOkHr7GKqGnkfuroUDRHj8oem";
            p.getRequest(comida,key);
        }
    }
}
