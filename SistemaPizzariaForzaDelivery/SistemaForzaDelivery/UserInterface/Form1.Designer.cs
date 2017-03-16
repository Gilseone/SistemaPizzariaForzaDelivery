namespace UserInterface
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucSituacao1 = new UserInterface.UserControls.ucSituacao();
            this.BtnBscCodigo = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(156, 292);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descrição:";
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
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(156, 93);
            this.TxtDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(562, 110);
            this.TxtDescricao.TabIndex = 15;
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
            // ucSituacao1
            // 
            this.ucSituacao1.Location = new System.Drawing.Point(519, 217);
            this.ucSituacao1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucSituacao1.Name = "ucSituacao1";
            this.ucSituacao1.Size = new System.Drawing.Size(199, 69);
            this.ucSituacao1.TabIndex = 18;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 348);
            this.Controls.Add(this.BtnBscCodigo);
            this.Controls.Add(this.ucSituacao1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label label1;
        private UserInterface.UserControls.ucSituacao ucSituacao1;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnBscCodigo;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
    }
}

