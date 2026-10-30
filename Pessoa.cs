using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Pessoa
    {
        public int Id { private set; get; } = 0;


        public string Nome { set; private get; } = "";

        public string Email { set;private get; } = "";

        public Pessoa(string nome,string email)
        {
            this.Nome = nome;   
            this.Email = email; 
        }


        public string GetDados()
        {
            return $"Nome:{Nome}, Email:{Email}";
        }

        public override string ToString() 
        {
            return $"{Nome}-{Email}";
        }

    }
}
