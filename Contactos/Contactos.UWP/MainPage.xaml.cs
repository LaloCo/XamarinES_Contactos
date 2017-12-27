using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Contactos.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            string nombreArchivo = "bd_contactos.sqlite";
            string rutaCarpeta = ApplicationData.Current.LocalFolder.Path;
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

            LoadApplication(new Contactos.App(rutaCompleta));
        }
    }
}
