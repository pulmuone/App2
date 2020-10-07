using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    public delegate void ReturnInfoEventHandler(string returnInfo);

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {

        public event ReturnInfoEventHandler ReturnInfoEvent;

        public SecondPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            //if(ReturnInfoEvent != null)
            //{
            //    ReturnInfoEvent(this.UserID.Text);
            //}

            ReturnInfoEvent?.Invoke(this.UserID.Text);


            //SecondPage 화면 종료.
            await Navigation.PopAsync();
        }
    }
}