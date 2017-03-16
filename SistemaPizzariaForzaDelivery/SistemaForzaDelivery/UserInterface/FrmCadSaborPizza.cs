using Entidades;
using Entidades.Sistema;
using Entidades.Tipos;
using Negocio;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using UserInterface.Modulos;
using UserInterface.Pesquisas;

namespace UserInterface
{
    public partial class FrmCadSaborPizza : Form
    {
        public Boolean IsNovo;
        public FrmCadSaborPizza()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(TxtCodigo);
            MascaraDinheiro.AplicarEventos(TxtPrecoAdicional);
        }

        private void FrmCadSaborPizza_Load(object sender, EventArgs e)
        {
            BtnCancelar_Click(BtnCancelar, new EventArgs());
        }

        private void BtnBscCodigo_Click(object sender, EventArgs e)
        {
            var ngSaborPizza = new SaborPizzaNG();
            var lista = ngSaborPizza.ListarEntidades(TipoSituacao.Todos);
            if (lista.Count < 1)
            {
                Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.ErroSemDadosParaExibir, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var frmPesquisaGenerica = new FrmPesquisaGenerica("Listagem de Sabores de Pizza");
            frmPesquisaGenerica.lista = lista;
            frmPesquisaGenerica.ShowDialog();
            var iRetorno = frmPesquisaGenerica.iRetorno;
            if (iRetorno < 1) return;
            TxtCodigo.Text = iRetorno.ToString();
            TxtCodigo_Validating(TxtCodigo, new CancelEventArgs(false));
            BtnBscCodigo.Focus();
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigo.Text.Trim() == String.Empty) return;
            var ngSaborPizza = new SaborPizzaNG();
            var oSaborPizza = ngSaborPizza.Buscar(Convert.ToInt32(TxtCodigo.Text.Trim()));
            if (oSaborPizza == null)
            {
                BtnExcluir.Enabled = false;
                return;
            }
            IsNovo = false;
            TxtTitulo.Text = oSaborPizza.Titulo;
            TxtObservacao.Text = String.Empty + oSaborPizza.Observacao;
            TxtPrecoAdicional.Text = oSaborPizza.PrecoAdicional.ToString();
            MascaraDinheiro.RetornarMascara(TxtPrecoAdicional, new EventArgs());
            oUcSituacao.InicializarSituacao(oSaborPizza.TipoSituacao);
            BtnExcluir.Enabled = true;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text.Trim() == String.Empty)
            {
                Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.ErroTituloNaoPreenchido, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ngSaborPizza = new SaborPizzaNG();
            var oSaborPizza = new SaborPizza();
            oSaborPizza.Titulo = TxtTitulo.Text.Trim();
            if (TxtObservacao.Text.Trim() != String.Empty) oSaborPizza.Observacao = TxtObservacao.Text.Trim();
            oSaborPizza.TipoSituacao = oUcSituacao.tipoSituacao;
            MascaraDinheiro.TirarMascara(TxtPrecoAdicional, new EventArgs());
            oSaborPizza.PrecoAdicional = Convert.ToDecimal(TxtPrecoAdicional.Text.Trim());
            MascaraDinheiro.RetornarMascara(TxtPrecoAdicional, new EventArgs());
            if (IsNovo)
            {
                oSaborPizza.UsrInsercao = Sessao.Usuario;
                if (ngSaborPizza.Inserir(oSaborPizza))
                {
                    Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.SucessoRegistroCadastrado, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                }
                else
                {
                    Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.ErroRegistroNaoCadastrado, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                oSaborPizza.UsrAlteracao = Sessao.Usuario;
                oSaborPizza.Codigo = Convert.ToInt32(TxtCodigo.Text.Trim());
                if (ngSaborPizza.Alterar(oSaborPizza))
                {
                    Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.SucessoRegistroAlterado, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                }
                else
                {
                    Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.ErroRegistroNaoAlterado, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text.Trim() == String.Empty) return;
            var ngSaborPizza = new SaborPizzaNG();
            if (ngSaborPizza.Excluir(Convert.ToInt32(TxtCodigo.Text.Trim()), Sessao.Usuario.Codigo))
            {
                Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.SucessoRegistroExcluido, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCampos();
            }
            else
            {
                Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.ErroRegistroExcluido, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {

        }

        public void LimpaCampos()
        {
            var ngSaborPizza = new SaborPizzaNG();
            TxtCodigo.Text = ngSaborPizza.BuscarProxCodigo().ToString();
            TxtTitulo.Text = String.Empty;
            TxtObservacao.Text = String.Empty;
            BtnExcluir.Enabled = false;
            oUcSituacao.InicializarSituacao(TipoSituacao.Ativo);
            TxtPrecoAdicional.Text = "0";
            MascaraDinheiro.RetornarMascara(TxtPrecoAdicional, new EventArgs());
            IsNovo = true;
            Funcoes.SelecionarCampo(TxtTitulo);
        }
    }
}