﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileDnr
{
    public partial class App : Application
    {
        public App()
        {
            DevExpress.XamarinForms.CollectionView.Initializer.Init();
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
