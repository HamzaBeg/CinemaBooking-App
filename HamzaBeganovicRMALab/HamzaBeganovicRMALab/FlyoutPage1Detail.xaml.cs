using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamzaBeganovicRMALab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPage1Detail : ContentPage
    {
        public FlyoutPage1Detail()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Booking());
        }
    }
}