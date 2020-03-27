using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutorizationWebApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public Usuario Get(string Login, string Senha)
        {
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Models.Usuario(){Id=1, Login ="Daniel@email.com", Nome="Daniel", Senha="Daniel", Role="Usuario"},
                new Models.Usuario(){Id=2, Login ="Antonio@email.com", Nome="Antonio", Senha="Antonio", Role="Supervisor"},
                new Models.Usuario(){Id=3, Login ="Maria@email.com", Nome="Maria", Senha="Maria", Role="ADM"}
            };
            return usuarios.Find(x => x.Login == Login && x.Senha == Senha);
        }
    }
}
