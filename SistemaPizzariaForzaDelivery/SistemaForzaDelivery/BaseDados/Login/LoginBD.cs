using System.Data;
using BaseDados.DAL;
using Entidades.Entidades;
using Entidades.InfraestruturaBD;

namespace BaseDados.Login
{
    public class LoginBD : BaseBD
    {
        public bool VerificarLoginValido(Usuario usr)
        {
            string query =
                @"  SELECT
                        *
                    FROM    
                        Usuarios
                    WHERE
                        login = @login
                        AND senha = @senha";

            try
            {
                oDbManager.OpenConnection();

                oDbManager.AddParameter("@login", usr.Login);
                oDbManager.AddParameter("@senha", usr.Senha);

                oDbManager.ExecuteReader(query, CommandType.Text);

                while (oDbManager.DBReader.Read())
                    return true;
            }
            finally
            {
                oDbManager.CloseConnection();
            }

            return false;
        }
    }
}
