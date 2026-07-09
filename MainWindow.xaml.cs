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
        public ModelDataIP SetIpData { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.CanMinimize;
            SetIpData = new ModelDataIP();
            _serviceInfoIP = new ServiceInfoIP();
        }


        private async Task LoadIp(string ip)
        {
            try
            {
                SetIpData = await _serviceInfoIP.GetModelDataIPAsync(ip);
                DataContext = SetIpData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("gg");
            }
        }

        private void CheckIp_Click(object sender, RoutedEventArgs e)
        {
            string IPforAPI = IPtxt.Text;
            if (IPforAPI == "0.0.0.0")
                IPforAPI = "";
            LoadIp(IPforAPI);
        }
    }
}
