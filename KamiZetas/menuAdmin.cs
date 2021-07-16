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
    [Activity(Label = "menuAdmin", MainLauncher = false)]
    public class menuAdmin : Activity
    {
        //ImageButton btnMenu;
        //TextView txtResult;
        //ListView list;

        ////Lista Menu
        //List<string> datos = new List<string>();
        //List<string> datos2 = new List<string>();
        //List<string> datos3 = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.menuAdm);

            //Declarar Componentes
            var btnUsuarios = FindViewById<Button>(Resource.Id.button1);
            var btnProductos = FindViewById<Button>(Resource.Id.button2);
            var btnReportes = FindViewById<Button>(Resource.Id.button3);
            var btnPromo = FindViewById<Button>(Resource.Id.button4);

            btnUsuarios.Click += delegate
            {
                Intent intent = new Intent(this, typeof(RegistroUs2));
                StartActivity(intent);
            };

            btnProductos.Click += delegate
            {
                Intent intent = new Intent(this, typeof(RegistroProdc));
                StartActivity(intent);
            };

            //SetupViews();

            //btnMenu.Click += BtnMenu_Click;

            //datos.Add("Ecuador");
            //datos.Add("Brasil");
            //datos.Add("Argentina");
            //datos.Add("Colombia");
            //datos.Add("Chile");
            //datos.Add("Peru");
            //datos.Add("Paraguay");
            //datos.Add("Uruguay");
            //datos.Add("Venezuela");
            //datos.Add("Bolivia");

            //datos2.Add("Liga");
            //datos2.Add("Barcelona");
            //datos2.Add("Dep. Quito");
            //datos2.Add("Dep. Cuenca");
            //datos2.Add("Emelec");
            //datos2.Add("Delfin");
            //datos2.Add("Guayaquil City");
            //datos2.Add("Aucas");
            //datos2.Add("Nacional");

            //datos3.Add("Mundial del 96");
            //datos3.Add("La del Bixo");
        }

        //void SetupViews()
        //{
        //    btnMenu = FindViewById<ImageButton>(Resource.Id.imageButton1);
        //    txtResult = FindViewById<TextView>(Resource.Id.textView1);
        //    list = FindViewById<ListView>(Resource.Id.listView1);
        //}

        //private void BtnMenu_Click(object sender, EventArgs e)
        //{
        //    PopupMenu menu = new PopupMenu(this, btnMenu);
        //    menu.MenuInflater.Inflate(Resource.Drawable.menu_Items, menu.Menu);
        //    menu.MenuItemClick += Menu_MenuItemClick;
        //    menu.Show();
        //}

        //private void Menu_MenuItemClick(object sender, PopupMenu.MenuItemClickEventArgs e)
        //{
        //    string title = e.Item.TitleFormatted.ToString();
        //    switch (e.Item.ItemId)
        //    {
        //        case Resource.Id.btnNacionales:
        //            list.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, datos2);
        //            break;
        //        case Resource.Id.btnInternacionales:
        //            list.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, datos);
        //            break;
        //        case Resource.Id.btnEspeciales:
        //            list.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, datos3);
        //            break;
        //    }
        //}
    }
}