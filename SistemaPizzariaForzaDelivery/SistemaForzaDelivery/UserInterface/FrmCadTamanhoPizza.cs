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
    public partial class FrmCadTamanhoPizza : Form
    {
        public Boolean IsNovo;
        public FrmCadTamanhoPizza()
        {
            InitializeComponent();
            MascaraCampoCodigo.AplicarEventos(TxtCodigo);
            MascaraDinheiro.AplicarEventos(TxtPreco);
        }

        private void FrmCadTamanhoPizza_Load(object sender, EventArgs e)
        {
            BtnCancelar_Click(BtnCancelar, new EventArgs());
        }

        private void BtnBscCodigo_Click(object sender, EventArgs e)
        {
            var ngTamanhoPizza = new TamanhoPizzaNG();
            var lista = ngTamanhoPizza.ListarEntidades(TipoSituacao.Todos);
            if (lista.Count < 1)
            {
                Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.ErroSemDadosParaExibir, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var frmPesquisaGenerica = new FrmPesquisaGenerica("Listagem de Tamahos de Pizza");
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
            var ngTamanhoPizza = new TamanhoPizzaNG();
            var oTamanhoPizza = ngTamanhoPizza.Buscar(Convert.ToInt32(TxtCodigo.Text.Trim()));
            if (oTamanhoPizza == null)
            {
                BtnExcluir.Enabled = false;
                return;
            }
            IsNovo = false;
            TxtTitulo.Text = oTamanhoPizza.Titulo;
            TxtObservacao.Text = String.Empty + oTamanhoPizza.Observacao;
            TxtPreco.Text = oTamanhoPizza.Preco.ToString();
            CmbQtdSabores.SelectedIndex = oTamanhoPizza.QtdSabores - 1;
            MascaraDinheiro.RetornarMascara(TxtPreco, new EventArgs());
            oUcSituacao.InicializarSituacao(oTamanhoPizza.TipoSituacao);
            BtnExcluir.Enabled = true;
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text.Trim() == String.Empty)
            {
                Funcoes.ExibirMessageBoxButtonOk(TipoMensagem.ErroTituloNaoPreenchido, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(CmbQtdSabores.SelectedIndex == -1)
            {
                MessageBox.Show("Informe a quantidade de sabores da pizza", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ngTamanhoPizza = new TamanhoPizzaNG();
            var oTamanhoPizza = new TamanhoPizza();
            oTamanhoPizza.Titulo = TxtTitulo.Text.Trim();
            if (TxtObservacao.Text.Trim() != String.Empty) oTamanhoPizza.Observacao = TxtObservacao.Text.Trim();
            oTamanhoPizza.TipoSituacao = oUcSituacao.tipoSituacao;
            MascaraDinheiro.TirarMascara(TxtPreco, new EventArgs());
            oTamanhoPizza.Preco = Convert.ToDecimal(TxtPreco.Text.Trim());
            MascaraDinheiro.RetornarMascara(TxtPreco, new EventArgs());
            oTamanhoPizza.QtdSabores = CmbQtdSabores.SelectedIndex + 1;
            if (IsNovo)
            {
                oTamanhoPizza.UsrInsercao = Sessao.Usuario;
                if (ngTamanhoPizza.Inserir(oTamanhoPizza))
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
                oTamanhoPizza.UsrAlteracao = Sessao.Usuario;
                oTamanhoPizza.Codigo = Convert.ToInt32(TxtCodigo.Text.Trim());
                if (ngTamanhoPizza.Alterar(oTamanhoPizza))
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
            var ngTamanhoPizza = new TamanhoPizzaNG();
            if (ngTamanhoPizza.Excluir(Convert.ToInt32(TxtCodigo.Text.Trim()), Sessao.Usuario.Codigo))
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
            var ngTamanhoPizza = new TamanhoPizzaNG();
            TxtCodigo.Text = ngTamanhoPizza.BuscarProxCodigo().ToString();
            TxtTitulo.Text = String.Empty;
            TxtObservacao.Text = String.Empty;
            BtnExcluir.Enabled = false;
            oUcSituacao.InicializarSituacao(TipoSituacao.Ativo);
            TxtPreco.Text = "0";
            MascaraDinheiro.RetornarMascara(TxtPreco, new EventArgs());
            CmbQtdSabores.SelectedIndex = -1;
            IsNovo = true;
            Funcoes.SelecionarCampo(TxtTitulo);
        }
    }
}