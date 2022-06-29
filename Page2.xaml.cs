using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace traineeWPF
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            Models.Coin outAppi(int x)
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
            for (int i = 0; i <= 6; i++)
            {
                trending.Items.Add(outAppi(i));
            }
            
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }
        private void P4_Click(object sender, RoutedEventArgs e)
        {
        NavigationService.Navigate(new Page4());
        }
        private void P5_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
