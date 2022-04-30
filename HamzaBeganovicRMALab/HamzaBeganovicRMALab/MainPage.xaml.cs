using HamzaBeganovicRMALab.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace HamzaBeganovicRMALab
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Film> myListMovies;

        public ObservableCollection<Film> MyListMovies
        {
            get { return myListMovies; }
            set { myListMovies = value; }
        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            MyListMovies = new ObservableCollection<Film>();
            MyListMovies.Add(new Film() { Id = 1, Naziv = "Spider Man No Way Home", Image = "spiderMan.jpg" , Ocjena= "7.5",Opis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing" });
            MyListMovies.Add(new Film() { Id = 1, Naziv = "Spider Man No Way Home", Image = "spiderMan.jpg", Ocjena = "7.5", Opis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing" });
            MyListMovies.Add(new Film() { Id = 1, Naziv = "Spider Man No Way Home", Image = "spiderMan.jpg", Ocjena = "7.5", Opis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing" });
            MyListMovies.Add(new Film() { Id = 1, Naziv = "Spider Man No Way Home", Image = "spiderMan.jpg", Ocjena = "7.5", Opis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing" });

            ListMovies.ItemsSource = MyListMovies;

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registration());
        }
    }
}
