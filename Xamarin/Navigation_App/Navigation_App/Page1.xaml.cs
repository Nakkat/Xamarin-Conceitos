using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var page = new Page2();
            
            Navigation.PushAsync(page);
            //NavigationPage.SetHasNavigationBar(page, false);
            NavigationPage.SetHasBackButton(page, false);

        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}