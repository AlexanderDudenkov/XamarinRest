using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ServerApp
{
    public partial class MainPage : ContentPage
    {    
        public MainPage()
        {
            InitializeComponent();           
            this.BindingContext = new MainViewModel();          
        }

        private async void OnTapped(Object sender, ItemTappedEventArgs e) { }   
        
        private async void OnSelected(Object sender, SelectedItemChangedEventArgs args)
        {
            PhotosUrl o = args.SelectedItem as PhotosUrl;
            if (o != null)
            {
               await Navigation.PushAsync(new DetailPage(o));
            }
        }
    }
}
