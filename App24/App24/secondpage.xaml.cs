using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App24
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class secondpage : ContentPage
    {
        public secondpage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}