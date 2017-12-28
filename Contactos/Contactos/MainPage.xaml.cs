using Contactos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contactos
{
	public partial class MainPage : ContentPage
	{
        List<Contacto> contactos;
		public MainPage()
		{
			InitializeComponent();

            contactos = new List<Contacto>();

            contactosListView.ItemSelected += ContactosListView_ItemSelected;
		}

        private void ContactosListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactoSeleccionado = e.SelectedItem as Contacto;

            Navigation.PushAsync(new DetallesContactoPage(contactoSeleccionado));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //using (var conn = new SQLite.SQLiteConnection(App.RUTA_DB))
            //{
            //    conn.CreateTable<Contacto>();
            //    contactos = conn.Table<Contacto>().ToList();

            //    contactosListView.ItemsSource = contactos;
            //}

            contactos = await App.MobileServiceClient.GetTable<Contacto>().ToListAsync();
            contactosListView.ItemsSource = contactos;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }
    }
}
