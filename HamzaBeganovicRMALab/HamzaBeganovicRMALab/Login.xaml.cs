using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamzaBeganovicRMALab.Tables;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamzaBeganovicRMALab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegistrationUser>();
            var myquery = db.Table<RegistrationUser>().Where(u => u.UserName.Equals(txtUsername.Text) && u.Password1.Equals(txtPassword.Text)).FirstOrDefault();
            if (myquery != null)
            {
                Navigation.PushAsync(new FlyoutPage1());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    DisplayAlert("Neuspjesna prijava", "Unesite ponovo podatke", "Ok");
                });
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registration());
        }
    }
}