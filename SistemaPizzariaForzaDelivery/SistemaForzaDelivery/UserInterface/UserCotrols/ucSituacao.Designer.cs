namespace UserInterface.UserControls
{
    partial class ucSituacao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OptInativo = new System.Windows.Forms.RadioButton();
            this.OptAtivo = new System.Windows.Forms.RadioButton();
            this.GcSituacao = new System.Windows.Forms.GroupBox();
            this.GcSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptInativo
            // 
            this.OptInativo.AutoSize = true;
            this.OptInativo.Location = new System.Drawing.Point(74, 20);
            this.OptInativo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptInativo.Name = "OptInativo";
            this.OptInativo.Size = new System.Drawing.Size(57, 17);
            this.OptInativo.TabIndex = 1;
            this.OptInativo.TabStop = true;
            this.OptInativo.Text = "Inativo";
            this.OptInativo.UseVisualStyleBackColor = true;
            this.OptInativo.CheckedChanged += new System.EventHandler(this.OptInativo_CheckedChanged);
            // 
            // OptAtivo
            // 
            this.OptAtivo.AutoSize = true;
            this.OptAtivo.Location = new System.Drawing.Point(7, 20);
            this.OptAtivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptAtivo.Name = "OptAtivo";
            this.OptAtivo.Size = new System.Drawing.Size(49, 17);
            this.OptAtivo.TabIndex = 0;
            this.OptAtivo.TabStop = true;
            this.OptAtivo.Text = "Ativo";
            this.OptAtivo.UseVisualStyleBackColor = true;
            this.OptAtivo.CheckedChanged += new System.EventHandler(this.OptAtivo_CheckedChanged);
            // 
            // GcSituacao
            // 
            this.GcSituacao.Controls.Add(this.OptInativo);
            this.GcSituacao.Controls.Add(this.OptAtivo);
            this.GcSituacao.Location = new System.Drawing.Point(3, 3);
            this.GcSituacao.Name = "GcSituacao";
            this.GcSituacao.Size = new System.Drawing.Size(144, 50);
            this.GcSituacao.TabIndex = 1;
            this.GcSituacao.TabStop = false;
            this.GcSituacao.Text = "Situação";
            // 
            // ucSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GcSituacao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucSituacao";
            this.Size = new System.Drawing.Size(149, 56);
            this.Load += new System.EventHandler(this.ucSituacao_Load);
            this.GcSituacao.ResumeLayout(false);
            this.GcSituacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton OptInativo;
        public System.Windows.Forms.RadioButton OptAtivo;
        private System.Windows.Forms.GroupBox GcSituacao;
    }
}
