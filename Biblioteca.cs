using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        private string Nome {  get; set; }
        private string Endereco { get; set; }

        private string Telefone { get; set; }

        public Biblioteca(string nome,string endereco,string telefone)
        {
            this.Nome = nome;    
            this.Endereco = endereco;
            this.Telefone = telefone;

        }

        public Emprestimo Emprestimo { get; set; }

        public void AdicionarLivro(Livro livro)
        {
            // FUNÇAO PARA CADASTRAR NA BASE DE DADOS 
         
        }

        public void RemoverLivro(int livroId)
        {
            // FUNÇAO PARA RETIRAR DA BASE DE DADOS 
        }


        public void BuscarLivro(int livroId)
        {
            // FUNÇAO PARA BUSCAR DA BASE DE DADOS 
        }


        public List<Livro> ListarLivros(int livroId)
        {
            // FUNÇAO PARA BUSCAR LIVROS BASE DE DADOS 
            var list = new List<Livro>();   

            return list;
        }
    }
}
