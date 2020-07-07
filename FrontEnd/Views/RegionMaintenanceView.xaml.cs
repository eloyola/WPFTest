using CrossCutting.Config;
using FrontEnd.ApiCaller;
using FrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrontEnd.Views
{
    /// <summary>
    /// Interaction logic for RegionMaintenanceView.xaml
    /// </summary>
    public partial class RegionMaintenanceView : Window
    {
        private IApiCaller _apiCaller;

        public RegionMaintenanceView()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var url = ConfigurationManager.AppSettings.Get("ServiceUrl");
            _apiCaller = new FrontEnd.ApiCaller.ApiCaller(url);
            var element = new RegionViewModel
            {
                Description = txtDescription.Text,
                Name = txtName.Text
            };
            var result = _apiCaller.PostServiceResponse<RegionViewModel>("Region", element);
        }
    }
}
