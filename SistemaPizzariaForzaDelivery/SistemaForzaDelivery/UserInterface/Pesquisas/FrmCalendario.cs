using System;
using System.Windows.Forms;

namespace UserInterface.Pesquisas
{
    public partial class FrmCalendario : Form
    {
        public DateTime DtSaida;
        public Boolean IsRetValido;

        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            IsRetValido = false;
            Close();
        }

        private void MCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            IsRetValido = true;
            DtSaida = MCalendar.SelectionStart;
            Close();
        }
    }
}
