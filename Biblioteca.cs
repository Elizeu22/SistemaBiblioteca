using System;
using System.Collections.Generic;


namespace Biblioteca
{
    public class Biblioteca
    {
        public string Nome {  get; private set; }
        public string Endereco { get;private set; }

        public string Telefone { get;private set; }

        public List<Emprestimo> EmprestimoLivros { get; private set; }

        public List<Livro> Livros { get; private set; }

        public Biblioteca(string nome,string endereco,string telefone)
        {
            this.Nome = nome;    
            this.Endereco = endereco;
            this.Telefone = telefone;
            EmprestimoLivros = new List<Emprestimo>();
            Livros = new List<Livro>();

        }

   

        public void AdicionarLivro(string addLivro)
        {

            var list = new List<Livro>();

            foreach (var livro in list)
            {
                list.Add(livro);
            }

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


        public void BuscarLivro(int livroId)
        {
            Livro? livroBuscar = Livros.FirstOrDefault(l => l.Id == livroId);

            if (livroBuscar != null)
            {
                Livros.FirstOrDefault(livroBuscar);

                foreach(var livro in Livros)
                {
                    Console.WriteLine(livro);
                }
            }
            else
            {
                Console.WriteLine("Livro nao localizado");
            }
        }


        public List<Livro> ListarLivros(int livroId)
        {
            // FUNÇAO PARA BUSCAR LIVROS BASE DE DADOS 
            var list = new List<Livro>();

            foreach (var livro in list)
            {
                Console.WriteLine(livro);
            }

            return list;
        }
    }
}
