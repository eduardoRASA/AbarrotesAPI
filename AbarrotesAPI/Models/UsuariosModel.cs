using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbarrotesAPI.Models
{
    public class UsuariosModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public int tipo { get; set; }
    }
}
