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
    [Activity(Label = "NacionalesCat")]
    public class NacionalesCat : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.catNacionales);

            //Declarar Componentes
            var list = FindViewById<ListView>(Resource.Id.listView1);

            List<string> datos2 = new List<string>();
            datos2.Add("Liga");
            datos2.Add("Barcelona");
            datos2.Add("Dep. Quito");
            datos2.Add("Dep. Cuenca");
            datos2.Add("Emelec");
            datos2.Add("Delfin");
            datos2.Add("Guayaquil City");
            datos2.Add("Aucas");
            datos2.Add("Nacional");

            list.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, datos2);
        }
    }
}