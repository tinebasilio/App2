using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnImagePageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImagePage());
        }
        private async void OnStackLayoutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }
        private async void OnGridActivityClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }

    }
}
