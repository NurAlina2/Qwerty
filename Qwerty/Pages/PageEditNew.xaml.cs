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

namespace Qwerty.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditNew.xaml
    /// </summary>
    public partial class PageEditNew : Page
    {
        public PageEditNew(Product product)
        {
            InitializeComponent();
            //CmbxOwner.SelectedIndex = (int)product.ManufacturerID - 1;
            //CmbxOwner.SelectedValuePath = "ID";
            //CmbxOwner.DisplayMemberPath = "Name";
            //CmbxOwner.ItemsSource = ConnectDb.conbj.Manufacturer.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
