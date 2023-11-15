using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRobert.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRobert
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : CarouselPage
    {

        ObservableCollection<InfoImagenes> Lista;

        public Detail()
        {
            InitializeComponent();

            //Funciones Hijo

            Lista = new ObservableCollection<InfoImagenes>
             {

             new InfoImagenes {Imagen = "logo1.png", Texto = "Aplicacion de roberto",
                    Presentacion ="Somos una empresa justa para vos"},
             new InfoImagenes {Imagen = "logo2.png", Texto = "Aplicacion de Alejandro",
                    Presentacion ="Somos lo que tanto buscabas" },
             new InfoImagenes {Imagen = "logo4.png", Texto = "Aplicacion de Gino",
                    Presentacion ="Somos lo que tanto buscabas" },

         };
             ItemsSource = Lista;

        }

    }
}

