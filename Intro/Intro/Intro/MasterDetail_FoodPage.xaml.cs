using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail_FoodPage : MasterDetailPage
    {
        public MasterDetail_FoodPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetail_FoodPageMasterMenuItem;
            if (item == null)
                return;
            Application.Current.MainPage = new Page1();

            /*          var page = (Page)Activator.CreateInstance(item.TargetType);
                      page.Title = item.Title;

                      Detail = new NavigationPage(page);
                      IsPresented = false;

                      MasterPage.ListView.SelectedItem = null;
              */
        }
    }
}