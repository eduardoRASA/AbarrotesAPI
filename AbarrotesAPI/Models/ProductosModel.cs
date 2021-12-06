using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbarrotesAPI.Models
{
    public class ProductosModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public Double precio { get; set; }
        public int existencia { get; set; }
    }
}
