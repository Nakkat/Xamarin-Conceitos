using ContactApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        void NewContactToolbarItem_Clicked(object sender,System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }


        //ersonalizem o comportamento imediatamente antes de o Page se tornar visível.
        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "contact.db3")))
            {
                conn.CreateTable<Contact>();
                var contacts = conn.Table<Contact>().ToList();


            }


        }
    }
}