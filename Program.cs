
using Biblioteca;


Aluno aluno = new Aluno("teste", "teste@gmail.com", "12");
Livro livro = new Livro("teste", "Auro", 2024, "32425");
Emprestimo emprestimo = new Emprestimo(12,
    new DateTime(2025,04,20),
    new DateTime(2025, 04, 25),
    new DateTime(2025, 05, 05), 
      "Devolvido");

BibliotecaApp bibliotecaApp = new BibliotecaApp("Apostive","Rua Alvarenga","11-5845-5589");


Reserva reserva = new Reserva(new DateTime(2025, 04, 20),"livre", aluno,livro);

Console.WriteLine($"Data reserva: {reserva.DataReserva}");
Console.WriteLine($"Status reserva: {reserva.Status}");
Console.WriteLine($"Aluno reserva: {aluno}");
Console.WriteLine($"Livro reserva: {livro}");


Console.WriteLine("--------------------------------------------------------------------------");


Bibliotecario bibliotecario = new Bibliotecario("Alves","alves@hotmail.com","548787");

Console.WriteLine($"Bibliotecario: {bibliotecario.Nome}");
Console.WriteLine($"Email: {bibliotecario.Email}");
Console.WriteLine($"Credencial: {bibliotecario.Credencial}");



Console.WriteLine("--------------------------------------------------------------------------");




Console.WriteLine($"Biblioteca: {bibliotecaApp.Nome}");
Console.WriteLine($"Endereço biblioteca: {bibliotecaApp.Endereco}");
Console.WriteLine($"Telefone biblioteca: {bibliotecaApp.Telefone}");


Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine($"Nome do aluno: {aluno.Nome}");
Console.WriteLine($"Email: {aluno.Email}");
Console.WriteLine($"Matricula: {aluno.Matricula}");

Console.WriteLine("--------------------------------------------------------------------------");

Console.WriteLine($"Data emprestimo: {emprestimo.DataEmprestimo}");
Console.WriteLine($"Data devolução prevista: {emprestimo.DataDevolucaoPrevista}");
Console.WriteLine($"Data devolução: {emprestimo.DataDevolucaoReal}");

