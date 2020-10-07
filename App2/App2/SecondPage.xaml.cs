using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    //Event Handler 정의
    //이벤트에 가입하는 외부 가입자 측에서는 이벤트가 발생했을 때 어떤 명령들을 실행할 지를 
    //지정해 주는데, 이를 이벤트 핸들러라 한다.
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
            //이벤트에 가입한 가입자들이 있는지 체크
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