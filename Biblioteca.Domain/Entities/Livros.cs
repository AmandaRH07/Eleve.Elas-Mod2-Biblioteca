namespace Biblioteca.Domain.Entities
{
	public class Livros
	{
		public string Titulo { get; set; }
		private string Autor { get; set; }
		internal string CodigoISBN { get; set; }

		public Livros()
		{
		}

		public void ObterResumo() { }
	}
}
