using Qwerty.Filee;
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
using System.Windows.Threading;
using Qwerty.Pages;

namespace Qwerty.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        public PageProduct()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();

        }


        public void UpdateData(object sender, object e)
        {

            var HistoryProduct = ConnectDb.conbj.Product.ToList();

            ListService.ItemsSource = HistoryProduct;
            ListService.ItemsSource = ConnectDb.conbj.Product.Where(x => x.Name.StartsWith(TxtSearch.Text) || x.Description.StartsWith(TxtSearch.Text)).ToList() ;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageEditNew ((sender as Button).DataContext as Product));
        }

        private void BtnEdit_Click_1о(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalehistory_Click(object sender, RoutedEventArgs e)
        {
            //FrameObj.frameMain.Navigate(new ((sender as Button).DataContext as Product));
        }
    }
 
}
