using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoApp
{
    class Usuario
    {
        public string login { get; set; }
        public string senha { get; set; }

        public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        public Usuario()
        {
        }
    }
}
