using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RedBit_App
{
    public partial class MainPage : ContentPage
    {
        int counter = 0;

        public MainPage()
        {
            InitializeComponent();
            
            Analytics.TrackEvent("Loading MainPage");
        }

        private async void btnClick_Clicked(object sender, EventArgs e)
        {
            bool isEnabled = await Analytics.IsEnabledAsync();
            counter++;
            lblClick.Text = counter.ToString();
            Analytics.TrackEvent($"Counter clicked: {counter}");
            System.Diagnostics.Debug.WriteLine($"Counter clicked: {counter}");
        }
    }
}
