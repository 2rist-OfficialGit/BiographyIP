using BiographyIP.Models;
using BiographyIP.Services;
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

namespace BiographyIP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ServiceInfoIP _serviceInfoIP;
        public MainWindow()
        {
            InitializeComponent();
            _serviceInfoIP = new ServiceInfoIP();
        }


        private async Task LoadIp(string ip)
        {
            try
            {
                ModelDataIP result = await _serviceInfoIP.GetModelDataIPAsync(ip);
                ListResult.Text = result.city;
            }
            catch (Exception ex)
            {
                MessageBox.Show("gg");
            }
        }

        private void CheckIp_Click(object sender, RoutedEventArgs e)
        {
            LoadIp(IPtxt.Text);
        }
    }
}
