using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Contactos
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
        }

        public static string RUTA_DB;
        public App(string ruta_bd)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            RUTA_DB = ruta_bd;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
