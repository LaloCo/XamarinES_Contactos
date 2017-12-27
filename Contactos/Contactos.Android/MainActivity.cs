using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;

namespace Contactos.Droid
{
    [Activity(Label = "Contactos", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            string nombreArchivo = "bd_contactos.sqlite";
            string rutaCarpeta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

            LoadApplication(new App(rutaCompleta));
        }
    }
}

