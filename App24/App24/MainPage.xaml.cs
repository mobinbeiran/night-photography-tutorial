using System;
using Xamarin.Forms;

namespace App24
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new secondpage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("تماس با ما", "لطفا نظرات و پیشنهادات خود را از طریق ایمیل زیر برای ما ارسال نمایید \r\n mobin.programing@gmail.com", "ok");
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fourthpage());
        }
    }
}
