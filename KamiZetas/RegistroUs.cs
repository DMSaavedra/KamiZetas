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
using Kmisetas;

namespace KamiZetas
{
    [Activity(Label = "RegistroUs")]
    public class RegistroUs : Activity
    {
        BaseDatos conex = new BaseDatos();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.registroUsrs);

            //Declaras Componentes
            var txtNombre = FindViewById<EditText>(Resource.Id.editText1);
            var txtCedula = FindViewById<EditText>(Resource.Id.editText2);
            var txtUsuario = FindViewById<EditText>(Resource.Id.editText3);
            var txtContraseña = FindViewById<EditText>(Resource.Id.editText4);
            var txtDireccion = FindViewById<EditText>(Resource.Id.editText5);
            var txtTelefono = FindViewById<EditText>(Resource.Id.editText6);
            var txtEmail = FindViewById<EditText>(Resource.Id.editText7);
            var txtTipoUsuario = FindViewById<EditText>(Resource.Id.editText8);

            var btnRegistrar = FindViewById<Button>(Resource.Id.button1);

            btnRegistrar.Click += delegate
            {
                if (txtNombre.Text != "" || txtCedula.Text != "" || txtUsuario.Text != "" || txtContraseña.Text != ""
                    || txtDireccion.Text != "" || txtTelefono.Text != "" || txtEmail.Text != "" || txtTipoUsuario.Text != "")
                {
                    conex.registrarUsuarios(txtNombre.Text, txtCedula.Text, txtUsuario.Text, txtContraseña.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text), txtEmail.Text, Convert.ToInt32(txtTipoUsuario.Text));

                    Toast.MakeText(this, "Usuario Registrado", ToastLength.Short).Show();
                    Intent intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "Debe Llenar Todos los Campos Solicitados", ToastLength.Short).Show();
                }
            };
        }
    }
}