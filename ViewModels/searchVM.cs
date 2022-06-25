using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Net;

namespace traineeWPF.ViewModels
{
    public class searchVM
    {
        public static Models.Root searchAPI(string URI)
        {
            WebRequest request = HttpWebRequest.Create(URI);//https://api.coingecko.com/api/v3/search?query=sol
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string json_search = reader.ReadToEnd();
            Models.Root myRoot = JsonConvert.DeserializeObject<Models.Root>(json_search);
            //Coin myCoin = JsonConvert.DeserializeObject<Coin>(json_search);
            return myRoot;

        }
    }
    
}
