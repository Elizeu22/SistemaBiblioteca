using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public abstract class Pessoa
    {
        public int Id {  get;private set; } = 0;


        public string Nome { get; private set; } = "";

        public string Email { get;private set; } = "";

        public Pessoa(string nome,string email)
        {
            Nome = nome;   
            Email = email; 
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
