using Entidades.Tipos;
using System.Windows.Forms;

namespace UserInterface.UserControls
{
    public partial class ucSituacao : UserControl
    {
        public TipoSituacao tipoSituacao;
        public ucSituacao()
        {
            InitializeComponent();
        }

        private void ucSituacao_Load(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            InicializarSituacao(TipoSituacao.Ativo);
        }

        public void InicializarSituacao(TipoSituacao tSituacao)
        {
            if (DesignMode) return;
            tipoSituacao = tSituacao;
            if (tipoSituacao == TipoSituacao.Ativo) OptAtivo.Checked = true;
            else OptInativo.Checked = true;
        }

        private void OptAtivo_CheckedChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            if (OptAtivo.Checked) tipoSituacao = TipoSituacao.Ativo;
        }

        private void OptInativo_CheckedChanged(object sender, System.EventArgs e)
        {
            if (DesignMode) return;
            if (OptInativo.Checked) tipoSituacao = TipoSituacao.Inativo;
        }
    }
}
