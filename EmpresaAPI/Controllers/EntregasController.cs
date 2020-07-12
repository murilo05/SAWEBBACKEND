using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EmpresaAPI.Models;

namespace EmpresaAPI.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class EntregasController : ApiController
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        // GET: api/Entregas
        public IEnumerable<dynamic> Get()
        {
            var entregas = from entrega in bd.delivery
                           select new { entrega.id, entrega.Telefone, entrega.Nome, entrega.Logradouro, entrega.Número, entrega.Bairro , entrega.Complemento, entrega.entregador, entrega.finalizada };
            return entregas;
        }

        // GET: api/Entregas/5
        public delivery Get(int id)
        {
            var entrega = bd.delivery.Find(id);
            return entrega;
        }

        // POST: api/Entregas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Entregas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Entregas/5
        public void Delete(int id)
        {
        }
    }
}
