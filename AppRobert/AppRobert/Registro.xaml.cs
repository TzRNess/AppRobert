using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Provider;
using AppRobert.Data;
using AppRobert.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRobert
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            //Funcion de Registro
            
            //Funcion
            if (Validacion())
            {

                Usuarios Usua = new Usuarios
                {

                    //Variables correspondientes a cada cuadro de texto

                    Nombre = txtnom.Text,
                    Correo = txtcorreo.Text,
                    Usuario = txtusuario.Text,
                    Contraseña = int.Parse(txtpassword.Text),
                    ReContraseña =int.Parse(txtpassword2.Text)

                    

                };


                //Condicion si los campos estan completos

                await App.SQLiteDB.SaveUsuariosAsync(Usua);
                txtnom.Text = "";
                txtcorreo.Text = "";
                txtusuario.Text = "";
                txtpassword.Text = "";
                txtpassword2.Text = "";
                await DisplayAlert("Bienvenido a Epa!", "Sus datos se guardaron con exito", "Ok");


            }
            else
            {

                //Condicion si los campos no estan completos.

                await DisplayAlert("Opss...", "Debe completar los campos", "Ok");
            }

        }

        public bool Validacion()
        {

            //Compa que cada cuadro de texto no se encuentre vacio.

            bool Respuesta;
            if(string.IsNullOrEmpty(txtnom.Text))
            {
                Respuesta = false;
            }
            else if(string.IsNullOrEmpty(txtcorreo.Text))
                {
                Respuesta = false;
                }
            else if (string.IsNullOrEmpty(txtusuario.Text))
                {
                Respuesta = false;
                }
            else if (string.IsNullOrEmpty(txtpassword.Text))
                {
                Respuesta = false;
                }
            else if (string.IsNullOrEmpty(txtpassword2.Text))
                {
                Respuesta = false;
                }
            else
            {
                Respuesta = true;
            }

            return Respuesta;
        }

        //Funcion de botones Fb y Google.

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Detail());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Detail());
        }
    }
}