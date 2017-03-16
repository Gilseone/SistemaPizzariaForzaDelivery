namespace UserInterface
{
    partial class FrmCadTamanhoPizza
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
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.LblObservacao = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.BtnBscCodigo = new System.Windows.Forms.Button();
            this.oUcSituacao = new UserInterface.UserControls.ucSituacao();
            this.LblQtdSabores = new System.Windows.Forms.Label();
            this.CmbQtdSabores = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtCodigo.Location = new System.Drawing.Point(10, 36);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(89, 22);
            this.TxtCodigo.TabIndex = 11;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigo_Validating);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnAjuda);
            this.flowLayoutPanel1.Controls.Add(this.BtnCancelar);
            this.flowLayoutPanel1.Controls.Add(this.BtnExcluir);
            this.flowLayoutPanel1.Controls.Add(this.BtnConfirmar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(156, 391);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(562, 48);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.Image = global::UserInterface.Properties.Resources.ajuda;
            this.BtnAjuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAjuda.Location = new System.Drawing.Point(457, 0);
            this.BtnAjuda.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(105, 45);
            this.BtnAjuda.TabIndex = 1;
            this.BtnAjuda.Text = "Ajuda";
            this.BtnAjuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAjuda.UseVisualStyleBackColor = true;
            this.BtnAjuda.Click += new System.EventHandler(this.BtnAjuda_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::UserInterface.Properties.Resources.cancelar;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(352, 0);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 45);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = global::UserInterface.Properties.Resources.excluir;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExcluir.Location = new System.Drawing.Point(247, 0);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(105, 45);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Image = global::UserInterface.Properties.Resources.confirmar;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConfirmar.Location = new System.Drawing.Point(142, 0);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(105, 45);
            this.BtnConfirmar.TabIndex = 0;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // LblObservacao
            // 
            this.LblObservacao.AutoSize = true;
            this.LblObservacao.Location = new System.Drawing.Point(153, 73);
            this.LblObservacao.Name = "LblObservacao";
            this.LblObservacao.Size = new System.Drawing.Size(89, 17);
            this.LblObservacao.TabIndex = 16;
            this.LblObservacao.Text = "Observação:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtTitulo.Location = new System.Drawing.Point(156, 36);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(562, 22);
            this.TxtTitulo.TabIndex = 12;
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(156, 93);
            this.TxtObservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(562, 158);
            this.TxtObservacao.TabIndex = 15;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(11, 18);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(56, 17);
            this.LblCodigo.TabIndex = 13;
            this.LblCodigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Título:";
            // 
            // TxtPreco
            // 
            this.TxtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPreco.Location = new System.Drawing.Point(523, 288);
            this.TxtPreco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(94, 22);
            this.TxtPreco.TabIndex = 20;
            this.TxtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Location = new System.Drawing.Point(520, 267);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(49, 17);
            this.LblPreco.TabIndex = 21;
            this.LblPreco.Text = "Preço:";
            // 
            // BtnBscCodigo
            // 
            this.BtnBscCodigo.Image = global::UserInterface.Properties.Resources.busca;
            this.BtnBscCodigo.Location = new System.Drawing.Point(105, 33);
            this.BtnBscCodigo.Name = "BtnBscCodigo";
            this.BtnBscCodigo.Size = new System.Drawing.Size(28, 28);
            this.BtnBscCodigo.TabIndex = 19;
            this.BtnBscCodigo.UseVisualStyleBackColor = true;
            this.BtnBscCodigo.Click += new System.EventHandler(this.BtnBscCodigo_Click);
            // 
            // oUcSituacao
            // 
            this.oUcSituacao.Location = new System.Drawing.Point(519, 316);
            this.oUcSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oUcSituacao.Name = "oUcSituacao";
            this.oUcSituacao.Size = new System.Drawing.Size(199, 69);
            this.oUcSituacao.TabIndex = 18;
            // 
            // LblQtdSabores
            // 
            this.LblQtdSabores.AutoSize = true;
            this.LblQtdSabores.Location = new System.Drawing.Point(625, 267);
            this.LblQtdSabores.Name = "LblQtdSabores";
            this.LblQtdSabores.Size = new System.Drawing.Size(92, 17);
            this.LblQtdSabores.TabIndex = 22;
            this.LblQtdSabores.Text = "Qtd Sabores:";
            // 
            // CmbQtdSabores
            // 
            this.CmbQtdSabores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbQtdSabores.FormattingEnabled = true;
            this.CmbQtdSabores.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CmbQtdSabores.Location = new System.Drawing.Point(628, 287);
            this.CmbQtdSabores.Name = "CmbQtdSabores";
            this.CmbQtdSabores.Size = new System.Drawing.Size(90, 24);
            this.CmbQtdSabores.TabIndex = 23;
            // 
            // FrmCadTamanhoPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.CmbQtdSabores);
            this.Controls.Add(this.LblQtdSabores);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.BtnBscCodigo);
            this.Controls.Add(this.oUcSituacao);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LblObservacao);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadTamanhoPizza";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Tamanhos de Pizza";
            this.Load += new System.EventHandler(this.FrmCadTamanhoPizza_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblObservacao;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label label1;
        private UserInterface.UserControls.ucSituacao oUcSituacao;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnBscCodigo;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblQtdSabores;
        private System.Windows.Forms.ComboBox CmbQtdSabores;
    }
}

