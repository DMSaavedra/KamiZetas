using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace KamiZetas
{
    [Activity(Label = "Dashboard", MainLauncher = false)]
    public class Dashboard : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Dashboard);

            //Declarar Componentes

            var btnNac = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var btnInter = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var btnEspc = FindViewById<ImageButton>(Resource.Id.imageButton3);

            btnNac.Click += delegate
            {
                Intent intent = new Intent(this, typeof(NacionalesCat));
                StartActivity(intent);
            };

            btnInter.Click += delegate
            {
                Intent intent = new Intent(this, typeof(InternacionalesCat));
                StartActivity(intent);
            };

            btnEspc.Click += delegate
            {
                Intent intent = new Intent(this, typeof(EspecialesCat));
                StartActivity(intent);
            };
        }
    }
}