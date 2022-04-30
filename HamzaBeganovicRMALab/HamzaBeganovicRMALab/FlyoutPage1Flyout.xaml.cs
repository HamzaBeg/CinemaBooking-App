using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamzaBeganovicRMALab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPage1Flyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPage1Flyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutPage1FlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class FlyoutPage1FlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutPage1FlyoutMenuItem> MenuItems { get; set; }

            public FlyoutPage1FlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutPage1FlyoutMenuItem>(new[]
                {
                    new FlyoutPage1FlyoutMenuItem { Id = 0, Title = "Lista filmova", TargetType=typeof(MainPage) },
                    new FlyoutPage1FlyoutMenuItem { Id = 1, Title = "Bukiraj mjesto", TargetType=typeof(Booking) },
                    new FlyoutPage1FlyoutMenuItem { Id = 2, Title = "Logout", TargetType=typeof(Login) },

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}