using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using SQLite;

namespace Examen1_Rad2022.Controllers
{
    public class DBContactos
    {

        readonly SQLiteAsyncConnection _conectar;

        //vacio
        public DBContactos()
        {

        }

        //parametros
        public DBContactos(string dbpath)
        {
            _conectar= new SQLiteAsyncConnection(dbpath); 

            _conectar.CreateTableAsync<Models.Contactos>().Wait();


        }


        //Crud

        
        public Task<int> CrearContacto(Models.Contactos contact)
        {

            if (contact.Id!=0) {
                return _conectar.UpdateAsync(contact);
            }
            else
            {
                return _conectar.InsertAsync(contact);
            }

        }

       
        public Task<List<Models.Contactos>> ListaContactos()
        {
            return _conectar.Table<Models.Contactos>().ToListAsync();
        }


        public Task<Models.Contactos> GetContactos(int prc)
        {
            return _conectar.Table<Models.Contactos>()
                .Where(i => i.Id == prc)
                .FirstOrDefaultAsync();
        }


        public Task<int> BorrarContacto(Models.Contactos contact)
        {
            return _conectar.DeleteAsync(contact);
        }

    }
}
