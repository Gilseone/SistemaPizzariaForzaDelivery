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
    public class TamanhoPizzaBD : BaseBD
    {
        private readonly FuncoesBD bdFuncoes = new FuncoesBD();
        public TamanhoPizzaBD()
        {
        }

        public TamanhoPizzaBD(IDBManager oDBManager)
            : base(oDBManager)
        {
        }

        public bool Alterar(TamanhoPizza obj)
        {
            var r = 0;
            const string query = @"UPDATE tamanhos_pizza
                                    SET titulo = @titulo,
	                                    observacao = @observacao,
	                                    situacao = @situacao,
                                        preco = @preco,
                                        qtd_sabores = @qtd_sabores
                                    WHERE
	                                    (codigo = @codigo)";
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@codigo", obj.Codigo);
                oDbManager.AddParameter("@titulo", obj.Titulo);
                oDbManager.AddParameter("@observacao", obj.Observacao);
                oDbManager.AddParameter("@preco", obj.Preco);
                oDbManager.AddParameter("@qtd_sabores", obj.QtdSabores);
                oDbManager.AddParameter("@situacao", (int)obj.TipoSituacao);
                r = oDbManager.ExecuteNonQuery(query, CommandType.Text);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return r > 0;
        }

        public TamanhoPizza Buscar(int cod)
        {
            const string query = @"SELECT
	                                    *
                                    FROM
	                                    tamanhos_pizza
                                    WHERE
	                                    codigo = @codigo";
            TamanhoPizza obj = null;
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@codigo", cod);
                oDbManager.ExecuteReader(query);
                while (oDbManager.DBReader.Read())
                {
                    obj = new TamanhoPizza();
                    obj.Codigo = Convert.ToInt32(oDbManager.DBReader["codigo"]);
                    obj.Titulo = oDbManager.DBReader["titulo"].ToString();
                    if (oDbManager.DBReader["observacao"] != DBNull.Value) obj.Observacao = oDbManager.DBReader["observacao"].ToString();
                    obj.TipoSituacao = (TipoSituacao)Convert.ToInt32(oDbManager.DBReader["situacao"]);
                    obj.Preco = Convert.ToDecimal(oDbManager.DBReader["preco"]);
                    obj.QtdSabores = Convert.ToInt16(oDbManager.DBReader["qtd_sabores"]);
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
	                                    tamanhos_pizza";
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
            return bdFuncoes.BuscaCodigo(@"SHOW TABLE STATUS LIKE 'tamanhos_pizza'");
        }

        public bool Excluir(int cod)
        {
            var r = 0;
            const string query = @"DELETE
                                    FROM
	                                    tamanhos_pizza
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

        public bool Inserir(TamanhoPizza obj)
        {
            var r = 0;
            const string query = @"INSERT INTO tamanhos_pizza (
	                                    titulo,
	                                    observacao,
	                                    situacao,
                                        preco,
                                        qtd_sabores,
	                                    dt_insercao,
	                                    usr_insercao
                                    )
                                    VALUES
	                                    (
		                                    @titulo,
		                                    @observacao,
		                                    @situacao,
                                            @preco,
                                            @qtd_sabores,
		                                    NOW(),
		                                    @usr_insercao
	                                    )";
            try
            {
                oDbManager.OpenConnection();
                oDbManager.AddParameter("@titulo", obj.Titulo);
                oDbManager.AddParameter("@observacao", obj.Observacao);
                oDbManager.AddParameter("@situacao", (int)obj.TipoSituacao);
                oDbManager.AddParameter("@preco", obj.Preco);
                oDbManager.AddParameter("@qtd_sabores", obj.QtdSabores);
                oDbManager.AddParameter("@usr_insercao", obj.UsrInsercao.Codigo);
                r = oDbManager.ExecuteNonQuery(query, CommandType.Text);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return r > 0;
        }

        public bool InserirHst(TamanhoPizza obj, int iCodUsuario)
        {
            var r = 0;
            var dDtAtual = new FuncoesBD().BuscarDataAtual();
            const string query = @"INSERT INTO tamanhos_pizza_Hst (
	                                    codigo_tamanho_pizza,
	                                    titulo,
	                                    observacao,
                                        situacao,
                                        preco,
                                        qtd_sabores,
	                                    dt_insercao,
	                                    usr_insercao,
	                                    dt_alteracao,
	                                    usr_alteracao,
	                                    dt_exclusao,
	                                    usr_exclusao
                                    )
                                    VALUES
	                                    (
		                                    @codigo_tamanho_pizza,
		                                    @titulo,
		                                    @observacao,
                                            @situacao,
                                            @preco,
                                            @qtd_sabores,
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
                oDbManager.AddParameter("@codigo_tamanho_pizza", obj.Codigo);
                oDbManager.AddParameter("@titulo", obj.Titulo);
                oDbManager.AddParameter("@observacao", obj.Observacao);
                oDbManager.AddParameter("@situacao", (int)obj.TipoSituacao);
                oDbManager.AddParameter("@preco", obj.Preco);
                oDbManager.AddParameter("@qtd_sabores", obj.QtdSabores);
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