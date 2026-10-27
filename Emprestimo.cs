using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Emprestimo
    {
        private int Id {  get; set; }
        private DateTime DataEmprestimo { get; set; }   
        private DateTime DataDevolucaoPrevista { get; set; }
        private DateTime DataDevolucaoReal {  get; set; }

        private string Status {  get; set; }

        public Emprestimo(int id, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista, DateTime dataDevolucaoReal, string status)
        {
            this.Id = id;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucaoPrevista = dataDevolucaoPrevista;
            this.DataDevolucaoReal = dataDevolucaoReal;
            this.Status = status;
        }

        public void RegistrarDevolucao()
        {
            Console.WriteLine($"Livro ID:{Id}");
            Console.WriteLine($"Data emprestimo:{DataEmprestimo}");
            Console.WriteLine($"Data devolucao:{DataDevolucaoReal}");
            Console.WriteLine($"Status:{Status}");
        }


        public void Cancelar()
        {
            Console.WriteLine("Emprestimo cancelado");
        }

        public Decimal CalcularMulta()
        {
            TimeSpan date = DataDevolucaoReal.Subtract(DataDevolucaoPrevista);
            int dias = date.Days;

            return dias * 1;

        }
    }
}
