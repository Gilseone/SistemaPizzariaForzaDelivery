using System.Configuration;

namespace BaseDados.DAL
{
    public static class ConfiguracaoBanco
    {
        private static string dbConnectionString;
        //private static string dbProviderName = "MySql.Data.MySqlClient";


        static ConfiguracaoBanco()
        {
            string strServer = ConfigurationManager.AppSettings["servidor"];
            string strBD = ConfigurationManager.AppSettings["banco"];
            string strSenha = ConfigurationManager.AppSettings["senhaBanco"];

            dbConnectionString = @"Server=" + strServer + ";User ID=root;PWD=" + strSenha + "; Persist Security Info=True;Respect Binary Flags=False;default command timeout=2000;Database=" + strBD;
        }

        /// <summary>
        /// String de conexao do banco principal
        /// </summary>
        public static string DbConnectionString
        {
            get { return dbConnectionString; }
        }

        //public static string DbProviderName
        //{
        //    get { return dbProviderName; }
        //}
    }
}
