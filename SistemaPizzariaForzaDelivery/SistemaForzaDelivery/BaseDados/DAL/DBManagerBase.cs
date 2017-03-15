using System;
using System.Data;
using System.Data.Common;
using Entidades.InfraestruturaBD;

namespace BaseDados.DAL
{
	public abstract class DBManagerBase 
	{

		protected DatabaseHelper databaseHelper = null;
		protected DbDataReader dbDataReader = null;
		protected DataSet dataSet = null;
		protected ProviderType providerType;
		protected String connectionString = String.Empty;
		protected bool isOpen = false;
		public DatabaseConnectionState databaseConnectionState = DatabaseConnectionState.CloseOnExit;


		public bool IsOpen
		{

			get
			{
				return isOpen;

			}

			set
			{

				isOpen = value;

			}

		}

		public string ConnectionString
		{
			get
			{
				return connectionString;
			}

			set
			{
				connectionString = value;
			}

		}

		public DbConnection Connection
		{
			get
			{

				return databaseHelper.Connection;
			}
		}

		public DbCommand Command
		{
			get
			{

				return databaseHelper.Command;
			}

		}

		public ProviderType DBProvider
		{
			set
			{
				providerType = value;
			}

			get
			{
				return providerType;
			}

		}

		public DataSet DBSet
		{
			get
			{
				return dataSet;
			}

		}

		public DbDataReader DBReader
		{
			get
			{
				return dbDataReader;
			}

		}

		public void Open(string connectionString)
		{
			databaseHelper = new DatabaseHelper(connectionString, DBProvider);

		}

		public void Close()
		{
			if (dbDataReader != null)
				if (!dbDataReader.IsClosed)
					dbDataReader.Close();
			databaseHelper.Dispose();
		}

		public void BeginTransaction()
		{
			databaseConnectionState = DatabaseConnectionState.KeepOpen;
			databaseHelper.BeginTransaction();
		}

		public void CommitTransaction()
		{

			databaseHelper.CommitTransaction();
			databaseConnectionState = DatabaseConnectionState.CloseOnExit;
		}

		public void RollbackTransaction()
		{

			databaseHelper.RollbackTransaction();
			databaseConnectionState = DatabaseConnectionState.CloseOnExit;
			
		}


		public bool IsTransaction()
		{
			return databaseHelper.Command.Transaction !=null;
			 
		}
	}
}
