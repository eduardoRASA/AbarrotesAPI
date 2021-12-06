using AbarrotesAPI.BAL.Services;
using AbarrotesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AbarrotesAPI.Controllers
{
    [Route("api/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private ProductosService _productosService = new ProductosService();
        //GetProductos
        [Route("GetProductos")]
        [HttpGet]
        public List<ProductosModel> GetProductos()
        {
            List<ProductosModel> productosList = new List<ProductosModel>();
            var productos = _productosService.GetProductos();
            if(productos.Count > 0)
            {
                foreach(var producto in productos)
                {
                    ProductosModel currentProducto = new ProductosModel
                    {
                        id = producto.id,
                        nombre = producto.nombre,
                        marca = producto.marca,
                        tipo = producto.tipo,
                        precio = producto.precio,
                        existencia = producto.existencia
                    };
                    productosList.Add(currentProducto);
                }
            }
            return productosList;
        }
    }
}
