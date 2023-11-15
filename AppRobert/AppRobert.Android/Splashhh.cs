using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppRobert.Droid
{
    [Activity(  Label = "Epa!", 
                Theme = "@style/MyTheme.Splash",
                MainLauncher = false,
                NoHistory = true, 
                ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class Splashhh : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            

        }


        protected override async void OnResume()
            {

            base.OnResume();
            await SimulateStartup();


            }

        async Task SimulateStartup()
        {

            await Task.Delay(TimeSpan.FromSeconds(3));
            StartActivity(new Intent(Application.Context, typeof(Login)));

        }
    }

       

    }

