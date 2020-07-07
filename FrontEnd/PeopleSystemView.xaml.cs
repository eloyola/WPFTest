using CrossCutting.Config;
using FrontEnd.ApiCaller;
using FrontEnd.Model;
using FrontEnd.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace FrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PeopleSystemView : Window
    {
        private readonly IAppConfig _appConfig;
        private IApiCaller _apiCaller;

        public PeopleSystemView()
        {
            //_appConfig = appConfig;
            InitializeComponent();
            //Refresh();
        }

        private async Task Refresh()
        {
            var url = ConfigurationManager.AppSettings.Get("ServiceUrl");
            _apiCaller = new FrontEnd.ApiCaller.ApiCaller(url);
            var data = await _apiCaller.GetServiceResponse<List<RegionViewModel>>("Region");
            dgRegion.ItemsSource = data;
        }

        private void btnRegion_Click(object sender, RoutedEventArgs e)
        {
            var regionview = new RegionMaintenanceView();
            regionview.Owner = this;
            regionview.ShowDialog();

        }

        private void btnRegionList_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
