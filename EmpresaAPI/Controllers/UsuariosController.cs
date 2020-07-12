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
    public class UsuariosController : ApiController
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        // GET: api/Usuarios
        public IEnumerable<dynamic> Get()
        {
            var usuario = from user in bd.usuario
                          select new { user.id, user.login, user.senha, user.admin };

            return usuario;
        }

        // GET: api/Usuarios/5
        public usuario Get(int id)
        {
            var usuario = bd.usuario.Find(id);
            return usuario;
        }

        // POST: api/Usuarios
        public usuario Post([FromBody]usuario login)
        {
            bd.usuario.Add(login);
            bd.SaveChanges();
            return login;
        }

        // PUT: api/Usuarios/5
        public usuario Put(int id, [FromBody]usuario login)
        {
            var old = bd.usuario.Find(id);
            old.login = login.login;
            old.senha = login.senha;
            old.admin = login.admin;
            bd.SaveChanges();
            return old;
        }

        // DELETE: api/Usuarios/5
        public usuario Delete(string login)
        {
            var old = bd.usuario.Find(login);
            bd.usuario.Remove(old);
            bd.SaveChanges();
            return old;
        }
    }
}
