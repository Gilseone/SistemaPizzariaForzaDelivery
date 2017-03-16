using BaseDados.DAL;
using BaseDados.Modulos;
using Entidades;
using Entidades.Entidades;
using Entidades.InfraestruturaBD;
using Entidades.Tipos;
using System;
using System.Collections.Generic;
using System.Data;

namespace BaseDados
{
    public class SaborPizzaBD : BaseBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();
        public SaborPizzaBD()
        {
        }

        public SaborPizzaBD(IDBManager oDBManager)
            : base(oDBManager)
        {
        }

        public bool Alterar(SaborPizza obj)
        {
            var r = 0;
            const string query = @"UPDATE sabores_pizza
                                    SET titulo = @titulo,
	                                    observacao = @observacao,
	                                    situacao = @situacao,
                                        preco_adicional = @preco_adicional
                                    WHERE
	                                    (codigo = @codigo)";
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@codigo", obj.Codigo);
                oDbManager.AddParameter("@titulo", obj.Titulo);
                oDbManager.AddParameter("@observacao", obj.Observacao);
                oDbManager.AddParameter("@preco_adicional", obj.PrecoAdicional);
                oDbManager.AddParameter("@situacao", (int)obj.TipoSituacao);
                r = oDbManager.ExecuteNonQuery(query, CommandType.Text);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return r > 0;
        }

        public SaborPizza Buscar(int cod)
        {
            const string query = @"SELECT
	                                    *
                                    FROM
	                                    sabores_pizza
                                    WHERE
	                                    codigo = @codigo";
            SaborPizza obj = null;
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@codigo", cod);
                oDbManager.ExecuteReader(query);
                while (oDbManager.DBReader.Read())
                {
                    obj = new SaborPizza();
                    obj.Codigo = Convert.ToInt32(oDbManager.DBReader["codigo"]);
                    obj.Titulo = oDbManager.DBReader["titulo"].ToString();
                    if (oDbManager.DBReader["observacao"] != DBNull.Value) obj.Observacao = oDbManager.DBReader["observacao"].ToString();
                    obj.TipoSituacao = (TipoSituacao)Convert.ToInt32(oDbManager.DBReader["situacao"]);
                    obj.PrecoAdicional = Convert.ToDecimal(oDbManager.DBReader["preco_adicional"]);
                    obj.DtInsercao = Convert.ToDateTime(oDbManager.DBReader["dt_insercao"]);
                    obj.UsrInsercao.Codigo = Convert.ToInt32(oDbManager.DBReader["usr_insercao"]);
                }
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return obj;
        }

        public List<EntidadeViewPesquisa> ListarEntidades(TipoSituacao situacao)
        {
            var list = new List<EntidadeViewPesquisa>();
            var query = @"SELECT
	                                    codigo,
							            titulo,
							            situacao
                                    FROM
	                                    sabores_pizza";
            if (situacao != TipoSituacao.Todos) query += " WHERE situacao = @situacao";
            try
            {
                oDbManager.OpenConnection();
                if (situacao != TipoSituacao.Todos) oDbManager.AddParameter("@situacao", (Int32)situacao);
                oDbManager.ExecuteReader(query);

                while (oDbManager.DBReader.Read())
                {
                    var obj = new EntidadeViewPesquisa
                    {
                        Codigo = Convert.ToInt32(oDbManager.DBReader["codigo"]),
                        Titulo = oDbManager.DBReader["titulo"].ToString(),
                        TipoSituacao = (TipoSituacao)Convert.ToInt32(oDbManager.DBReader["situacao"])
                    };
                    list.Add(obj);
                }
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return list;
        }

        public int BuscarProxCodigo()
        {
            return bdFuncoes.BuscaCodigo(@"SHOW TABLE STATUS LIKE 'sabores_pizza'");
        }

        public bool Excluir(int cod)
        {
            var r = 0;
            const string query = @"DELETE
                                    FROM
	                                    sabores_pizza
                                    WHERE
	                                    (codigo = @codigo)";
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@codigo", cod);
                r = oDbManager.ExecuteNonQuery(query, CommandType.Text);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return r > 0;
        }

        public bool Inserir(SaborPizza obj)
        {
            var r = 0;
            const string query = @"INSERT INTO sabores_pizza (
	                                    titulo,
	                                    observacao,
	                                    situacao,
                                        preco_adicional,
	                                    dt_insercao,
	                                    usr_insercao
                                    )
                                    VALUES
	                                    (
		                                    @titulo,
		                                    @observacao,
		                                    @situacao,
                                            @preco_adicional,
		                                    NOW(),
		                                    @usr_insercao
	                                    )";
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@titulo", obj.Titulo);
                oDbManager.AddParameter("@observacao", obj.Observacao);
                oDbManager.AddParameter("@situacao", (int)obj.TipoSituacao);
                oDbManager.AddParameter("@preco_adicional", obj.PrecoAdicional);
                oDbManager.AddParameter("@usr_insercao", obj.UsrInsercao.Codigo);
                r = oDbManager.ExecuteNonQuery(query, CommandType.Text);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return r > 0;
        }

        public bool InserirHst(SaborPizza obj, int iCodUsuario)
        {
            var r = 0;
            var dDtAtual = new FuncoesBD().BuscarDataAtual();
            const string query = @"INSERT INTO sabores_pizza_Hst (
	                                    codigo_sabor_pizza,
	                                    titulo,
	                                    observacao,
                                        situacao,
                                        preco_adicional,
	                                    dt_insercao,
	                                    usr_insercao,
	                                    dt_alteracao,
	                                    usr_alteracao,
	                                    dt_exclusao,
	                                    usr_exclusao
                                    )
                                    VALUES
	                                    (
		                                    @codigo_sabor_pizza,
		                                    @titulo,
		                                    @observacao,
                                            @situacao,
                                            @preco_adicional,
		                                    @dt_insercao,
		                                    @usr_insercao,
		                                    @dt_alteracao,
		                                    @usr_alteracao,
		                                    @dt_exclusao,
		                                    @usr_exclusao
	                                    )";
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@codigo_sabor_pizza", obj.Codigo);
                oDbManager.AddParameter("@titulo", obj.Titulo);
                oDbManager.AddParameter("@observacao", obj.Observacao);
                oDbManager.AddParameter("@situacao", (int)obj.TipoSituacao);
                oDbManager.AddParameter("@preco_adicional", obj.PrecoAdicional);
                oDbManager.AddParameter("@dt_insercao", obj.DtInsercao);
                oDbManager.AddParameter("@usr_insercao", obj.UsrInsercao.Codigo);
                if (obj.IsEhExclusao)
                {
                    oDbManager.AddParameter("@dt_alteracao", null);
                    oDbManager.AddParameter("@usr_alteracao", null);
                    oDbManager.AddParameter("@dt_exclusao", dDtAtual);
                    oDbManager.AddParameter("@usr_exclusao", iCodUsuario);
                }
                else
                {
                    oDbManager.AddParameter("@dt_alteracao", dDtAtual);
                    oDbManager.AddParameter("@usr_alteracao", iCodUsuario);
                    oDbManager.AddParameter("@dt_exclusao", null);
                    oDbManager.AddParameter("@usr_exclusao", null);
                }
                r = oDbManager.ExecuteNonQuery(query, CommandType.Text);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return r > 0;
        }
    }
}
