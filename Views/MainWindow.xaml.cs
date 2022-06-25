using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Net;
using CoinGecko;


namespace traineeWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            var client = new RestClient("https://api.coingecko.com/api/v3/search?query=bitcoin");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            
            //request.AddJsonBody(body);
            var response = client.Execute(request);
        }

        private void TB1_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }
        

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string searchCoin = TextB1.Text;
            //TextB1.Text = searchCoin;
            Models.Root myRoot = ViewModels.searchVM.searchAPI($"https://api.coingecko.com/api/v3/search?query={searchCoin}");
            // Coin myCoin = JsonConvert.DeserializeObject<Coin>(json_search);
            //MessageBox.Show(myRoot.coins[0].name);
            TB1.Text = myRoot.coins[0].name + "\r\n" + myRoot.coins[0].symbol + "\r\n" + myRoot.coins[0].market_cap_rank.ToString();

           
            Gr1.Background = Brushes.White;//color change

        }
    }
}
