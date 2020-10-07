using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            SecondPage secondPage = new SecondPage();
            secondPage.ReturnInfoEvent += SecondPage_ReturnInfoEvent;

            await Navigation.PushAsync(secondPage);
        }

        private void SecondPage_ReturnInfoEvent(string returnInfo)
        {
            this.SaveButton.Text = returnInfo;
        }
    }
}
