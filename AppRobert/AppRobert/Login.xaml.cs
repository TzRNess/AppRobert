using AppRobert.Models;
using AppRobert.Data;
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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {

            //Funcion del Boton login
           
            //Variables
            var Usuario = txtusu.Text;
            var Password = txtcon.Text;

            
            //Condicion que realiza una comparacion para poder acceder al sistema. 
            if (txtusu.Text == "Roberto" && txtcon.Text == "12345")
            {

                
                DisplayAlert("Correcto", "Inicio de sesion exitoso !", "Ok");
                Navigation.PushAsync(new pagCompra ());
                
                
                txtusu.Text = "";
                txtcon.Text = "";

                

            }
            else if (txtusu.Text == "" && txtcon.Text == "")
            {

                DisplayAlert("Ops...", "Debe completar los campos !", "Ok");


            }


            else if (txtusu.Text != "Roberto" && txtcon.Text != "12345")

            {
                DisplayAlert("Error", "Usuario o Contraseña incorrecta", "Ok");
                txtusu.Text = "";
                txtcon.Text = "";
            }

           
            else
            {

            }



        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
    }
}