﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoCorsoMattina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoTrigger();
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
