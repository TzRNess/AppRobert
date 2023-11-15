using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppRobert.Data;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppRobert
{
    

    public partial class App : Application
    {
        static SQLiteHelper Db;


        public static MasterDetailPage MAsterdet { get; private set; }



        public static void SetMAsterdet(MasterDetailPage value)

        {
            MAsterdet = value;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage ( new MainPage());
        }

        public static SQLiteHelper SQLiteDB
        {
            get
            {

                if(Db == null)
                {
                    Db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Epa!"));
                }
                return Db;

            }

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
