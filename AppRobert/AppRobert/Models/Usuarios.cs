using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppRobert.Models
{
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }
        [MaxLength(50)]

        public string Nombre { get; set; }
        [MaxLength(20)]

        public string Correo { get; set; }
        [MaxLength(30)]

        public string Usuario { get; set; }
        [MaxLength(20)]

        public int Contraseña { get; set; }
        [MaxLength(30)]

        public int ReContraseña { get; set; }
        
    }
}
