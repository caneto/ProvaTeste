using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using LiteDB;   

namespace WebApi.Controllers
{
    /// <summary>
    /// Controle para usuario
    /// </summary>
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        /// <summary>
        ///  Metodo para Cadastro de Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public HttpResponseMessage CadastrarUsuario(UsuarioModel usuario)
        {
            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                // Get customer collection
                var usuarios = db.GetCollection<UsuarioModel>("usuarios");

               
                // Insert new customer document (Id will be auto-incremented)
                usuarios.Insert(usuario);

            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Metodo para Alteracao de Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public HttpResponseMessage AlterarCliente(UsuarioModel usuario)
        {

            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                var usuarios = db.GetCollection<UsuarioModel>("usuarios");

                usuarios.Update(usuario);

            }

            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        /// <summary>
        /// Metodo para Delecao do Usuario
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{codigo}")]
        public HttpResponseMessage ExcluirUsuario(int codigo)
        {
            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                var usuarios = db.GetCollection<UsuarioModel>("usuarios");
                usuarios.Delete(i => i.Id == codigo);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Metodo para Consulta de um unico usuario
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{codigo}")]
        public List<UsuarioModel> ConsultarUsuarioPorCodigo(int codigo)
        {

            var retorno = new List<UsuarioModel>();

            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                // Get customer collection
                var usuarios = db.GetCollection<UsuarioModel>("usuarios");
                var results = usuarios.Find(i => i.Codigo == codigo);
                foreach (UsuarioModel item in results)
                {
                    retorno.Add(item);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Metodo para Consulta de Todos Usuarios 
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public List<UsuarioModel> ConsultarUsuarios()
        {
            var retorno = new List<UsuarioModel>();

            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                // Get customer collection
                var usuarios = db.GetCollection<UsuarioModel>("usuarios");
                var results = usuarios.FindAll();
                foreach (UsuarioModel item in results)
                {
                    retorno.Add(item);
                }
            }

            return retorno;
        }
    }
}
