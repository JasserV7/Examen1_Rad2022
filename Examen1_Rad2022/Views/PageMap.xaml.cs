using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Examen1_Rad2022.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMap : ContentPage
    {
        public PageMap()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var localizacion = await Geolocation.GetLocationAsync();

            Pin ubicacion = new Pin();
            ubicacion.Label = "Punto de referencia";
            ubicacion.Address = "Esta es tu ubicacion actual";
            ubicacion.Position = new Position(localizacion.Latitude, localizacion.Longitude);

            mapas.Pins.Add(ubicacion);

            mapas.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(localizacion.Latitude, localizacion.Longitude), Distance.FromKilometers(1)));


        }
    }
}