﻿using Qwerty.Filee;
using Qwerty.Pages;
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

namespace Qwerty
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            FrameObj.frameMain = FrmMain;
            FrmMain.Navigate(new AuthPage());
            

        }

        

        private void BtnFaq_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click (object sender, RoutedEventArgs e)
        {

            
        }
    }
}