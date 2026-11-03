using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Bibliotecario:Pessoa
    {
        public string Credencial { get;private set; } = "";

        public Bibliotecario(string nome,string email,string credencial) : base(nome, email)
        {
            Credencial = credencial;
        }

        List<Reserva> reservaLivros = new List<Reserva>();




        // FALTA IMPLEMENTAR CADASTRAR LIVRO

        // FALTA IMPLEMENTAR REMOVER LIVRO
    }
}
