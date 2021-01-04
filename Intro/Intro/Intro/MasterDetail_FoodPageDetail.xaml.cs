using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro.classes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail_FoodPageDetail : ContentPage
    {
        public MasterDetail_FoodPageDetail()
        {
            InitializeComponent();
       
            MainListView.ItemsSource = new List<ListViewTemplate>

            {
            new ListViewTemplate
                {
                    Name = "Fire Bird",
                    Description = "Lorem ipsum dolor sit amet," +
                    " consectetur adipiscing elit. Cras semper malesuada arcu a faucibus." +
                    " et gravida sapien sapien sit amet purus",
                    Price = "50 LE"
               },
               new ListViewTemplate
               {
                   Name = "KOKO on Fire",
                   Description = "Lorem ipsum dolor sit amet," +
                    " consectetur adipiscing elit. Cras semper malesuada arcu a faucibus." +
                    " et gravida sapien sapien sit amet purus",
                   Price = "70 LE"
                },
                new ListViewTemplate
                {
                    Name = "Fajhita Paradise",
                    Description = "Lorem ipsum dolor sit amet," +
                    " consectetur adipiscing elit. Cras semper malesuada arcu a faucibus." +
                    " et gravida sapien sapien sit amet purus",
                    Price = "60 LE"
               },
               new ListViewTemplate
               {
                   Name = "LaLa Land's Burger",
                   Description = "Lorem ipsum dolor sit amet," +
                    " consectetur adipiscing elit. Cras semper malesuada arcu a faucibus." +
                    " et gravida sapien sapien sit amet purus",
                   Price = "55 LE"
               }
           };
        }
        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as ListViewTemplate;

               ((ListView)sender).SelectedItem = null;


        }
    }
}