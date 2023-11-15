using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppRobert
{

    public partial class MainPage : MasterDetailPage

    {
        public MainPage()
        {

            InitializeComponent();
            this.Master = new Menu();
            this.Detail = new NavigationPage(new Detail());

            App.SetMAsterdet(this);


        }
    }
}
