using Biblioteca.Domain.Entities;

var livro = new Livros();
var codigoISBN = livro.CodigoISBN;

var membroBiblioteca = new MembroBiblioteca();
var pegarEmprestado = membroBiblioteca.PegarEmprestado;

var admin = new Admin();
var administrar = admin.GerenciarBiblioteca;