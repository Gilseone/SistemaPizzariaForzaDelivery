using System;
using System.Data;
using System.Data.Common;

namespace Entidades.InfraestruturaBD
{
	public interface  IDBManager
	{

		bool IsOpen { get; set; }

		string ConnectionString { get; set; }

		DbConnection Connection { get; }

		DbCommand Command { get; }

		ProviderType DBProvider { get; set; }

		DataSet DBSet { get; }

		DbDataReader DBReader { get; }

		void Open(string connectionString);

		void Close();

		void BeginTransaction();

		void CommitTransaction();

		void RollbackTransaction();

		void OpenConnection();

		/// <summary>
		/// Abre uma conexao para estados CloseOnExit ou se ainda nao foi aberta
		/// </summary>
		/// <param name="connectionString"></param>
		void OpenConnection(String connectionString);

		/// <summary>
		/// Fecha conexao para estados CloseOnExit ou se ainda nao foi aberta
		/// </summary>
		void CloseConnection();

		int AddParameter(string name, object value);

		int AddParameter(string name, StoredProcedureParameterDirection parameterDirection);

		int AddParameter(string name, object value, StoredProcedureParameterDirection parameterDirection);

		int AddParameter(string name, StoredProcedureParameterDirection parameterDirection, int size, DbType dbType);

		int AddParameter(string name, object value, StoredProcedureParameterDirection parameterDirection, int size, DbType dbType);

		object GetParameter(string name);

		// <summary>
		/// Executa o CommandText contra o Connection e cria um IDataReader.
		/// </summary>
		/// <param name="query">Comando sql</param>
		/// <returns>objeto DbDataReader</returns>
		DbDataReader ExecuteReader(string query);

		DbDataReader ExecuteReader(string query, CommandType commandtype);

		DbDataReader ExecuteReader(string query, CommandType commandtype, DatabaseConnectionState connectionstate);

		DbDataReader ExecuteReader(string query, DatabaseConnectionState connectionstate);

		object ExecuteScalar(string query);

		object ExecuteScalar(string query, CommandType commandtype);

		object ExecuteScalar(string query, DatabaseConnectionState connectionstate);

		object ExecuteScalar(string query, CommandType commandtype, DatabaseConnectionState connectionstate);

		DataSet ExecuteDataSet(string query);

		DataSet ExecuteDataSet(string query, CommandType commandtype);

		int ExecuteNonQuery(string query, CommandType commandtype);

		int ExecuteNonQuery(string query, CommandType commandtype, DatabaseConnectionState databaseConnectionState);

		long LastInsertedId();
	}
}