using System;
using System.Collections.Generic;


namespace Biblioteca
{
    public class BibliotecaApp
    {
        public string Nome {  get; private set; }
        public string Endereco { get;private set; }

        public string Telefone { get;private set; }

        public List<Emprestimo> EmprestimoLivros { get; private set; }

        public List<Livro> Livros { get; private set; }

        public BibliotecaApp(string nome,string endereco,string telefone)
        {
            this.Nome = nome;    
            this.Endereco = endereco;
            this.Telefone = telefone;
            EmprestimoLivros = new List<Emprestimo>();
            Livros = new List<Livro>();

        }

   

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void RemoverLivro(int livro)
        {
            Livro? livroRemover = Livros.FirstOrDefault(l => l.Id == livro);

            if(livroRemover != null)
            {
                Livros.Remove(livroRemover);
            }
            else
            {
                Console.WriteLine("Livro nao localizado.");
            }
        }


        public Livro? BuscarLivro(int livroId)
        {
           return Livros.FirstOrDefault(l => l.Id == livroId);

         
        }


        public List<Livro> ListarLivros()
        {
            return Livros.ToList();
        }
    }
}
