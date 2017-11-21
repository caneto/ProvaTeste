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
    /// Construtor para Cliente
    /// </summary>
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        /// <summary>
        /// Metodo para Cadastro de Clientes
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [AcceptVerbs("POST")]
        [Route("CadastrarCliente")]
        public HttpResponseMessage CadastrarCliente(ClienteModel cliente)
        {
            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                var clientes = db.GetCollection<ClienteModel>("clientes");

                clientes.Insert(cliente);

            }

            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        /// <summary>
        /// Metodo para Alteracao do Cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [AcceptVerbs("PUT")]
        [Route("AlterarCliente")]
        public HttpResponseMessage AlterarCliente(ClienteModel cliente)
        {

            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                var clientes = db.GetCollection<ClienteModel>("clientes");

                clientes.Update(cliente);

            }

            return new HttpResponseMessage(HttpStatusCode.OK);

        }

        /// <summary>
        /// Metodo de Exclusão do Cliente
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [AcceptVerbs("DELETE")]
        [Route("ExcluirCliente/{codigo}")]
        public HttpResponseMessage ExcluirCliente(int codigo)
        {
            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                var clientes = db.GetCollection<ClienteModel>("clientes");
                clientes.Delete(i => i.Id == codigo);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Metodo para Consulta de Cliente por Codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("ConsultarClientePorCodigo/{codigo}")]
        public List<ClienteModel> ConsultarClientePorCodigo(int codigo)
        {

            var retorno = new List<ClienteModel>();

            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                // Get customer collection
                var clientes = db.GetCollection<ClienteModel>("clientes");
                var results = clientes.Find(i => i.Codigo == codigo);
                foreach (ClienteModel item in results)
                {
                    retorno.Add(item);
                }
            }

            return retorno;
        }

        /// <summary>
        /// Metodo para Consultar Todos os Registros do Cliente
        /// </summary>
        /// <returns></returns>
        [AcceptVerbs("GET")]
        [Route("ConsultarClientes")]
        public List<ClienteModel> ConsultarClientes()
        {
            var retorno = new List<ClienteModel>();

            using (var db = new LiteDatabase(@"c:\Temp\MyData.db"))
            {
                // Get customer collection
                var clientes = db.GetCollection<ClienteModel>("clientes");
                var results = clientes.FindAll();
                foreach (ClienteModel item in results)
                {
                    retorno.Add(item);
                }
            }

            return retorno;
        }
    }
}
