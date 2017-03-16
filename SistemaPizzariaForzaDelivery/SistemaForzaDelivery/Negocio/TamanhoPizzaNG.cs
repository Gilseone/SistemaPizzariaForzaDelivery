using BaseDados;
using BaseDados.DAL;
using Entidades;
using Entidades.Entidades;
using Entidades.InfraestruturaBD;
using Entidades.Sistema;
using Entidades.Tipos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class TamanhoPizzaNG
    {
        private readonly TamanhoPizzaBD _bd;

        public TamanhoPizzaNG()
        {
            _bd = new TamanhoPizzaBD();
        }

        public bool Inserir(TamanhoPizza obj)
        {
            return _bd.Inserir(obj);
        }

        public TamanhoPizza Buscar(int iCodigo)
        {
            return _bd.Buscar(iCodigo);
        }

        public long BuscarProxCodigo()
        {
            return _bd.BuscarProxCodigo();
        }

        public List<EntidadeViewPesquisa> ListarEntidades(TipoSituacao situacao)
        {
            return _bd.ListarEntidades(situacao);
        }

        public bool Alterar(TamanhoPizza obj)
        {
            IDBManager oDbManager = new DBManager(ConfiguracaoBanco.DbConnectionString);
            var strErro = String.Empty;
            var bFlag = true;
            var bdTamanhoPizzaTrans = new TamanhoPizzaBD(oDbManager);
            try
            {
                oDbManager.BeginTransaction();
                var objOld = bdTamanhoPizzaTrans.Buscar(obj.Codigo);
                strErro = "Erro ao gravar o registro no histórico de alterações. Tente novamente!";
                if (!bdTamanhoPizzaTrans.InserirHst(objOld, obj.UsrAlteracao.Codigo))
                {
                    oDbManager.RollbackTransaction();
                    return false;
                }
                strErro = "Erro ao atualizar o registro. Tente novamente!";
                if (!bdTamanhoPizzaTrans.Alterar(obj))
                {
                    oDbManager.RollbackTransaction();
                    return false;
                }
                oDbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                bFlag = false;
                oDbManager.RollbackTransaction();
                throw new Exception(strErro + ex.Message);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return bFlag;
        }

        public bool Excluir(int Codigo, int iCodUsuario)
        {
            IDBManager oDbManager = new DBManager(ConfiguracaoBanco.DbConnectionString);
            var strErro = String.Empty;
            var bFlag = true;
            var bdTamanhoPizzaTrans = new TamanhoPizzaBD(oDbManager);
            try
            {
                oDbManager.BeginTransaction();
                var objOld = bdTamanhoPizzaTrans.Buscar(Codigo);
                strErro = "Erro ao gravar o registro no histórico de alterações. Tente novamente!";
                objOld.IsEhExclusao = true;
                if (!bdTamanhoPizzaTrans.InserirHst(objOld, iCodUsuario))
                {
                    oDbManager.RollbackTransaction();
                    return false;
                }
                strErro = "Erro ao excluir o registro. Tente novamente!";
                if (!bdTamanhoPizzaTrans.Excluir(Codigo))
                {
                    oDbManager.RollbackTransaction();
                    return false;
                }
                oDbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                bFlag = false;
                oDbManager.RollbackTransaction();
                throw new Exception(strErro + ex.Message);
            }
            finally
            {
                oDbManager.CloseConnection();
            }
            return bFlag;
        }
    }
}