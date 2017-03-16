namespace Entidades.InfraestruturaBD
{
	public class ListItem : IEntidade
	{
		public int Codigo { get; set; }

		public string Titulo { get; set; }

		public override string ToString()
		{
			return this.Titulo;
		}
	}
}
