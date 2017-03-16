using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface.Pesquisas
{
    public partial class FrmPesquisaGenerica : Form
    {
        public List<EntidadeViewPesquisa> lista = new List<EntidadeViewPesquisa>();
        public int iRetorno = 0;

        public FrmPesquisaGenerica(String strTitulo)
        {
            InitializeComponent();
            this.Text = strTitulo;
        }        

        private void FrmPesquisaGenerica_Load(object sender, EventArgs e)
        {
            var form = new Form()
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true,
                Top = 0,
                Left = 0
            };
            LimpaCampos();
            PreencheLista(lista);
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public void LimpaCampos()
        {
            TxtBusca.Text = String.Empty;
            iRetorno = 0;
        }

        private void PreencheLista(List<EntidadeViewPesquisa> list)
        {
            LvlListagem.Clear();
            LvlListagem.View = View.Details;
            LvlListagem.Columns.Add("#", 0, HorizontalAlignment.Right);
            LvlListagem.Columns.Add("Título", 280, HorizontalAlignment.Left);
            LvlListagem.Columns.Add("Código", 80, HorizontalAlignment.Right);

            foreach (var obj in list)
            {
                if (!OptTodos.Checked)
                {
                    if (OptSomenteAtivos.Checked && obj.TipoSituacao != Entidades.Tipos.TipoSituacao.Ativo) continue;
                    else if (OptSomenteInativos.Checked && obj.TipoSituacao != Entidades.Tipos.TipoSituacao.Inativo) continue;
                }
                var Linha = new string[3];
                Linha[0] = obj.Codigo.ToString();
                Linha[1] = obj.Titulo;
                Linha[2] = obj.Codigo.ToString();
                var itmx = new ListViewItem(Linha);
                LvlListagem.Items.Add(itmx);
            }
        }

        private void LvlListagem_DoubleClick(object sender, EventArgs e)
        {
            BtnConfirmar_Click(BtnConfirmar, new EventArgs());
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (LvlListagem.SelectedIndices.Count <= 0)
            {
                return;
            }
            var intselectedindex = Convert.ToInt32(LvlListagem.SelectedIndices[0]);
            if (intselectedindex >= 0)
            {
                iRetorno = Convert.ToInt32(LvlListagem.Items[intselectedindex].Text);
                BtnSair_Click(BtnSair, new EventArgs());
            }
            else return;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            if (TxtBusca.Text.Trim().Equals(String.Empty))
            {
                PreencheLista(lista);
                return;
            }
            List<EntidadeViewPesquisa> listResult = new List<EntidadeViewPesquisa>(from p in lista where p.Titulo.ToLower().Contains(TxtBusca.Text.Trim().ToLower()) select p);
            PreencheLista(listResult);
        }

        private void OptTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (!OptTodos.Checked) return;
            LimpaCampos();
            PreencheLista(lista);
        }

        private void OptSomenteAtivos_CheckedChanged(object sender, EventArgs e)
        {
            if (!OptSomenteAtivos.Checked) return;
            LimpaCampos();
            PreencheLista(lista);
        }

        private void OptSomenteInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (!OptSomenteInativos.Checked) return;
            LimpaCampos();
            PreencheLista(lista);
        }
    }
}
