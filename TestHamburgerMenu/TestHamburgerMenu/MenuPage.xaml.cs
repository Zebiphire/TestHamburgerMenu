using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestHamburgerMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "Menu";
            InitializeComponent();
        }


        public async void NavigateButtonPageOne_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        public async void NavigateButtonPageTwo_OnClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }

        private async Task NavigateButtonPageOne_OnClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}