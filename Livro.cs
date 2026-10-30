using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public int Id {  get; private set; }

        public string Titulo { get;private set; } = "";

        public string Autor { get;private set; } = "";

        public int AnoPublicacao { get;private set; }

        public string Isbn { get;private set; } = "";

        public bool Disponivel { get;private set; } = false;

        public Bibliotecario BibliotecarioLivro { get; set; }

        public Emprestimo EmprestimoLivro { get; set; }

        public Livro(string titulo,string autor,int anoPublicacao,string isbn,
            bool disponivel,Emprestimo emprestimo, Bibliotecario biblioteca)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Isbn = isbn;
            Disponivel = disponivel; 
            EmprestimoLivro = emprestimo;
            BibliotecarioLivro = biblioteca;
        }


        public override string ToString()
        {
            return $"{Titulo}-{Autor}-{AnoPublicacao}-{Isbn}";
        }


        public bool MarcarComoEmprestado()
        {
           if(Disponivel == false)
            {
                Console.WriteLine("Livro indisponivel");
            }
            else
            {
                Disponivel = true;
            }

           return Disponivel;
        }

        public bool MarcarComoDevolvido()
        {
            if(Disponivel == true)
            {
                Disponivel=false;
            }

            return false;
        }

    }
}
