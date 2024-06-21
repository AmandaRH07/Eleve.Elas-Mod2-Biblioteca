namespace Biblioteca.Domain.Entities
{
	public class MembroBiblioteca
	{
		private int Id { get; set; }
		public string Nome { get; set; }

		internal void PegarEmprestado() { }
		protected void InformacoesDetalhadas() { }
	}
}
