﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestHamburgerMenu
{
    public partial class App : Application
    {
        public NavigationPage NavigationPage { get; private set; } 
 
 
        public App()
        {
            var menuPage = new MenuPage();
            NavigationPage = new NavigationPage(new MainPage());
            var rootPage = new RootPage();
            rootPage.Master = menuPage;
            rootPage.Detail = NavigationPage;
            MainPage = rootPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
