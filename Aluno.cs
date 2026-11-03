using System;
using System.Collections.Generic;


namespace Biblioteca
{
    public class Aluno: Pessoa
    {
        public string Matricula { get;private set; } = "";
        public DateTime DataCadastro { get; set; }

        public Aluno(string nome,string email,string matricula) :base(nome, email)
        {
            Matricula = matricula;
        }


        /// FALTA IMPLEMENTAR A FUNÇÃO PEGARLIVROS()
    }
}
