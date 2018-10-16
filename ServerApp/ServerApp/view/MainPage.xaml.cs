using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using ServerApp.view;
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
        
        private async void OnSelected(Object sender, SelectedItemChangedEventArgs args)
        {
            Model model = args.SelectedItem as Model;
           
            if (model != null)
            {
               await Navigation.PushAsync(new DetailPage(model));
            }
        }
    }
}
