namespace UserInterface.Pesquisas
{
    partial class FrmPesquisaGenerica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.GpbSituacao = new System.Windows.Forms.GroupBox();
            this.OptSomenteInativos = new System.Windows.Forms.RadioButton();
            this.OptSomenteAtivos = new System.Windows.Forms.RadioButton();
            this.OptTodos = new System.Windows.Forms.RadioButton();
            this.GpbListagemDados = new System.Windows.Forms.GroupBox();
            this.LvlListagem = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1.SuspendLayout();
            this.GpbSituacao.SuspendLayout();
            this.GpbListagemDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnSair);
            this.flowLayoutPanel1.Controls.Add(this.BtnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(245, 473);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(297, 48);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // BtnSair
            // 
            this.BtnSair.Image = global::UserInterface.Properties.Resources.sair;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSair.Location = new System.Drawing.Point(192, 0);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(105, 45);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Image = global::UserInterface.Properties.Resources.confirmar;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConfirmar.Location = new System.Drawing.Point(87, 0);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(105, 45);
            this.BtnConfirmar.TabIndex = 0;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(12, 13);
            this.TxtBusca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(533, 22);
            this.TxtBusca.TabIndex = 19;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            // 
            // GpbSituacao
            // 
            this.GpbSituacao.Controls.Add(this.OptSomenteInativos);
            this.GpbSituacao.Controls.Add(this.OptSomenteAtivos);
            this.GpbSituacao.Controls.Add(this.OptTodos);
            this.GpbSituacao.Location = new System.Drawing.Point(12, 42);
            this.GpbSituacao.Name = "GpbSituacao";
            this.GpbSituacao.Size = new System.Drawing.Size(533, 65);
            this.GpbSituacao.TabIndex = 20;
            this.GpbSituacao.TabStop = false;
            this.GpbSituacao.Text = "Situação";
            // 
            // OptSomenteInativos
            // 
            this.OptSomenteInativos.AutoSize = true;
            this.OptSomenteInativos.Location = new System.Drawing.Point(287, 30);
            this.OptSomenteInativos.Name = "OptSomenteInativos";
            this.OptSomenteInativos.Size = new System.Drawing.Size(137, 21);
            this.OptSomenteInativos.TabIndex = 5;
            this.OptSomenteInativos.Text = "Somente Inativos";
            this.OptSomenteInativos.UseVisualStyleBackColor = true;
            this.OptSomenteInativos.CheckedChanged += new System.EventHandler(this.OptSomenteInativos_CheckedChanged);
            // 
            // OptSomenteAtivos
            // 
            this.OptSomenteAtivos.AutoSize = true;
            this.OptSomenteAtivos.Location = new System.Drawing.Point(139, 30);
            this.OptSomenteAtivos.Name = "OptSomenteAtivos";
            this.OptSomenteAtivos.Size = new System.Drawing.Size(127, 21);
            this.OptSomenteAtivos.TabIndex = 4;
            this.OptSomenteAtivos.Text = "Somente Ativos";
            this.OptSomenteAtivos.UseVisualStyleBackColor = true;
            this.OptSomenteAtivos.CheckedChanged += new System.EventHandler(this.OptSomenteAtivos_CheckedChanged);
            // 
            // OptTodos
            // 
            this.OptTodos.AutoSize = true;
            this.OptTodos.Checked = true;
            this.OptTodos.Location = new System.Drawing.Point(54, 30);
            this.OptTodos.Name = "OptTodos";
            this.OptTodos.Size = new System.Drawing.Size(69, 21);
            this.OptTodos.TabIndex = 3;
            this.OptTodos.TabStop = true;
            this.OptTodos.Text = "Todos";
            this.OptTodos.UseVisualStyleBackColor = true;
            this.OptTodos.CheckedChanged += new System.EventHandler(this.OptTodos_CheckedChanged);
            // 
            // GpbListagemDados
            // 
            this.GpbListagemDados.Controls.Add(this.LvlListagem);
            this.GpbListagemDados.Location = new System.Drawing.Point(12, 113);
            this.GpbListagemDados.Name = "GpbListagemDados";
            this.GpbListagemDados.Size = new System.Drawing.Size(533, 353);
            this.GpbListagemDados.TabIndex = 21;
            this.GpbListagemDados.TabStop = false;
            this.GpbListagemDados.Text = "Listagem de Dados";
            // 
            // LvlListagem
            // 
            this.LvlListagem.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LvlListagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvlListagem.FullRowSelect = true;
            this.LvlListagem.GridLines = true;
            this.LvlListagem.Location = new System.Drawing.Point(3, 18);
            this.LvlListagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LvlListagem.Name = "LvlListagem";
            this.LvlListagem.Size = new System.Drawing.Size(527, 332);
            this.LvlListagem.TabIndex = 12;
            this.LvlListagem.UseCompatibleStateImageBehavior = false;
            this.LvlListagem.DoubleClick += new System.EventHandler(this.LvlListagem_DoubleClick);
            // 
            // FrmPesquisaGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 521);
            this.Controls.Add(this.GpbListagemDados);
            this.Controls.Add(this.GpbSituacao);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPesquisaGenerica";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.FrmPesquisaGenerica_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.GpbSituacao.ResumeLayout(false);
            this.GpbSituacao.PerformLayout();
            this.GpbListagemDados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.GroupBox GpbSituacao;
        private System.Windows.Forms.RadioButton OptSomenteInativos;
        private System.Windows.Forms.RadioButton OptSomenteAtivos;
        private System.Windows.Forms.RadioButton OptTodos;
        private System.Windows.Forms.GroupBox GpbListagemDados;
        private System.Windows.Forms.ListView LvlListagem;
    }
}