using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatWS.Models.Solicitudes
{
    public class User
    {
        public string Nombres { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
       public int Estatus { get; set; }

    }
}