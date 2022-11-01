using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1_Rad2022.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipalAgenda : ContentPage
    {
        public PaginaPrincipalAgenda()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            ListaContactos.ItemsSource = await App.dbcontactos.ListaContactos();
        }


        private void ListaContactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private  void btnAgregar_Clicked(object sender, EventArgs e)
        {

           
        }

        private async  void tbiAgregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageContactoxaml());
        }

        private async void tbiMapa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageMap());
        }
    }
}