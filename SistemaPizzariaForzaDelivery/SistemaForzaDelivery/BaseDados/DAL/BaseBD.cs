using System.Data.Common;
using Entidades.InfraestruturaBD;
using Entidades.Sistema;

namespace BaseDados.DAL
{
    public abstract class BaseBD
    {
        protected Sessao Sessao { get; set; }
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

        public BaseBD(Sessao sessao)
        {
            this.oDbManager = new DBManager(ConfiguracaoBanco.DbConnectionString);
            this.Sessao = sessao;
        }

        public BaseBD(string connectionString)
        {
            this.oDbManager = new DBManager(connectionString);
        }
    }
}
