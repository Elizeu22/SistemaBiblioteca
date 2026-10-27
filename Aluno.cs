using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Aluno: Pessoa
    {
        private string Matricula { get; set; } = "";
        private DateTime DataCadastro { get; set; }

        public Aluno(string nome,string email,string matricula) :base(nome, email)
        {
            Matricula = matricula;
        }


        /// FALTA IMPLEMENTAR A FUNÇÃO PEGARLIVROS()
    }
}
