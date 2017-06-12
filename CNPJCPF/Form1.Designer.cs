namespace CNPJCPF
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtQuantidadeRegistro = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAjustarCnpjCpf = new System.Windows.Forms.Button();
            this.lblRemocaoCaracteresEspeciais = new System.Windows.Forms.Label();
            this.imgRemoveCaracter = new System.Windows.Forms.PictureBox();
            this.imgRemoveDuplicados = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantidadeRegistro = new System.Windows.Forms.Label();
            this.txtCnpjCpf = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRemoveCaracter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRemoveDuplicados)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtQuantidadeRegistro,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtQuantidadeRegistro
            // 
            this.txtQuantidadeRegistro.Name = "txtQuantidadeRegistro";
            this.txtQuantidadeRegistro.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // btnAjustarCnpjCpf
            // 
            this.btnAjustarCnpjCpf.Location = new System.Drawing.Point(3, 57);
            this.btnAjustarCnpjCpf.Name = "btnAjustarCnpjCpf";
            this.btnAjustarCnpjCpf.Size = new System.Drawing.Size(234, 23);
            this.btnAjustarCnpjCpf.TabIndex = 6;
            this.btnAjustarCnpjCpf.Text = "Ajustar CNPJ/CPF\r\n";
            this.btnAjustarCnpjCpf.UseVisualStyleBackColor = true;
            this.btnAjustarCnpjCpf.Click += new System.EventHandler(this.btnAjustarCnpjCpf_Click);
            // 
            // lblRemocaoCaracteresEspeciais
            // 
            this.lblRemocaoCaracteresEspeciais.AutoSize = true;
            this.lblRemocaoCaracteresEspeciais.Location = new System.Drawing.Point(320, 119);
            this.lblRemocaoCaracteresEspeciais.Name = "lblRemocaoCaracteresEspeciais";
            this.lblRemocaoCaracteresEspeciais.Size = new System.Drawing.Size(166, 13);
            this.lblRemocaoCaracteresEspeciais.TabIndex = 8;
            this.lblRemocaoCaracteresEspeciais.Text = "Remoção de caracteres especias";
            // 
            // imgRemoveCaracter
            // 
            this.imgRemoveCaracter.Location = new System.Drawing.Point(282, 109);
            this.imgRemoveCaracter.Name = "imgRemoveCaracter";
            this.imgRemoveCaracter.Size = new System.Drawing.Size(32, 32);
            this.imgRemoveCaracter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgRemoveCaracter.TabIndex = 7;
            this.imgRemoveCaracter.TabStop = false;
            // 
            // imgRemoveDuplicados
            // 
            this.imgRemoveDuplicados.Location = new System.Drawing.Point(282, 162);
            this.imgRemoveDuplicados.Name = "imgRemoveDuplicados";
            this.imgRemoveDuplicados.Size = new System.Drawing.Size(32, 32);
            this.imgRemoveDuplicados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgRemoveDuplicados.TabIndex = 9;
            this.imgRemoveDuplicados.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remoção de itens duplicados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantidade:";
            // 
            // lblQuantidadeRegistro
            // 
            this.lblQuantidadeRegistro.AutoSize = true;
            this.lblQuantidadeRegistro.Location = new System.Drawing.Point(62, 565);
            this.lblQuantidadeRegistro.Name = "lblQuantidadeRegistro";
            this.lblQuantidadeRegistro.Size = new System.Drawing.Size(0, 13);
            this.lblQuantidadeRegistro.TabIndex = 12;
            // 
            // txtCnpjCpf
            // 
            this.txtCnpjCpf.Location = new System.Drawing.Point(3, 86);
            this.txtCnpjCpf.Name = "txtCnpjCpf";
            this.txtCnpjCpf.Size = new System.Drawing.Size(234, 476);
            this.txtCnpjCpf.TabIndex = 13;
            this.txtCnpjCpf.Text = "";
            this.txtCnpjCpf.TextChanged += new System.EventHandler(this.txtCnpjCpf_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 605);
            this.Controls.Add(this.txtCnpjCpf);
            this.Controls.Add(this.lblQuantidadeRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgRemoveDuplicados);
            this.Controls.Add(this.lblRemocaoCaracteresEspeciais);
            this.Controls.Add(this.imgRemoveCaracter);
            this.Controls.Add(this.btnAjustarCnpjCpf);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRemoveCaracter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRemoveDuplicados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel txtQuantidadeRegistro;
        private System.Windows.Forms.Button btnAjustarCnpjCpf;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox imgRemoveCaracter;
        private System.Windows.Forms.Label lblRemocaoCaracteresEspeciais;
        private System.Windows.Forms.PictureBox imgRemoveDuplicados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuantidadeRegistro;
        private System.Windows.Forms.RichTextBox txtCnpjCpf;
    }
}

