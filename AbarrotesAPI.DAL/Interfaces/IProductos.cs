using AbarrotesAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbarrotesAPI.DAL.Interfaces
{
    public interface IProductos
    {
        //Expose functions required
        public List<Productos> GetProductos();
    }
}
