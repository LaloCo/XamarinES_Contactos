using Contactos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NuevoContactoPage : ContentPage
	{
		public NuevoContactoPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs args)
        {
            Contacto nuevoContacto = new Contacto()
            {
                Nombre = nombreEntry.Text,
                Apellido = apellidoEntry.Text,
                Telefono = telefonoEntry.Text,
                Email = emailEntry.Text
            };

            //using (var conn = new SQLite.SQLiteConnection(App.RUTA_DB))
            //{
            //    conn.CreateTable<Contacto>();
            //    conn.Insert(nuevoContacto);
            //}

            try
            {
                await App.MobileServiceClient.GetTable<Contacto>().InsertAsync(nuevoContacto);
                await DisplayAlert("Exito", "El contacto fue insertado", "Ok");
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", "El contacto no pudo ser insertado", "Ok");
            }
        }
    }
}