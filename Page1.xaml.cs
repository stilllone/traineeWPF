using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            MessageBox.Show("Страница загружается,могло бы и быстрее, но нельзя делать столько запросов, i'm sorry");
            for (int i = 0; i < 10; i++)
            {
                    top10.Items.Add(ViewModels.searchVM.t10API(i));
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
        
        private void P5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        
    }
    
}
