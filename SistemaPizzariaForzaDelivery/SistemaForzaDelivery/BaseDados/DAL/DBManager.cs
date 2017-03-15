using System;
using System.Data;
using System.Data.Common;
using Entidades.InfraestruturaBD;

namespace BaseDados.DAL
{

	public sealed class DBManager : DBManagerBase, IDBManager 
	{

		public DBManager(String connectionString)
		{
			this.connectionString = connectionString;
			base.Open(connectionString);
		}

		public DBManager(string connectionString, DatabaseConnectionState databaseConnectionState)
		{

			base.Open(connectionString);
			this.databaseConnectionState = databaseConnectionState;
		}


		public void OpenConnection()
		{
			//connectionString = ConfigurationManager.ConnectionStrings["stringConexaoProducao"].ConnectionString;
			//base.Open(this.connectionString);
			if (databaseConnectionState != DatabaseConnectionState.KeepOpen && !base.isOpen)
			{
				
                base.Open(connectionString);
				base.isOpen = true;
			}
		}

		/// <summary>
		/// Abre uma conexao para estados CloseOnExit ou se ainda nao foi aberta
		/// </summary>
		/// <param name="connectionString"></param>
		public void OpenConnection(String connectionString)
		{
			//base.Open(connectionString);
			if (databaseConnectionState != DatabaseConnectionState.KeepOpen && !base.isOpen)
			{
				base.Open(connectionString);
				base.isOpen = true;
			}

		}

        /// <summary>
		/// Fecha conexao para estados CloseOnExit ou se ainda nao foi aberta
		/// </summary>
		public void CloseConnection()
		{
			if (base.Connection != null)
			{
				if (base.DBReader != null)
					base.DBReader.Close();
				if (databaseConnectionState == DatabaseConnectionState.CloseOnExit)
				{
					if (base.isOpen)
						base.Close();
					base.IsOpen = false;
				}
			}

		}

		public int AddParameter(string name, object value)
		{
			return databaseHelper.AddParameter(name, value);
		}

        public int AddParameter(string name, StoredProcedureParameterDirection parameterDirection)
		{
			return databaseHelper.AddParameter(name, parameterDirection);

		}

		public int AddParameter(string name, object value, StoredProcedureParameterDirection parameterDirection)
		{
			return databaseHelper.AddParameter(name, value, parameterDirection);
		}

		public int AddParameter(string name, StoredProcedureParameterDirection parameterDirection, int size, DbType dbType)
		{
			return databaseHelper.AddParameter(name, parameterDirection, size, dbType);
		}

		public int AddParameter(string name, object value, StoredProcedureParameterDirection parameterDirection, int size, DbType dbType)
		{
			return databaseHelper.AddParameter(name, value, parameterDirection, size, dbType);
		}

		public object GetParameter(string name)
		{
			return databaseHelper.GetParameter(name);
		}

		// <summary>
		/// Executa o CommandText contra o Connection e cria um IDataReader. 
		/// </summary>
		/// <param name="query">Comando sql</param>
		/// <returns>objeto DbDataReader</returns>
		public DbDataReader ExecuteReader(string query)
		{
			this.dbDataReader = databaseHelper.ExecuteReader(query, databaseConnectionState);
			return this.dbDataReader;
		}

		public DbDataReader ExecuteReader(string query, CommandType commandtype)
		{
			this.dbDataReader = databaseHelper.ExecuteReader(query, commandtype, databaseConnectionState);
			return this.dbDataReader;
		}

		//public IDataReader ExecuteReader(string storedProcedureName, params object[] parameters)
		//{
		//	this.dbDataReader = (DbDataReader)databaseHelper.ExecuteReader(storedProcedureName, parameters);
		//	return this.dbDataReader;
		//}

		public DbDataReader ExecuteReader(string query, CommandType commandtype, DatabaseConnectionState connectionstate)
		{
			this.dbDataReader = databaseHelper.ExecuteReader(query, commandtype, connectionstate);
			return this.dbDataReader;
		}

		public DbDataReader ExecuteReader(string query, DatabaseConnectionState connectionstate)
		{
			this.dbDataReader = databaseHelper.ExecuteReader(query, connectionstate);
			return this.dbDataReader;
		}

		public object ExecuteScalar(string query)
		{
			return databaseHelper.ExecuteScalar(query);
		}

		public object ExecuteScalar(string query, CommandType commandtype)
		{
			return databaseHelper.ExecuteScalar(query, commandtype);
		}

		public object ExecuteScalar(string query, DatabaseConnectionState connectionstate)
		{
			return databaseHelper.ExecuteScalar(query, connectionstate);
		}

		public object ExecuteScalar(string query, CommandType commandtype, DatabaseConnectionState connectionstate)
		{
			return databaseHelper.ExecuteScalar(query, commandtype, connectionstate);
		}

		public DataSet ExecuteDataSet(string query)
		{
			this.dataSet = databaseHelper.ExecuteDataSet(query);
			return this.dataSet;
		}

		public DataSet ExecuteDataSet(string query, CommandType commandtype)
		{
			this.dataSet = databaseHelper.ExecuteDataSet(query, commandtype);
			return this.dataSet;
		}

		public int ExecuteNonQuery(string query, CommandType commandtype)
		{
			return databaseHelper.ExecuteNonQuery(query, commandtype, databaseConnectionState);
		}

		public int ExecuteNonQuery(string query, CommandType commandtype, DatabaseConnectionState databaseConnectionState)
		{
			return databaseHelper.ExecuteNonQuery(query, commandtype, databaseConnectionState);
		}

		public long LastInsertedId()
		{
			return databaseHelper.LastInsertedId(); 
		}
	}
}

