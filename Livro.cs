using System;
using System.Collections.Generic;


namespace Biblioteca
{
    public class Livro
    {
        public int Id {  get; private set; }

        public string Titulo { get;private set; } = "";

        public string Autor { get;private set; } = "";

        public int AnoPublicacao { get;private set; }

        public string Isbn { get;private set; } = "";

        public bool Disponivel { get;private set; } = true;

        public Bibliotecario BibliotecarioLivro { get; set; }

        public List<Emprestimo> EmprestimoLivro { get;private set; }

    public Livro(string titulo,string autor,int anoPublicacao,string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            Isbn = isbn;
            EmprestimoLivro = new List<Emprestimo>();
        }


        public override string ToString()
        {
            return $"{Titulo}-{Autor}-{AnoPublicacao}-{Isbn}";
        }


        public bool MarcarComoEmprestado()
        {
            if (VerificarStatusLivro() == true)
            {
                Disponivel = false;
                return true;
            }
                return false;
            
               
           
        }

        public bool MarcarComoDevolvido()
        {
            if (VerificarStatusLivro() == false)
            {
                Disponivel = true;
                return true;
            }
                return false;
           
        }

        public bool VerificarStatusLivro()
        {
            if(Disponivel == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
