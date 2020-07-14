﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactApp
{
    public partial class App : Application
    {
        public static string FilePath { get; internal set; }

        public App()
        {
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