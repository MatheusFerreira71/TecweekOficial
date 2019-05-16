namespace Sistema_Tecweek
{
    partial class frm_telaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.palestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosEmPalestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presençasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPalestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.presençaPorPalestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastradosPorPalestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.presençasToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.palestrasToolStripMenuItem,
            this.alunosEmPalestrasToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.alunosToolStripMenuItem.Text = "Participantes";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DoubleClickEnabled = true;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItem1.Text = "Escolaridade";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // palestrasToolStripMenuItem
            // 
            this.palestrasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.palestrasToolStripMenuItem.Name = "palestrasToolStripMenuItem";
            this.palestrasToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.palestrasToolStripMenuItem.Text = "Palestras";
            this.palestrasToolStripMenuItem.Click += new System.EventHandler(this.palestrasToolStripMenuItem_Click);
            // 
            // alunosEmPalestrasToolStripMenuItem
            // 
            this.alunosEmPalestrasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alunosEmPalestrasToolStripMenuItem.Name = "alunosEmPalestrasToolStripMenuItem";
            this.alunosEmPalestrasToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.alunosEmPalestrasToolStripMenuItem.Text = "Participantes das Palestras";
            this.alunosEmPalestrasToolStripMenuItem.Click += new System.EventHandler(this.alunosEmPalestrasToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // presençasToolStripMenuItem
            // 
            this.presençasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porDiaToolStripMenuItem,
            this.porPalestraToolStripMenuItem});
            this.presençasToolStripMenuItem.Name = "presençasToolStripMenuItem";
            this.presençasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.presençasToolStripMenuItem.Text = "Presenças";
            // 
            // porDiaToolStripMenuItem
            // 
            this.porDiaToolStripMenuItem.Name = "porDiaToolStripMenuItem";
            this.porDiaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.porDiaToolStripMenuItem.Text = "Por Dia";
            // 
            // porPalestraToolStripMenuItem
            // 
            this.porPalestraToolStripMenuItem.Name = "porPalestraToolStripMenuItem";
            this.porPalestraToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.porPalestraToolStripMenuItem.Text = "Por Palestra";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porDiaToolStripMenuItem1,
            this.presençaPorPalestraToolStripMenuItem,
            this.cadastradosPorPalestraToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // porDiaToolStripMenuItem1
            // 
            this.porDiaToolStripMenuItem1.Name = "porDiaToolStripMenuItem1";
            this.porDiaToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.porDiaToolStripMenuItem1.Text = "Presença por dia";
            // 
            // presençaPorPalestraToolStripMenuItem
            // 
            this.presençaPorPalestraToolStripMenuItem.Name = "presençaPorPalestraToolStripMenuItem";
            this.presençaPorPalestraToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.presençaPorPalestraToolStripMenuItem.Text = "Presença por palestra";
            // 
            // cadastradosPorPalestraToolStripMenuItem
            // 
            this.cadastradosPorPalestraToolStripMenuItem.Name = "cadastradosPorPalestraToolStripMenuItem";
            this.cadastradosPorPalestraToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastradosPorPalestraToolStripMenuItem.Text = "Cadastrados por palestra";
            // 
            // frm_telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Sistema_Tecweek.Properties.Resources.Fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 514);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presençasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPalestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosEmPalestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem presençaPorPalestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastradosPorPalestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
    }
}

