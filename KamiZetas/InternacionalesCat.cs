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
    [Activity(Label = "InternacionalesCat", MainLauncher = false)]
    public class InternacionalesCat : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.catInternacionales);

            //Declarar Componentes
            var list = FindViewById<ListView>(Resource.Id.listView1);

            List<string> datos = new List<string>();
            datos.Add("Ecuador");
            datos.Add("Brasil");
            datos.Add("Argentina");
            datos.Add("Colombia");
            datos.Add("Chile");
            datos.Add("Peru");
            datos.Add("Paraguay");
            datos.Add("Uruguay");
            datos.Add("Venezuela");
            datos.Add("Bolivia");

            list.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, datos);
        }
    }
}