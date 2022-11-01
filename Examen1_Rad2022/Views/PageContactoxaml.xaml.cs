using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;

namespace Examen1_Rad2022.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageContactoxaml : ContentPage
    {
        public PageContactoxaml()
        {
            InitializeComponent();

            pkPais.Items.Add("Honduras (504)");
            pkPais.Items.Add("Costa Rica (506)");
            pkPais.Items.Add("Guatemala (502)");
            pkPais.Items.Add("El Salvador (503)");
        }



        public void pickerPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private async void btnSalvar_Clicked(object sender, EventArgs e)
        {

            
            if (txtNota.Text == null || txtTelefono.Text == null || txtNombre.Text == null)
            {
                await DisplayAlert("Aviso", "Existen campos que no pueden quedar vacios, por favor revisa y rellena todo los campos", "Ok");
               
            }
            else
            {
                string seleccion = pkPais.SelectedItem.ToString();


                string opcion;

                if (seleccion == "Honduras (504)")
                    opcion = "Honduras";
                else if (seleccion == "Costa Rica (506)")
                    opcion = "Costa Rica";
                else if (seleccion == "Guatemala (502)")
                    opcion = "Guatemala";
                else
                    opcion = "El Salvador";


                var contactos = new Models.Contactos
                {
                    
                    Nombre = txtNombre.Text,
                    Pais = opcion,
                    Telefono = Convert.ToInt32(txtTelefono.Text),
                    Edad = Convert.ToInt32(txtEdad.Text),
                    Nota = txtNota.Text,

                };
                if (await App.dbcontactos.CrearContacto(contactos) > 0)
                    await DisplayAlert("Aviso", "Contacto Salvado", "OK");
            }

            

        }
    }
}