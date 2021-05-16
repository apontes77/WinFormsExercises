
namespace urnaEletronica
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilizarNovoVotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.contabilizarNovoVotoToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(985, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem1.Text = "Reiniciar Urna";
            // 
            // contabilizarNovoVotoToolStripMenuItem
            // 
            this.contabilizarNovoVotoToolStripMenuItem.Name = "contabilizarNovoVotoToolStripMenuItem";
            this.contabilizarNovoVotoToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.contabilizarNovoVotoToolStripMenuItem.Text = "Contabilizar Novo Voto";
            this.contabilizarNovoVotoToolStripMenuItem.Click += new System.EventHandler(this.contabilizarNovoVotoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 20);
            this.toolStripMenuItem2.Text = "Exibir Relatório";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(985, 442);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarUrnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirNovoVotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirRelatórioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contabilizarNovoVotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

