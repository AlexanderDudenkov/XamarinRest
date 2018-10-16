using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ServerApp.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Model model)
		{
			InitializeComponent ();
            image.Source = model.PhotosUrl.Regular;
            author.Text = model.User.Name;
            total_collections.Text = model.User.Total_collections.ToString();
            total_likes.Text = model.User.Total_likes.ToString();
            total_photos.Text = model.User.Total_photos.ToString();
        }
	}
}
