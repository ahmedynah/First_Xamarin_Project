﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void food_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MasterDetail_FoodPage());
        }

        private void groc_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MasterDetail_FoodPage());
        }
    }
}