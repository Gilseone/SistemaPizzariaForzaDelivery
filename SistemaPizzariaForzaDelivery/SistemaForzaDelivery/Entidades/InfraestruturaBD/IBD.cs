namespace Entidades.InfraestruturaBD

{
	public interface IBD<T> where T : class
	{
		bool Alterar(T obj);
		T Buscar(int cod);

		int BuscarProxCodigo();

		int BuscarProxCodigoHst();

		bool Excluir(int cod);

		bool Inserir(T obj);

		bool InserirHst(T obj, int cod);
	}
}