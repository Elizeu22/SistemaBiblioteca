using System;
using System.Collections.Generic;


namespace Biblioteca
{
    public class Aluno: Pessoa
    {
        public string Matricula { get;private set; } = "";
        public DateTime DataCadastro { get;private set; }

        public Aluno(string nome,string email,string matricula) :base(nome, email)
        {
            Matricula = matricula;
        }

        public List<Emprestimo> Emprestar { get; private set; } 


        public void PegarLivro(Emprestimo emprestimo)
        {
            Emprestar.Add(emprestimo);
        }

    }
}
