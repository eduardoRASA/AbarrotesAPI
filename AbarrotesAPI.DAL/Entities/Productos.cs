using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AbarrotesAPI.DAL.Entities
{
    public class Productos
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string marca { get; set; }
        [Required]
        public string tipo { get; set; }
        [Required]
        public Double precio { get; set; }
        [Required]
        public int existencia { get; set; }

    }
}
