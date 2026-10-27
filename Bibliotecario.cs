using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bibliotecario:Pessoa
    {
        private string Credencial { get; set; } = "";

        public Bibliotecario(string nome,string email,string credencial) : base(nome, email)
        {
            Credencial = credencial;
        }

        List<Reserva> reservaLivros = new List<Reserva>();




        // FALTA IMPLEMENTAR CADASTRAR LIVRO

        // FALTA IMPLEMENTAR REMOVER LIVRO
    }
}
