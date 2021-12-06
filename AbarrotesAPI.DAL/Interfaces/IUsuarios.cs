using AbarrotesAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbarrotesAPI.DAL.Interfaces
{
    public interface IUsuarios
    {
        //Expose functions required
        public List<Usuarios> GetUsuarios();
        public Usuarios GetUsuario(int id);
        public Usuarios AddUsuario(Usuarios usuario);
        public void UpdateUsuario(Usuarios usuario);
        public string DeleteUsuario(int id);
    }
}
