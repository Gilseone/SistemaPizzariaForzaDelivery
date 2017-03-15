using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using Entidades.InfraestruturaBD;

namespace BaseDados.DAL
{
    public abstract class BaseBD
    {
        protected IDBManager oDbManager { get; set; }

        protected DbDataReader dbReader { get; set; }

        public BaseBD(IDBManager oDbManager)
        {
            this.oDbManager = oDbManager;
        }

        public BaseBD()
        {
            this.oDbManager = new DBManager(ConfiguracaoBanco.DbConnectionString);
        }

        public BaseBD(string connectionString)
        {
            this.oDbManager = new DBManager(connectionString);
        }
    }
}
