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
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtRegisterPassword1.Text == txtRegisterPassword2.Text)
            {
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                db.CreateTable<RegistrationUser>();
                var item = new RegistrationUser()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    UserName = txtUserName.Text,
                    Password1 = txtRegisterPassword1.Text,
                    Password2 = txtRegisterPassword2.Text
                };
                db.Insert(item);
                Device.BeginInvokeOnMainThread(async () =>
                {
                    DisplayAlert("Uspjesna registracija", "Uspjesno ste se registrovali", "Ok");
                    Navigation.PushAsync(new Login());
                });
            }
            else
            {
                DisplayAlert("Neuspjesna registracija", "Sifre se ne podudaraju", "Ok");
            }
        }
    }
}