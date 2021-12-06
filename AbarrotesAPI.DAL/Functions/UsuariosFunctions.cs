using AbarrotesAPI.DAL.DataContext;
using AbarrotesAPI.DAL.Entities;
using AbarrotesAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbarrotesAPI.DAL.Functions
{
    public class UsuariosFunctions : IUsuarios
    {
        
        public Usuarios AddUsuario(Usuarios usuario)
        {
            using (var _context = new DatabaseContext(DatabaseContext.options.dbOptions))
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            
            return usuario;
        }

        public string DeleteUsuario(int id)
        {
            string mensaje = "";
            using(var _context = new DatabaseContext(DatabaseContext.options.dbOptions))
            {
                Usuarios usuario = _context.Usuarios.FirstOrDefault(x => x.id == id);
                if (usuario != null)
                {
                    _context.Remove(usuario);
                    _context.SaveChanges();
                    mensaje = "El usuario fue eliminado de manera satisfactoria";
                }
                else
                {
                    mensaje = "El usuario con id: " + id + " no existe en la base de datos";
                }
                return mensaje;
            }
        }

        public Usuarios GetUsuario(int id)
        {
            using(var _context = new DatabaseContext(DatabaseContext.options.dbOptions))
            {
                return _context.Usuarios.Find(id);
            }
        }

        public List<Usuarios> GetUsuarios()
        {
            using (var _context = new DatabaseContext(DatabaseContext.options.dbOptions))
            {
                return _context.Usuarios.ToList();
            }
        }

        public void UpdateUsuario(Usuarios usuario)
        {
            using (var _context = new DatabaseContext(DatabaseContext.options.dbOptions))
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
            }
        }
    }
}
