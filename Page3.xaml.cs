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
using System.Threading;


namespace traineeWPF
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
       

        public Page3()
        {
            InitializeComponent();
            
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
            string SearchId = TBSearch.Text;

            try
            {
                for (int i = 0; i < 3; i++)
                    SearchGrid.Items.Add(ViewModels.searchVM.outAPI(i, SearchId));
            }
            catch (Exception)
            {
                MessageBox.Show("Uncorrect name or id");
                TBSearch.Text = "";
            }
        }
    }
}
