using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRobert.homePage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRobert
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private async void BtnIniciar_Clicked(object sender, EventArgs e)
        {

            App.MAsterdet.IsPresented = false;
            await App.MAsterdet.Detail.Navigation.PushAsync(new Login());

        }

        private async void BtnComprar_Clicked(object sender, EventArgs e)
        {
            App.MAsterdet.IsPresented = false;
            await App.MAsterdet.Detail.Navigation.PushAsync(new pagCompra());

        }

       
    }
}