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
    public class ProdutosController : ApiController
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        // GET: api/Produtos
        public IEnumerable<dynamic> Get()
        {
            var produtos = from produto in bd.produto
                           select new { produto.id, produto.nome, produto.preco };
            return produtos;
        }

        // GET: api/Produtos/5
        public produto Get(int id)
        {
            var produtos = bd.produto.Find(id);
            return produtos;
        }

        // POST: api/Produtos
        public produto Post([FromBody]produto produto)
        {
            bd.produto.Add(produto);
            bd.SaveChanges();
            return produto;
        }

        // PUT: api/Produtos/5
        public produto Put(int id, [FromBody]produto produto)
        {
            var old = bd.produto.Find(id);
            old.nome = produto.nome;
            old.preco = produto.preco;
            bd.SaveChanges();
            return old;
        }

        // DELETE: api/Produtos/5
        public void Delete(int id)
        {
        }
    }
}
