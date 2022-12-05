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
    /// Логика взаимодействия для RegistPage.xaml
    /// </summary>
    public partial class RegistPage : Page
    {
        public RegistPage()
        {
            InitializeComponent();
        }

        private void RegistBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string passwword = PasswordTb.Password.Trim();
            string firstname = FirstNameTb.Text.Trim();
            string lastname = LastNameTb.Text.Trim();
            string patronymic = PatronymicTb.Text.Trim();
            string email = EmailTb.Text.Trim();
            if (login.Length > 0 && passwword.Length > 0)
            {
                ConnectDb.conbj.User.Add(new User
                {
                    Login = login,
                    Password = passwword,
                    FirstName = firstname,
                    LastName = lastname,
                    Patronymic = patronymic,
                    Email = email,
                    RoleId = 2

                }) ; 
                ConnectDb.conbj.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");
                FrameObj.BackPage();

            }

            else
                MessageBox.Show("Заполните поля");



        }

       

        private void ClearBtn_Click_1(object sender, RoutedEventArgs e)
        {
            LoginTb.Text = "";
            PasswordTb.Password = "";
        }
    }
}

