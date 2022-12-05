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
using Qwerty.Filee;
using Qwerty.Pages;
namespace Qwerty.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    //LoginTb.Text = Properties.Settings.Default.Login;
    {
        public AuthPage()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Login != null)
                LoginTb.Text = Properties.Settings.Default.Login;
            if (Properties.Settings.Default.Password != null)
                PasswordTb.Password = Properties.Settings.Default.Password;
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {

            string login = LoginTb.Text.Trim();
            string password = PasswordTb.Password.Trim();
            if (login.Length == 0 && password.Length == 0)
            {
                MessageBox.Show("Пусто! Пожалуйста заполните поля.");
            }
            else
            {
                FrameObj.AuthUser = ConnectDb.conbj.User.ToList().Find(x => x.Login == login && x.Password == password);

                if (FrameObj.AuthUser == null)
                {
                    MessageBox.Show("Извините, такого пользователя не существует!");
                }
                else
                {
                    if (SaveCb.IsChecked == true)
                    {
                        Properties.Settings.Default.Login = LoginTb.Text;
                        Properties.Settings.Default.Password = PasswordTb.Password;
                        Properties.Settings.Default.Save();
                    }
                    FrameObj.isAuth = true;
                    FrameObj.frameMain.Navigate(new PageMain());

                }
            }

        }

        private void RegistBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new RegistPage());
        }
    }
}
