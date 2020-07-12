using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace EmpresaAPI.Controllers
{
    public class MesasController : ApiController
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        // GET: api/Mesas
        public IEnumerable<dynamic> Get()
        {
            var mesas = from mesa in bd.mesa
                          select new { mesa.id, mesa.capacidade, mesa.disponivel };
            return mesas;
        }

        // GET: api/Mesas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mesas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mesas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mesas/5
        public void Delete(int id)
        {
        }
    }
}
