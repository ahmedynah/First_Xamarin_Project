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

namespace Intro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail_FoodPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetail_FoodPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetail_FoodPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetail_FoodPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetail_FoodPageMasterMenuItem> MenuItems { get; set; }

            public MasterDetail_FoodPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetail_FoodPageMasterMenuItem>(new[]
                {
                    new MasterDetail_FoodPageMasterMenuItem { Id = 0, Title = "Profile" },
                    new MasterDetail_FoodPageMasterMenuItem { Id = 1, Title = "Home" },
                    new MasterDetail_FoodPageMasterMenuItem { Id = 2, Title = "Orders" },
                    new MasterDetail_FoodPageMasterMenuItem { Id = 3, Title = "Offers" }
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