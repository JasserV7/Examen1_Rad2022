using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Examen1_Rad2022
{
    public partial class App : Application
    {

        static Controllers.DBContactos dbContactos;

        public static Controllers.DBContactos dbcontactos
        {
            get
            {
                if(dbContactos == null)
                {
                    string DBName = "contact.db3";
                    string PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dbContactos= new Controllers.DBContactos(PathDB);
                }

                return dbContactos;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PaginaPrincipalAgenda());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
