using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;
using SQLite;

namespace Examen1_Rad2022.Models
{
    public class Contactos
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } 

        [MaxLength(75)]
        public string Nombre { get; set; }

        [MaxLength(20)]
        public int Telefono { get; set; }

        public int Edad { get; set; }


        [MaxLength(50)]
        public string Pais { get; set; }


        [MaxLength(200)]
        public string Nota { get; set; }
        
        



    }
}
