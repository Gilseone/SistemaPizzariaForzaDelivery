using Entidades.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MDIFrm : Form
    {
        public MDIFrm()
        {
            InitializeComponent();
        }

        private void MDIFrm_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
            MnsPrincipal.Visible = false;
            //var frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
            //if (!frmLogin.bFlagLogin) Application.Exit();
            Sessao.Usuario = new Entidades.Entidades.Entidade(1, "Gilseone Moraes");
            MnsPrincipal.Visible = true;
        }

        private void AbrirFormularios(Form oFrm)
        {
            oFrm.WindowState = FormWindowState.Normal;
            oFrm.StartPosition = FormStartPosition.Manual;
            oFrm.MdiParent = this;
            oFrm.Top = 0;
            oFrm.Left = 0;
            oFrm.Show();
        }

        private void saboresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmCadSaborPizza());
        }

        private void tamanhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmCadTamanhoPizza());
        }
    }
}
