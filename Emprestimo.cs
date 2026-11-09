using System;
using System.Collections.Generic;


namespace Biblioteca
{
    public class Emprestimo
    {
        public int Id {  get;private set; }
        public DateTime DataEmprestimo { get;private set; }   
        public DateTime DataDevolucaoPrevista { get;private set; }
        public DateTime DataDevolucaoReal {  get;private set; }

        public string Status {  get;private set; }

        public List<Reserva> ReservaLivro { get; private set; }

        public Emprestimo(int id, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista, DateTime dataDevolucaoReal, string status)
        {
            this.Id = id;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucaoPrevista = dataDevolucaoPrevista;
            this.DataDevolucaoReal = dataDevolucaoReal;
            this.Status = status;
            ReservaLivro = new List<Reserva>();
        }

        public void RegistrarDevolucao()
        {
            Console.WriteLine($"Livro ID:{Id}");
            Console.WriteLine($"Data emprestimo:{DataEmprestimo}");
            Console.WriteLine($"Data devolucao:{DataDevolucaoReal}");
            Console.WriteLine($"Status:{Status}");
        }


        public Decimal CalcularMulta()
        {
            TimeSpan date = DataDevolucaoReal.Subtract(DataDevolucaoPrevista);
            int dias = date.Days;

            return dias * 1;

        }

        public override string ToString()
        {
            return $"{DataEmprestimo}-{DataDevolucaoReal}-{DataDevolucaoReal}-{Status}";
        }
    }
}
