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
            
            for (int i = 0; i <= 6; i++)
            {
                trending.Items.Add(ViewModels.searchVM.outAppi(i));
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
            NavigationService.Navigate(new Page4());
        }

        
    }
}
