using FrontEnd.ApiCaller;
using FrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for RegionList.xaml
    /// </summary>
    public partial class RegionList : Window
    {
        private IApiCaller _apiCaller;

        public RegionList()
        {
            InitializeComponent();
            //Refresh();
        }

        private void Refresh()
        {
            var url = ConfigurationManager.AppSettings.Get("ServiceUrl");
            _apiCaller = new FrontEnd.ApiCaller.ApiCaller(url);
            var data = _apiCaller.GetServiceResponse<List<RegionViewModel>>("Region");
            dgRegion.ItemsSource = data.Result;
        }
    }
}
