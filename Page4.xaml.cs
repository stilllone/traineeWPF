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
using System.Diagnostics;

namespace traineeWPF
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public string[] valute { get; set; }
        public string[] currCoin { get; set; }
       
        public Page4()
        {
            InitializeComponent();
            
            valute = new string[] { "btc", "eth", "uah", "usd", "eur", "bits", "sats"};
            currCoin = new string[] { "Bitcoin", "Solana","Ethereum","Terra-Luna-2", "StepN", "BinanceCoin", "Dogecoin", "Tether", "Litecoin", "Avalanche-2" };
            DataContext = this;

            
            
        }
        private void C1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Coin_ = C1.SelectedItem.ToString();
           
            //if (Coin_ == "Bitcoin")
            //    Coin_ = "bitcoin";
            //if (Coin_ == "Solana")
            //    Coin_ = "solana";
            //if (Coin_ == "Ethereum")
            //    Coin_ = "ethereum";
            //if (Coin_ == "Terra(Luna)")
            //    Coin_ = "terra-luna-2";
            //if (Coin_ == "StepN")
            //    Coin_ = "stepn";
            //if (Coin_ == "BNB")
            //    Coin_ = "binancecoin";
            //if (Coin_ == "Dogecoin")
            //    Coin_ = "dogecoin";
            //if (Coin_ == "Tether")
            //    Coin_ = "tether";
            //if (Coin_ == "Litecoin")
            //    Coin_ = "litecoin";
            //if (Coin_ == "Avalanche")
            //    Coin_ = "avalanche-2";
            
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
            NavigationService.Navigate(new Page2());
        }
        
        private void P5_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(C1.SelectedItem);
            try
            {
                Binding uah = new Binding("uah");
                Binding uah_24h_change = new Binding("uah_24h_change");
                Binding btc = new Binding("btc");
                Binding btc_24h_change = new Binding("btc_24h_change");
                Binding eth = new Binding("eth");
                Binding eth_24h_change = new Binding("eth_24h_change");
                Binding usd = new Binding("usd");
                Binding usd_24h_change = new Binding("usd_24h_change");
                Binding eur = new Binding("eur");
                Binding eur_24h_change = new Binding("eur_24h_change");
                Binding sats = new Binding("sats");
                Binding sats_24h_change = new Binding("sats_24h_change");
                Binding bits = new Binding("bits");
                Binding bits_24h_change = new Binding("bits_24h_change");
                

                if (into_.SelectedItem == "btc")
                {
                    valuta.Binding = uah;
                    h24.Binding = uah_24h_change;
                }
                if (into_.SelectedItem == "eth")
                {
                    valuta.Binding = eth;
                    h24.Binding = eth_24h_change;
                }
                if (into_.SelectedItem == "uah")
                {
                    valuta.Binding = uah;
                    h24.Binding = uah_24h_change;
                }
                if (into_.SelectedItem == "usd")
                {
                    valuta.Binding = usd;
                    h24.Binding = usd_24h_change;
                }
                if (into_.SelectedItem == "eur")
                {
                    valuta.Binding = eur;
                    h24.Binding = eur_24h_change;
                }
                if (into_.SelectedItem == "bits")
                {
                    valuta.Binding = bits;
                    h24.Binding = bits_24h_change;
                }
                if (into_.SelectedItem == "sats")
                {
                    valuta.Binding = sats;
                    h24.Binding = sats_24h_change;
                }


                if (C1.SelectedItem == "Solana")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.solApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "Bitcoin")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.bitApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "Ethereum")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.ethApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "Terra-Luna-2")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.terApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "StepN")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.stepApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "BinanceCoin")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.binApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "Dogecoin")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.dogApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "Litecoin")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.liteApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "Tether")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.tethApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                if (C1.SelectedItem == "Avalanche-2")
                {
                    ConvertGrid.Items.Add(ViewModels.searchVM.avaApi($"{C1.SelectedItem}", $"{into_.SelectedItem}"));
                }
                
                

            }
            catch (Exception)
            {
                MessageBox.Show("Somethign goes wrong");
            }
        }

        
    }
}
