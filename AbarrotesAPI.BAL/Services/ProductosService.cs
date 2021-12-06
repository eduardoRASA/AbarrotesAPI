using System.Collections.Generic;
using AbarrotesAPI.DAL.Entities;
using AbarrotesAPI.DAL.Functions;
using AbarrotesAPI.DAL.Interfaces;

namespace AbarrotesAPI.BAL.Services
{
    public class ProductosService 
    {   
        private IProductos _productos = new ProductosFunctions();
        //Get productos
        public List<Productos> GetProductos()
        {
            List<Productos> productos = _productos.GetProductos();
            return productos;
        }
    }
}
