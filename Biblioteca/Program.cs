using Biblioteca.Domain.Entities;

var livro = new Livros();
var titulo = livro.Titulo;
var obterResumo = livro.ObterResumo;

var membro = new MembroBiblioteca();
var nome = membro.Nome;

var funcionario = new Funcionario();
var addNovoFuncionario = funcionario.NovoFuncionario;