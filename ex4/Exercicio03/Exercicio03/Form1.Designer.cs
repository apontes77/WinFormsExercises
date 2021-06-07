
namespace Exercicio03
{
	partial class FormPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.Label lblQtde;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidadeNotas = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtNotaMaisAlta = new System.Windows.Forms.TextBox();
            this.txtNotaMaisBaixa = new System.Windows.Forms.TextBox();
            this.txtAcimaMedia = new System.Windows.Forms.TextBox();
            this.txtAbaixoMedia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            lblQtde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQtde
            // 
            lblQtde.AutoSize = true;
            lblQtde.Location = new System.Drawing.Point(36, 40);
            lblQtde.Name = "lblQtde";
            lblQtde.Size = new System.Drawing.Size(149, 15);
            lblQtde.TabIndex = 0;
            lblQtde.Text = "Quantidade de Notas Lidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Média";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota mais alta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota mais baixa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alunos acima de média";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alunos abaixo da média";
            // 
            // txtQuantidadeNotas
            // 
            this.txtQuantidadeNotas.Location = new System.Drawing.Point(206, 32);
            this.txtQuantidadeNotas.Name = "txtQuantidadeNotas";
            this.txtQuantidadeNotas.Size = new System.Drawing.Size(212, 23);
            this.txtQuantidadeNotas.TabIndex = 6;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(206, 68);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(212, 23);
            this.txtMedia.TabIndex = 7;
            // 
            // txtNotaMaisAlta
            // 
            this.txtNotaMaisAlta.Location = new System.Drawing.Point(206, 105);
            this.txtNotaMaisAlta.Name = "txtNotaMaisAlta";
            this.txtNotaMaisAlta.Size = new System.Drawing.Size(212, 23);
            this.txtNotaMaisAlta.TabIndex = 8;
            // 
            // txtNotaMaisBaixa
            // 
            this.txtNotaMaisBaixa.Location = new System.Drawing.Point(206, 145);
            this.txtNotaMaisBaixa.Name = "txtNotaMaisBaixa";
            this.txtNotaMaisBaixa.Size = new System.Drawing.Size(212, 23);
            this.txtNotaMaisBaixa.TabIndex = 9;
            // 
            // txtAcimaMedia
            // 
            this.txtAcimaMedia.Location = new System.Drawing.Point(206, 190);
            this.txtAcimaMedia.Name = "txtAcimaMedia";
            this.txtAcimaMedia.Size = new System.Drawing.Size(212, 23);
            this.txtAcimaMedia.TabIndex = 10;
            // 
            // txtAbaixoMedia
            // 
            this.txtAbaixoMedia.Location = new System.Drawing.Point(206, 242);
            this.txtAbaixoMedia.Name = "txtAbaixoMedia";
            this.txtAbaixoMedia.Size = new System.Drawing.Size(212, 23);
            this.txtAbaixoMedia.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAbaixoMedia);
            this.Controls.Add(this.txtAcimaMedia);
            this.Controls.Add(this.txtNotaMaisBaixa);
            this.Controls.Add(this.txtNotaMaisAlta);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtQuantidadeNotas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(lblQtde);
            this.Name = "FormPrincipal";
            this.Text = "Sair";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtQuantidadeNotas;
		private System.Windows.Forms.TextBox txtMedia;
		private System.Windows.Forms.TextBox txtNotaMaisAlta;
		private System.Windows.Forms.TextBox txtNotaMaisBaixa;
		private System.Windows.Forms.TextBox txtAcimaMedia;
		private System.Windows.Forms.TextBox txtAbaixoMedia;
		private System.Windows.Forms.Button button1;
	}
}

