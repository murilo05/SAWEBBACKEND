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
    public class FuncionariosController : ApiController
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        // GET: api/Funcionarios
        public IEnumerable<dynamic> Get()
        {
            var funcionarios = from func in bd.funcionario
                           select new { func.nome, func.telefone, func.cpf, func.dataNascimento, func.rua, func.numero, func.bairro, func.uf, func.cidade, func.complemento, func.cargo };
            return funcionarios;
        }

        // GET: api/Funcionarios/5
        public funcionario Get(int telefone)
        {
            var func = bd.funcionario.Find(telefone);
            return func;
        }

        // POST: api/Funcionarios
        public funcionario Post([FromBody]funcionario funcionario)
        {
            bd.funcionario.Add(funcionario);
            bd.SaveChanges();
            return funcionario;
        }

        // PUT: api/Funcionarios/5
        public funcionario Put(int telefone, [FromBody]funcionario funcionario)
        {
            var old = bd.funcionario.Find(telefone);
            old.nome = funcionario.nome;
            old.telefone = funcionario.telefone;
            old.dataNascimento = funcionario.dataNascimento;
            old.rua = funcionario.rua;
            old.numero = funcionario.numero;
            old.bairro = funcionario.bairro;
            old.uf = funcionario.uf;
            old.cidade = funcionario.cidade;
            old.complemento = funcionario.cidade;
            old.cargo = funcionario.cargo;
            bd.SaveChanges();
            return old;
        }

        // DELETE: api/Funcionarios/5
        public void Delete(int id)
        {
        }
    }
}
