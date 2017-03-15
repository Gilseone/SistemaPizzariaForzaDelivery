namespace Entidades.InfraestruturaBD
{
	public interface IBDL<T> where T : class
	{
		bool Alterar(T obj);

		T Buscar(long cod);

        T Buscar(long x, long y);

		long BuscarProxCodigo();

		long BuscarProxCodigoHst();

		bool Excluir(long cod);

		bool Inserir(T obj);
		bool InserirHst(T obj, long cod);
	}
}