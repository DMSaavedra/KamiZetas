using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Kmisetas;

namespace KamiZetas
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        BaseDatos conex = new BaseDatos();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Declara Componentes 
            var txtUser = FindViewById<EditText>(Resource.Id.editText1);
            var txtPass = FindViewById<EditText>(Resource.Id.editText2);
            var btnIngresar = FindViewById<Button>(Resource.Id.button1);
            var btnRegistrar = FindViewById<Button>(Resource.Id.button2);

            btnIngresar.Click += delegate
            {
                if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
                {
                    Toast.MakeText(this, "Debe Ingresar los Campos", ToastLength.Long).Show();
                }
                else
                {
                    if (conex.Ingresar(txtUser.Text, txtPass.Text) == 1)
                    {
                        Intent intent = new Intent(this, typeof(menuAdmin));
                        StartActivity(intent);

                        Toast.MakeText(this, "Bienvenido ADMINISTRADOR", ToastLength.Short).Show();
                    }
                    else if (conex.Ingresar(txtUser.Text, txtPass.Text) == 2)
                    {
                        Intent intent = new Intent(this, typeof(Dashboard));
                        StartActivity(intent);

                        Toast.MakeText(this, "Bienvenido USUARIO", ToastLength.Short).Show();
                    }
                    else
                    {
                        Toast.MakeText(this, "Usuario/Contraseña Incorreccto", ToastLength.Short).Show();
                    }
                }
            };

            btnRegistrar.Click += delegate
            {
                Intent intent = new Intent(this, typeof(RegistroUs));
                StartActivity(intent);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}