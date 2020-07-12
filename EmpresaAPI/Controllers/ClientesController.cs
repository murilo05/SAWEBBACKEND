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
    public class ClientesController : ApiController
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        // GET: api/Clientes
        public IEnumerable<dynamic> Get()
        {
            var clientes = from client in bd.cliente
                               select new { client.nome, client.telefone, client.cpf, client.dataNascimento, client.rua, client.numero, client.bairro, client.uf, client.cidade, client.complemento};
            return clientes;
        }

        // GET: api/Clientes/5
        public cliente Get(int telefone)
        {
            var client = bd.cliente.Find(telefone);
            return client;
        }

        // POST: api/Clientes
        public cliente Post([FromBody]cliente cliente)
        {
            bd.cliente.Add(cliente);
            bd.SaveChanges();
            return cliente;
        }

        // PUT: api/Clientes/5
        public cliente Put(int telefone, [FromBody]cliente cliente)
        {
            var old = bd.cliente.Find(telefone);
            old.nome = cliente.nome;
            old.telefone = cliente.telefone;
            old.dataNascimento = cliente.dataNascimento;
            old.rua = cliente.rua;
            old.numero = cliente.numero;
            old.bairro = cliente.bairro;
            old.uf = cliente.uf;
            old.cidade = cliente.cidade;
            old.complemento = cliente.cidade;
            bd.SaveChanges();
            return old;
        }

        // DELETE: api/Clientes/5
        public void Delete(int id)
        {
        }
    }
}
