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
    public class SaborPizzaNG
    {
        private readonly SaborPizzaBD _bd;

        public SaborPizzaNG()
        {
            _bd = new SaborPizzaBD();
        }

        public bool Inserir(SaborPizza obj)
        {
            return _bd.Inserir(obj);
        }

        public SaborPizza Buscar(int iCodigo)
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

        public bool Alterar(SaborPizza obj)
        {
            IDBManager oDbManager = new DBManager(ConfiguracaoBanco.DbConnectionString);
            var strErro = String.Empty;
            var bFlag = true;
            var bdSaborPizzaTrans = new SaborPizzaBD(oDbManager);
            try
            {
                oDbManager.BeginTransaction();
                var objOld = bdSaborPizzaTrans.Buscar(obj.Codigo);
                strErro = "Erro ao gravar o registro no histórico de alterações. Tente novamente!";
                if (!bdSaborPizzaTrans.InserirHst(objOld, obj.UsrAlteracao.Codigo))
                {
                    oDbManager.RollbackTransaction();
                    return false;
                }
                strErro = "Erro ao atualizar o registro. Tente novamente!";
                if (!bdSaborPizzaTrans.Alterar(obj))
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
            var bdSaborPizzaTrans = new SaborPizzaBD(oDbManager);
            try
            {
                oDbManager.BeginTransaction();
                var objOld = bdSaborPizzaTrans.Buscar(Codigo);
                strErro = "Erro ao gravar o registro no histórico de alterações. Tente novamente!";
                objOld.IsEhExclusao = true;
                if (!bdSaborPizzaTrans.InserirHst(objOld, iCodUsuario))
                {
                    oDbManager.RollbackTransaction();
                    return false;
                }
                strErro = "Erro ao excluir o registro. Tente novamente!";
                if (!bdSaborPizzaTrans.Excluir(Codigo))
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