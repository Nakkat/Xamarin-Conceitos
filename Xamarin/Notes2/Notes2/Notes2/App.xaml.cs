using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FolderPath = Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData));
            MainPage = new NavigationPage(new NotesPage());
        }

        public static string FolderPath { get; private set; }
   
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
