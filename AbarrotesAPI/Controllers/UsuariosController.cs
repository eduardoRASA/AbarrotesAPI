using AbarrotesAPI.BAL.Services;
using AbarrotesAPI.DAL.Entities;
using AbarrotesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbarrotesAPI.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private UsuariosService _usuariosService = new UsuariosService();

        [HttpGet]
        [Route("GetUsuarios")]
        public List<UsuariosModel> GetUsuarios()
        {
            List<UsuariosModel> usuariosList = new List<UsuariosModel>();
            var usuarios = _usuariosService.GetUsuarios();
            if (usuarios != null)
            {
                foreach (var usuario in usuarios)
                {
                    UsuariosModel currentUsuario = new UsuariosModel
                    {
                        id = usuario.id,
                        nombre = usuario.nombre,
                        apellido1 = usuario.apellido1,
                        apellido2 = usuario.apellido2,
                        tipo = usuario.tipo,
                        correo = usuario.correo,
                        celular = usuario.celular
                    };
                    usuariosList.Add(currentUsuario);
                }
                return usuariosList;
            }
            else
            {
                return null;
            }
        }

        [HttpGet]
        [Route("GetUsuario")]
        public UsuariosModel GetUsuario(int id)
        {
            UsuariosModel usuarioModel = new UsuariosModel();
            var usuario = _usuariosService.GetUsuario(id);
            if(usuario != null)
            {
                usuarioModel.id = usuario.id;
                usuarioModel.nombre = usuario.nombre;
                usuarioModel.apellido1 = usuario.apellido1;
                usuarioModel.apellido2 = usuario.apellido2;
                usuarioModel.tipo = usuario.tipo;
                usuarioModel.correo = usuario.correo;
                usuarioModel.celular = usuario.celular;
                return usuarioModel;
            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        [Route("UpdateUsuario")]
        public IActionResult UpdateUsuario(UsuariosModel usuario)
        {
            Usuarios user = new Usuarios();
            user.id = usuario.id;
            user.nombre = usuario.nombre;
            user.apellido1 = usuario.apellido1;
            user.apellido2 = usuario.apellido2;
            user.tipo = usuario.tipo;
            user.correo = usuario.correo;
            user.celular = usuario.celular;
            _usuariosService.UpdateUsuario(user);
            return Ok();
        }

        [HttpPost]
        [Route("AddUsuario")]
        public IActionResult AddUsuario(UsuariosModel usuario)
        {
            Usuarios user = new Usuarios();
            user.id = usuario.id;
            user.nombre = usuario.nombre;
            user.apellido1 = usuario.apellido1;
            user.apellido2 = usuario.apellido2;
            user.tipo = usuario.tipo;
            user.correo = usuario.correo;
            user.celular = usuario.celular;
            _usuariosService.AddUsuario(user);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteUsuario")]
        public IActionResult DeleteUsuario(int id)
        {
            string mensaje = _usuariosService.DeleteUsuario(id);
            return Ok(mensaje);
        }
    }
}
