
namespace Exemplo1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbLocal = new System.Windows.Forms.ComboBox();
            this.CmbProdutos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LbTotal = new System.Windows.Forms.Label();
            this.LbFrete = new System.Windows.Forms.Label();
            this.LbValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbLocal);
            this.groupBox1.Controls.Add(this.CmbProdutos);
            this.groupBox1.Location = new System.Drawing.Point(26, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o que deseja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local de Entrega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto:";
            // 
            // CmbLocal
            // 
            this.CmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLocal.FormattingEnabled = true;
            this.CmbLocal.Items.AddRange(new object[] {
            "Espírito Santo",
            "Goiás",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Rio de Janeiro",
            "Rio Grande do Sul",
            "São Paulo"});
            this.CmbLocal.Location = new System.Drawing.Point(252, 84);
            this.CmbLocal.Name = "CmbLocal";
            this.CmbLocal.Size = new System.Drawing.Size(183, 21);
            this.CmbLocal.Sorted = true;
            this.CmbLocal.TabIndex = 1;
            // 
            // CmbProdutos
            // 
            this.CmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProdutos.FormattingEnabled = true;
            this.CmbProdutos.Items.AddRange(new object[] {
            "Ar Condicionado",
            "Fogão",
            "Geladeira",
            "Microondas",
            "Sofá"});
            this.CmbProdutos.Location = new System.Drawing.Point(253, 33);
            this.CmbProdutos.Name = "CmbProdutos";
            this.CmbProdutos.Size = new System.Drawing.Size(183, 21);
            this.CmbProdutos.Sorted = true;
            this.CmbProdutos.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LbTotal);
            this.groupBox2.Controls.Add(this.LbFrete);
            this.groupBox2.Controls.Add(this.LbValor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(24, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Valores:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LbTotal
            // 
            this.LbTotal.Location = new System.Drawing.Point(253, 120);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(31, 19);
            this.LbTotal.TabIndex = 5;
            this.LbTotal.Text = "0";
            this.LbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbFrete
            // 
            this.LbFrete.Location = new System.Drawing.Point(256, 81);
            this.LbFrete.Name = "LbFrete";
            this.LbFrete.Size = new System.Drawing.Size(28, 19);
            this.LbFrete.TabIndex = 4;
            this.LbFrete.Text = "0";
            this.LbFrete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LbValor
            // 
            this.LbValor.Location = new System.Drawing.Point(259, 37);
            this.LbValor.Name = "LbValor";
            this.LbValor.Size = new System.Drawing.Size(25, 20);
            this.LbValor.TabIndex = 3;
            this.LbValor.Text = "0";
            this.LbValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Frete:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor do Produto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Calcular Valor Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbLocal;
        private System.Windows.Forms.ComboBox CmbProdutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Label LbFrete;
        private System.Windows.Forms.Label LbValor;
    }
}

