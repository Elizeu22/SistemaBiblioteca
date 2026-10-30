using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Reserva
    {
        private int IdReserva {  get; set; }        
        private DateTime DataReserva { get; set; }
        private string Status {  get; set; }

        public Aluno Aluno { get; private set; }

        public Livro Livro { get; private set; }

        public Reserva(Aluno aluno, Livro livro)
        {
            this.Aluno = aluno;
            this.Livro = livro;
          
        }

        public void Cancelar() 
        {
            Console.WriteLine("Reserva cancelada");

        }

        public override string ToString()
        {
            return $"{Aluno}-{Livro}";
        }
    }
}
