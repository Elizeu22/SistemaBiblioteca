using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Reserva
    {
        public int IdReserva {  get;private set; }        

        public DateTime DataReserva { get;private set; }

        public string Status {  get;private set; }

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
