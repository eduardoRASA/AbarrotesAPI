using AbarrotesAPI.DAL.Entities;
using AbarrotesAPI.DAL.Functions;
using AbarrotesAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbarrotesAPI.BAL.Services
{
    public class UsuariosService
    {
        private IUsuarios _usuarios = new UsuariosFunctions();
        //Get productos
        public List<Usuarios> GetUsuarios()
        {
            List<Usuarios> usuarios = _usuarios.GetUsuarios();
            return usuarios;
        }
        public Usuarios GetUsuario(int id)
        {
            Usuarios usuario = _usuarios.GetUsuario(id);
            return usuario;
        }
        public Usuarios AddUsuario(Usuarios usuario)
        {
            _usuarios.AddUsuario(usuario);
            return usuario;
        }
        public void UpdateUsuario(Usuarios usuario)
        {
            _usuarios.UpdateUsuario(usuario);
        }
        public string DeleteUsuario(int id)
        {
            string mensaje = "";
            _usuarios.DeleteUsuario(id);
            return mensaje;
        }
    }
}
