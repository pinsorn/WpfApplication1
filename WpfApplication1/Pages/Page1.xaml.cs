﻿using System;
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


namespace WpfApplication1.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if(textBox.Text == "")
            {
                MessageBox.Show("Please Enter Username","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                DataPage_Tranfer.SendData(textBox.Text);
                PageManager.Pages.Add(new Page2());
                PageManager.SwitchPage(typeof(Page2));


            }
        }
    }
}
