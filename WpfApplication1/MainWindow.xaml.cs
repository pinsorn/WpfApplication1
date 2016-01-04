using MahApps.Metro.Controls;
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
using WpfApplication1.Pages;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {

            InitializeComponent();
            InitPage();

        }
        private void InitPage()
        {
            PageManager.PageContent = Container;

            //Add Pages
            PageManager.Pages.Add(new Page1());
            PageManager.SwitchPage(typeof(Page1));
            // PageManager.Pages.Add(new ConfigPage());
            //End Pages Add

            //PageManager.SwitchPage(typeof(LoginPage));
        }
       

       
    }
}
