using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KIM_STYLE.Models
{
    public class UserModel
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Contra { get; set; } = string.Empty;
        public int Tipo_usuario { get; set; }

    }
}