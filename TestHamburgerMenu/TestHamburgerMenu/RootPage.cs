﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestHamburgerMenu
{
    public partial class RootPage : MasterDetailPage
    {
        public RootPage()
        {
            //InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}
