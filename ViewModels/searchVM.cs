using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Media;
using System.Windows.Input;

namespace traineeWPF.ViewModels
{
    public class searchVM : INotifyPropertyChanged
    {
    

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs(propertyName));
        }
        
       
        public static Models.Root API(string URI)
        {
            WebRequest request = HttpWebRequest.Create(URI);//https://api.coingecko.com/api/v3/search?query=sol

            WebResponse response = request.GetResponse();
            System.Threading.Thread.Sleep(1000);
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json_search = reader.ReadToEnd();
            Models.Root myRoot = JsonConvert.DeserializeObject<Models.Root>(json_search);
            return myRoot;

        }
        public static Models.Coin outAPI(int x,string SearchId)
        {
            Models.Coin second = new Models.Coin();
            //https://api.coingecko.com/api/v3/coins/solana?market_data=true
            second.market_cap_rank = API($"https://api.coingecko.com/api/v3/search?query={SearchId}").coins[x].market_cap_rank;
            second.id = API($"https://api.coingecko.com/api/v3/search?query={SearchId}").coins[x].id;
            second.name = API($"https://api.coingecko.com/api/v3/search?query={SearchId}").coins[x].name;
            Debug.WriteLine(second.name);
            second.symbol = API($"https://api.coingecko.com/api/v3/search?query={SearchId}").coins[x].symbol.ToUpper();
            Debug.WriteLine(second.symbol);

            //first.sparkline_in_7d = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false").coins[0].sparkline_in_7d;
            return second;
            
        }
        public static Models.Coin outAppi(int x)
        {
            Models.Coin trend = new Models.Coin();
            trend.thumb = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/search/trending").coins[x].item.thumb;
            trend.score = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/search/trending").coins[x].item.score;
            trend.name = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/search/trending").coins[x].item.name;
            trend.symbol = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/search/trending").coins[x].item.symbol;
            trend.coin_id = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/search/trending").coins[x].item.coin_id;
            trend.market_cap_rank = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/search/trending").coins[x].item.market_cap_rank;
            trend.price_btc = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/search/trending").coins[x].item.price_btc;

            return trend;
        }
        public static Models.Root t10API(int x)
        {
            Models.Root first = new Models.Root();
            first.market_cap_rank = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false")[x].market_cap_rank;
            Debug.Write(first);
            first.name = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false")[x].name;
            first.symbol = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false")[x].symbol.ToUpper();
            first.current_price = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false")[x].current_price;
            first.price_change_percentage_1h_in_currency = Models.API_.APIs_("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&price_change_percentage=1h")[x].price_change_percentage_1h_in_currency;
            first.price_change_percentage_24h_in_currency = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&price_change_percentage=24h")[x].price_change_percentage_24h_in_currency;
            first.price_change_percentage_7d_in_currency = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&price_change_percentage=7d")[x].price_change_percentage_7d_in_currency;
            first.total_volume = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false")[x].total_volume;
            first.market_cap = Models.API_.APIs("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false")[x].market_cap;
            //first.sparkline_in_7d = ViewModels.searchVM.API("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false").coins[0].sparkline_in_7d;
            return first;
        }

        public static Models.Solana solApi(string coin_, string val)
        {
            
            Models.Solana sol = new Models.Solana();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                
                sol.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").solana.usd;
                sol.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.usd_24h_change;
            }
            if (val == "uah")
            {
                sol.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").solana.uah;
                sol.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.uah_24h_change;
            }
            if (val == "eur")
            {
                sol.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").solana.eur;
                sol.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.eur_24h_change;
            }
            if (val == "eth")
            {
                sol.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").solana.eth;
                sol.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.eth_24h_change;
            }
            if (val == "bits")
            {
                sol.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").solana.bits;
                sol.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.bits_24h_change;
            }
            if (val == "btc")
            {
                sol.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").solana.btc;
                sol.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.btc_24h_change;
            }
            if (val == "sats")
            {
                sol.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").solana.sats;
                sol.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.sats_24h_change;
            }
            return sol;
        }
        public static Models.Bitcoin bitApi(string coin_, string val)
        {

            Models.Bitcoin bitc = new Models.Bitcoin();
            
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                bitc.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").bitcoin.usd;
                bitc.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").bitcoin.usd_24h_change;
            }
            if (val == "uah")
            {
                bitc.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").bitcoin.uah;
                bitc.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").bitcoin.uah_24h_change;
            }
            if (val == "eur")
            {
                bitc.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").bitcoin.eur;
                bitc.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").bitcoin.eur_24h_change;
            }
            if (val == "eth")
            {
                bitc.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").bitcoin.eth;
                bitc.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").bitcoin.eth_24h_change;
            }
            if (val == "bits")
            {
                bitc.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").bitcoin.bits;
                bitc.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").bitcoin.bits_24h_change;
            }
            if (val == "btc")
            {
                bitc.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").bitcoin.btc;
                bitc.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").bitcoin.btc_24h_change;
            }
            if (val == "sats")
            {
                bitc.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").bitcoin.sats;
                bitc.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").bitcoin.sats_24h_change;
            }
            return bitc;
        }
        public static Models.Ethereum ethApi(string coin_, string val)
        {

            Models.Ethereum ethe = new Models.Ethereum();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                ethe.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").ethereum.usd;
                ethe.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").ethereum.usd_24h_change;
            }
            if (val == "uah")
            {
                ethe.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").ethereum.uah;
                ethe.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").ethereum.uah_24h_change;
            }
            if (val == "eur")
            {
                ethe.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").ethereum.eur;
                ethe.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").ethereum.eur_24h_change;
            }
            if (val == "eth")
            {
                ethe.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").ethereum.eth;
                ethe.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").ethereum.eth_24h_change;
            }
            if (val == "bits")
            {
                ethe.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").ethereum.bits;
                ethe.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").ethereum.bits_24h_change;
            }
            if (val == "btc")
            {
                ethe.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").ethereum.btc;
                ethe.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").ethereum.btc_24h_change;
            }
            if (val == "sats")
            {
                ethe.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").ethereum.sats;
                ethe.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").ethereum.sats_24h_change;
            }
            return ethe;
        }
        public static Models.TerraLuna2 terApi(string coin_, string val)
        {

            Models.TerraLuna2 ter = new Models.TerraLuna2();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                ter.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").TerraLuna2.usd;
                ter.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").TerraLuna2.usd_24h_change;
            }
            if (val == "uah")
            {
                ter.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").TerraLuna2.uah;
                ter.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").TerraLuna2.uah_24h_change;
            }
            if (val == "eur")
            {
                ter.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").TerraLuna2.eur;
                ter.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").TerraLuna2.eur_24h_change;
            }
            if (val == "eth")
            {
                ter.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").TerraLuna2.eth;
                ter.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").TerraLuna2.eth_24h_change;
            }
            if (val == "bits")
            {
                ter.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").TerraLuna2.bits;
                ter.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").TerraLuna2.bits_24h_change;
            }
            if (val == "btc")
            {
                ter.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").TerraLuna2.btc;
                ter.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").TerraLuna2.btc_24h_change;
            }
            if (val == "sats")
            {
                ter.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").TerraLuna2.sats;
                ter.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").TerraLuna2.sats_24h_change;
            }
            return ter;
        }
        public static Models.Stepn stepApi(string coin_, string val)
        {

            Models.Stepn step = new Models.Stepn();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                step.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").stepn.usd;
                step.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").stepn.usd_24h_change;
            }
            if (val == "uah")
            {
                step.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").stepn.uah;
                step.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").stepn.uah_24h_change;
            }
            if (val == "eur")
            {
                step.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").stepn.eur;
                step.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").stepn.eur_24h_change;
            }
            if (val == "eth")
            {
                step.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").stepn.eth;
                step.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").stepn.eth_24h_change;
            }
            if (val == "bits")
            {
                step.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").stepn.bits;
                step.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").stepn.bits_24h_change;
            }
            if (val == "btc")
            {
                step.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").stepn.btc;
                step.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").stepn.btc_24h_change;
            }
            if (val == "sats")
            {
                step.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").stepn.sats;
                step.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").stepn.sats_24h_change;
            }
            return step;
        }
        public static Models.Binancecoin binApi(string coin_, string val)
        {

            Models.Binancecoin bin = new Models.Binancecoin();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                bin.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").binancecoin.usd;
                bin.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").binancecoin.usd_24h_change;
            }
            if (val == "uah")
            {
                bin.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").binancecoin.uah;
                bin.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").binancecoin.uah_24h_change;
            }
            if (val == "eur")
            {
                bin.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").binancecoin.eur;
                bin.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").binancecoin.eur_24h_change;
            }
            if (val == "eth")
            {
                bin.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").binancecoin.eth;
                bin.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").binancecoin.eth_24h_change;
            }
            if (val == "bits")
            {
                bin.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").binancecoin.bits;
                bin.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").binancecoin.bits_24h_change;
            }
            if (val == "btc")
            {
                bin.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").binancecoin.btc;
                bin.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").binancecoin.btc_24h_change;
            }
            if (val == "sats")
            {
                bin.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").binancecoin.sats;
                bin.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").binancecoin.sats_24h_change;
            }
            return bin;
        }
        public static Models.Dogecoin dogApi(string coin_, string val)
        {

            Models.Dogecoin dog = new Models.Dogecoin();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                dog.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").dogecoin.usd;
                dog.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").dogecoin.usd_24h_change;
            }
            if (val == "uah")
            {
                dog.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").dogecoin.uah;
                dog.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").dogecoin.uah_24h_change;
            }
            if (val == "eur")
            {
                dog.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").dogecoin.eur;
                dog.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").dogecoin.eur_24h_change;
            }
            if (val == "eth")
            {
                dog.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").dogecoin.eth;
                dog.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").dogecoin.eth_24h_change;
            }
            if (val == "bits")
            {
                dog.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").dogecoin.bits;
                dog.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").dogecoin.bits_24h_change;
            }
            if (val == "btc")
            {
                dog.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").dogecoin.btc;
                dog.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").dogecoin.btc_24h_change;
            }
            if (val == "sats")
            {
                dog.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").dogecoin.sats;
                dog.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").dogecoin.sats_24h_change;
            }
            return dog;
        }
        public static Models.Tether tethApi(string coin_, string val)
        {

            Models.Tether teth = new Models.Tether();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                teth.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").tether.usd;
                teth.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").tether.usd_24h_change;
            }
            if (val == "uah")
            {
                teth.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").tether.uah;
                teth.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").tether.uah_24h_change;
            }
            if (val == "eur")
            {
                teth.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").tether.eur;
                teth.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").tether.eur_24h_change;
            }
            if (val == "eth")
            {
                teth.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").tether.eth;
                teth.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").tether.eth_24h_change;
            }
            if (val == "bits")
            {
                teth.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").tether.bits;
                teth.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").tether.bits_24h_change;
            }
            if (val == "btc")
            {
                teth.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").tether.btc;
                teth.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").tether.btc_24h_change;
            }
            if (val == "sats")
            {
                teth.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").tether.sats;
                teth.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").tether.sats_24h_change;
            }
            return teth;
        }
        public static Models.Litecoin liteApi(string coin_, string val)
        {

            Models.Litecoin lite = new Models.Litecoin();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                lite.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").litecoin.usd;
                lite.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").litecoin.usd_24h_change;
            }
            if (val == "uah")
            {
                lite.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").litecoin.uah;
                lite.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").litecoin.uah_24h_change;
            }
            if (val == "eur")
            {
                lite.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").litecoin.eur;
                lite.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").litecoin.eur_24h_change;
            }
            if (val == "eth")
            {
                lite.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").litecoin.eth;
                lite.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").litecoin.eth_24h_change;
            }
            if (val == "bits")
            {
                lite.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").litecoin.bits;
                lite.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").litecoin.bits_24h_change;
            }
            if (val == "btc")
            {
                lite.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").litecoin.btc;
                lite.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").litecoin.btc_24h_change;
            }
            if (val == "sats")
            {
                lite.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").litecoin.sats;
                lite.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").litecoin.sats_24h_change;
            }
            return lite;
        }
        public static Models.Avalanche2 avaApi(string coin_, string val)
        {

            Models.Avalanche2 ava = new Models.Avalanche2();
            if (val == "usd") //uah, usd, btc, eur, eth, bits, sats
            {
                ava.usd = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").Avalanche2.usd;
                ava.usd_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.usd_24h_change;
            }
            if (val == "uah")
            {
                ava.uah = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").Avalanche2.uah;
                ava.uah_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.uah_24h_change;
            }
            if (val == "eur")
            {
                ava.eur = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").Avalanche2.eur;
                ava.eur_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").solana.eur_24h_change;
            }
            if (val == "eth")
            {
                ava.eth = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").Avalanche2.eth;
                ava.eth_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").Avalanche2.eth_24h_change;
            }
            if (val == "bits")
            {
                ava.bits = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").Avalanche2.bits;
                ava.bits_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").Avalanche2.bits_24h_change;
            }
            if (val == "btc")
            {
                ava.btc = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").Avalanche2.btc;
                ava.btc_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").Avalanche2.btc_24h_change;
            }
            if (val == "sats")
            {
                ava.sats = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}" + "&include_24hr_change=true").Avalanche2.sats;
                ava.sats_24h_change = API($"https://api.coingecko.com/api/v3/simple/price?ids={coin_}&vs_currencies={val}&include_24hr_change=true").Avalanche2.sats_24h_change;
            }
            return ava;
        }
        





    }
    
}
