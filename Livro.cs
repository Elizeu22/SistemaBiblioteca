using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        private int Id {  get; set; }

        private string Titulo { get; set; } = "";

        private string Autor { get; set; } = "";

        private int AnoPublicacao { get; set; }

        private string Isbn { get; set; } = "";

        private bool Status { get; set; } = true;

        public Livro(string titulo,string autor,int anoPublicacao,string isbn,bool status)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Isbn = isbn;
            Status = status;    
        }


        public override string ToString()
        {
            return $"{Titulo}-{Autor}-{AnoPublicacao}-{Isbn}";
        }

        public Bibliotecario Bibliotecario { get; set; }

        public Emprestimo Emprestimo { get; set; }


        public void MarcarComoEmprestado()
        {
            Status = false; 
        }

        public void MarcarComoDevolvido()
        {
            Status = true;
        }

    }
}
