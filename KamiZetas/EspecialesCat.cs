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
    [Activity(Label = "EspecialesCat")]
    public class EspecialesCat : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.catEspeciales);

            //Declarar Componentes
            var list = FindViewById<ListView>(Resource.Id.listView1);

            List<string> datos = new List<string>();
            datos.Add("Mundial del 2002");
            datos.Add("La 10 de Leo");
            datos.Add("La 10 de Neymar");
            datos.Add("La 7 de Cristiano");
            datos.Add("La 11 de Chucho");
            datos.Add("Ecuatoriana Autografiada");

            list.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, datos);
        }
    }
}