using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace Intro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Animate();
        }
        public async Task Animate()
        {

            await Task.Delay(TimeSpan.FromSeconds(8));
            Application.Current.MainPage = new Page1();

        }
    }
}
