using System;
using BaseDados.DAL;
using Entidades;
using System.Data;

namespace BaseDados
{
    public class PandaRockstarBD : BaseBD
    {
        public bool Inserir(PandaRockstar obj)
        {
            string query =
                @"  INSERT INTO
                        Pandas
                        (codigo, nome, fator_pelos, modelo_guitarra, toca_muito) 
                    VALUES 
                        (@codigo, @nome, @fator_pelos, @modelo_guitarra, @toca_muito)";

            try
            {
                oDbManager.OpenConnection();

                oDbManager.AddParameter("@codigo", obj.Codigo);
                oDbManager.AddParameter("@nome", obj.Nome);
                oDbManager.AddParameter("@fator_pelos", obj.FatorDePelos);
                oDbManager.AddParameter("@modelo_guitarra", obj.ModeloGuitarra);
                oDbManager.AddParameter("@toca_muito", obj.TocaMuito);

                //if ExecuteNonQuery() > 0 retorna true, se nao, retorna false TENDEU ALLAO?
                return oDbManager.ExecuteNonQuery(query, CommandType.Text) > 0;
            }
            finally
            {
                oDbManager.CloseConnection();
            }
        }

        public PandaRockstar Buscar(int codigo)
        {
            //o obj deve ser incializado como null, se nao encontrar o obj, vai ter q retornar null
            PandaRockstar obj = null;

            string query =
                @"  SELECT
                        *
                    FROM
                        Pandas
                    WHERE
                        codigo = @codigo;";

            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@codigo", codigo);
                oDbManager.ExecuteReader(query);

                while (oDbManager.DBReader.Read())
                {
                    //se encontrar o OBJ, entao inicializa ele
                    obj = new PandaRockstar();

                    obj.Codigo = Convert.ToInt32(oDbManager.DBReader["TipoPessoa"]);
                    obj.Nome = oDbManager.DBReader["nome"].ToString();
                    obj.FatorDePelos = Convert.ToDouble(oDbManager.DBReader["fator_pelos"]);
                    obj.ModeloGuitarra = oDbManager.DBReader["modelo_guitarra"].ToString();
                    obj.TocaMuito = Convert.ToBoolean(oDbManager.DBReader["toca_muito"]);
                }
            }
            finally
            {
                oDbManager.CloseConnection();
            }

            return obj;
        }
    }
}
