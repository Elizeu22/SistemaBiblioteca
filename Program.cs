
using Biblioteca;


Aluno aluno = new Aluno("teste", "teste@gmail.com", "12");
Livro livro = new Livro("teste", "Auro", 2024, "32425");
Emprestimo emprestimo = new Emprestimo(12,
    new DateTime(2025,04,25),
    new DateTime(2025, 05, 25),
    new DateTime(2025, 05, 05), 
      "Devolvido");

BibliotecaApp bibliotecaApp = new BibliotecaApp("Apostive","Rua Alvarenga","11-5845-5589");

Console.WriteLine($"Biblioteca: {bibliotecaApp.Nome}");
Console.WriteLine($"Endereço biblioteca: {bibliotecaApp.Endereco}");
Console.WriteLine($"Telefone biblioteca: {bibliotecaApp.Telefone}");


Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Email);
Console.WriteLine(aluno.Matricula);

Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine($"Data emprestimo: {emprestimo.DataEmprestimo}");
Console.WriteLine($"Data devolução prevista: {emprestimo.DataDevolucaoPrevista}");
Console.WriteLine($"Data devolução: {emprestimo.DataDevolucaoReal}");

