using AbarrotesAPI.DAL.DataContext;
using AbarrotesAPI.DAL.Entities;
using AbarrotesAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbarrotesAPI.DAL.Functions
{
    public class ProductosFunctions : IProductos
    { 
        //GetProductos
        public List<Productos> GetProductos()
        {
            List<Productos> productos = new List<Productos>();
            using(var _context = new DatabaseContext(DatabaseContext.options.dbOptions))
            {
                productos = _context.Productos.ToList();
            }
            return productos;
        }
    }
}
