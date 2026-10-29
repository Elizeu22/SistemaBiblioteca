using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Pessoa
    {
        private int Id {  set;  get; }


        private string Nome { set; get; } = "";

        private string Email { set; get; } = "";

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
