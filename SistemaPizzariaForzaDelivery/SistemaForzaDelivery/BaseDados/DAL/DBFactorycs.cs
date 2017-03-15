using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using Entidades.InfraestruturaBD;
using MySql.Data.MySqlClient;


namespace BaseDados.DAL
{
	public class DBFactory
	{
		private static DbProviderFactory objFactory = null;

		public static DbProviderFactory GetProvider(ProviderType provider)
		{

			switch (provider)
			{
				case ProviderType.MySql:
					objFactory = MySqlClientFactory.Instance;
					break;

				case ProviderType.SqlServer:
					objFactory = SqlClientFactory.Instance;
					break;

				case ProviderType.OleDb:
					objFactory = OleDbFactory.Instance;
					break;

				case ProviderType.Oracle:
					//objFactory = OracleClientFactory.Instance;
					break;

				case ProviderType.ODBC:
					objFactory = OdbcFactory.Instance;
					break;

				default:
					objFactory = MySqlClientFactory.Instance;
					break;
			}

			return objFactory;

		}

		public static DbDataAdapter GetDataAdapter(ProviderType providerType)
		{

			switch (providerType)
			{

				case ProviderType.MySql:
					return new MySqlDataAdapter();

				case ProviderType.SqlServer:
					return new SqlDataAdapter();

				case ProviderType.OleDb:
					return new OleDbDataAdapter();

				case ProviderType.ODBC:
					return new OdbcDataAdapter();

				case ProviderType.Oracle:
				//return new OracleDataAdapter();

				default:

					return null;

			}

		}

	}

}

