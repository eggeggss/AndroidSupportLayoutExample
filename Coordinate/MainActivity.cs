using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.Design.Widget;

namespace Coordinate
{
    [Activity(Label = "Coordinate", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            

            var fab= this.FindViewById<com.refractored.fab.FloatingActionButton>(Resource.Id.fab);

            var cord= this.FindViewById<CoordinatorLayout>(Resource.Id.cord);


            
            fab.Click += (s1, e1) => {

                Snackbar.Make(cord, "Hello Snackbar", Snackbar.LengthShort).Show();

            };
            // Get our button from the layout resource,
            // and attach an event to it
            // Button button = FindViewById<Button>(Resource.Id.MyButton);

            // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

       
    }
}

