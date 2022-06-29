using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Threading;


namespace traineeWPF.Models
{
    public class API_
    {
        public static List<Root> APIs(string URI)
        {

            WebRequest request = HttpWebRequest.Create(URI);//https://api.coingecko.com/api/v3/search?query=sol
            WebResponse response = request.GetResponse();
            System.Threading.Thread.Sleep(1500);

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json_search_ = reader.ReadToEnd();

            List<Root> myDeserializedRoot = JsonConvert.DeserializeObject<List<Root>>(json_search_);

            return myDeserializedRoot;


        }
        public static List<Root> APIs_(string URI)
        {

            WebRequest request = HttpWebRequest.Create(URI);//https://api.coingecko.com/api/v3/search?query=sol
            WebResponse response = request.GetResponse();
            System.Threading.Thread.Sleep(1500);

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json_search_ = reader.ReadToEnd();

            List<Root> myDeserializedRoot = JsonConvert.DeserializeObject<List<Root>>(json_search_);

            return myDeserializedRoot;


        }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Coin
    {
        public string id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public int? market_cap_rank { get; set; }
        public string thumb { get; set; }
        public string large { get; set; }
        public double price_btc { get; set; }
        public int score { get; set; }
        public int coin_id { get; set; }
        public double current_price { get; set; }

        public SparklineIn7d sparkline_in_7d { get; set; }
        public Item item { get; set; }
    }

    public class Exchange
    {
        public string id { get; set; }
        public string name { get; set; }
        public string market_type { get; set; }
        public string thumb { get; set; }
        public string large { get; set; }
    }

    public class Nft
    {
        public string id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string thumb { get; set; }
    }
    public class Item
    {
        public string id { get; set; }
        public int coin_id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public int? market_cap_rank { get; set; }
        public string thumb { get; set; }
        public string small { get; set; }
        public string large { get; set; }
        public string slug { get; set; }
        public double price_btc { get; set; }
        public int score { get; set; }
    }
    public class SparklineIn7d
    {
        public List<double> price { get; set; }
    }
    public class Bitcoin
    {
        public double uah { get; set; } //uah, usd, btc, eur, eth, bits, sats
        public double uah_24h_change { get; set; }
        public double usd { get; set; }
        public double usd_24h_change { get; set; }
        public double btc { get; set; }
        public double btc_24h_change { get; set; }
        public double eur { get; set; }
        public double eur_24h_change { get; set; }
        public double eth { get; set; }
        public double eth_24h_change { get; set; }
        public double bits { get; set; }
        public double bits_24h_change { get; set; }
        public double sats { get; set; }
        public double sats_24h_change { get; set; }
    }
    public class Solana : Bitcoin
    {

    }
    public class Ethereum : Bitcoin
    {

    }
    public class TerraLuna2: Bitcoin
    {
    }
    public class Stepn: Bitcoin
    {
    }
    public class Binancecoin : Bitcoin
    {
    }
    public class Dogecoin: Bitcoin
    {
    }
    public class Tether : Bitcoin
    {
    }
    public class Litecoin : Bitcoin
    {
    }
    public class Avalanche2 : Bitcoin
    {
        
    }


    public class Root : ViewModels.searchVM
    {
        public List<string> MyArray { get; set; }
        public List<Coin> coins { get; set; }
        public List<Exchange> exchanges { get; set; }
        public List<object> icos { get; set; }
        public List<Category> categories { get; set; }
        public List<Nft> nfts { get; set; }
        public List<Item> items { get; set; }
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public double current_price { get; set; }
        public double market_cap { get; set; }
        public int? market_cap_rank { get; set; }
        public long? fully_diluted_valuation { get; set; }
        public object total_volume { get; set; }
        public double high_24h { get; set; }
        public double low_24h { get; set; }
        public double price_change_24h { get; set; }
        public double price_change_percentage_24h { get; set; }
        public double market_cap_change_24h { get; set; }
        public double market_cap_change_percentage_24h { get; set; }
        public double circulating_supply { get; set; }
        public double? total_supply { get; set; }
        public long? max_supply { get; set; }
        public double ath { get; set; }
        public double ath_change_percentage { get; set; }
        public DateTime ath_date { get; set; }
        public double atl { get; set; }
        public double atl_change_percentage { get; set; }
        public DateTime atl_date { get; set; }
        public DateTime last_updated { get; set; }
        public SparklineIn7d sparkline_in_7d { get; set; }
        public double price_change_percentage_24h_in_currency { get; set; }
        public double price_change_percentage_1h_in_currency { get; set; }
        public double price_change_percentage_7d_in_currency { get; set; }

        public Bitcoin bitcoin { get; set; }
        public Solana solana { get; set; }
        public Ethereum ethereum { get; set; }
        [JsonProperty("terra-luna-2")]
        public TerraLuna2 TerraLuna2 { get; set; }
        public Stepn stepn { get; set; }
        public Binancecoin binancecoin { get; set; }
        public Dogecoin dogecoin { get; set; }
        public Tether tether { get; set; }
        public Litecoin litecoin { get; set; }
        [JsonProperty("avalanche-2")]
        public Avalanche2 Avalanche2 { get; set; }
    }


}
