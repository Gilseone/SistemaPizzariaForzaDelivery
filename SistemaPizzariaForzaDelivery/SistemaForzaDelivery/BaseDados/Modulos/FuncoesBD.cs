using BaseDados.DAL;
using Entidades.InfraestruturaBD;
using System;

namespace BaseDados.Modulos
{
    public class FuncoesBD : BaseBD
    {
        public FuncoesBD(IDBManager oDBManager)
            : base(oDBManager)
        {
        }

        public FuncoesBD()
        {
        }

        public string BuscarHoraAtualString()
        {
            var str = "00:00:00";
            const string query = "Select Time(Now()) As Hora";
            try
            {
                oDbManager.OpenConnection();
                oDbManager.ExecuteReader(query);
                if (oDbManager.DBReader.Read()) str = oDbManager.DBReader["Hora"].ToString();
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return str;
        }

        public TimeSpan BuscarHoraAtual()
        {
            var ts = TimeSpan.Parse(BuscarHoraAtualString());
            return ts;
        }

        public int BuscaCodigo(string strSQL)
        {
            var iCodigo = 1;
            try
            {
                oDbManager.OpenConnection();
                oDbManager.ExecuteReader(strSQL);
                while (oDbManager.DBReader.Read())
                {
                    iCodigo = Convert.ToInt32(oDbManager.DBReader["Auto_Increment"]);
                }
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return iCodigo;
        }

        public new DateTime BuscarDataAtual()
        {
            var dDtAtual = new DateTime();
            try
            {
                oDbManager.OpenConnection();
                oDbManager.ExecuteReader("SELECT NOW()");

                if (oDbManager.DBReader.Read()) dDtAtual = Convert.ToDateTime(oDbManager.DBReader[0]);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return dDtAtual;
        }
    }
}
