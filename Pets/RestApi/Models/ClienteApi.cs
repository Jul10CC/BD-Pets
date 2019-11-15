using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class ClienteApi
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nit { get; set; }
        public string direccion { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
    }
}