namespace Entidades.InfraestruturaBD
{
	public class ListItem : IEntidade
	{
		public int Codigo { get; set; }

		public string Descricao { get; set; }

		public override string ToString()
		{
			return this.Descricao;
		}
	}
}
