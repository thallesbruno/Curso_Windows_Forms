﻿
namespace Curso_Windows_Forms
{
    partial class FrmLeituraArquivo
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
            this.btnLeitura = new System.Windows.Forms.Button();
            this.lsbConteudo = new System.Windows.Forms.ListBox();
            this.btnLeitura2 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeitura
            // 
            this.btnLeitura.Location = new System.Drawing.Point(12, 12);
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Size = new System.Drawing.Size(124, 33);
            this.btnLeitura.TabIndex = 0;
            this.btnLeitura.Text = "1 - Realizar leitura";
            this.btnLeitura.UseVisualStyleBackColor = true;
            this.btnLeitura.Click += new System.EventHandler(this.btnLeitura_Click);
            // 
            // lsbConteudo
            // 
            this.lsbConteudo.FormattingEnabled = true;
            this.lsbConteudo.Location = new System.Drawing.Point(12, 51);
            this.lsbConteudo.Name = "lsbConteudo";
            this.lsbConteudo.Size = new System.Drawing.Size(501, 160);
            this.lsbConteudo.TabIndex = 1;
            // 
            // btnLeitura2
            // 
            this.btnLeitura2.Location = new System.Drawing.Point(142, 12);
            this.btnLeitura2.Name = "btnLeitura2";
            this.btnLeitura2.Size = new System.Drawing.Size(124, 33);
            this.btnLeitura2.TabIndex = 2;
            this.btnLeitura2.Text = "2 - Realizar leitura";
            this.btnLeitura2.UseVisualStyleBackColor = true;
            this.btnLeitura2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(433, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmLeituraArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 221);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLeitura2);
            this.Controls.Add(this.lsbConteudo);
            this.Controls.Add(this.btnLeitura);
            this.Name = "FrmLeituraArquivo";
            this.Text = "Leitura de Arquivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeitura;
        private System.Windows.Forms.ListBox lsbConteudo;
        private System.Windows.Forms.Button btnLeitura2;
        private System.Windows.Forms.Button btnLimpar;
    }
}