namespace Sistema_Tecweek
{
    partial class Frm_CadastrarAlunoNaPalestra
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GV_CPalestraPrincipal = new System.Windows.Forms.DataGridView();
            this.GV_CPalestraAlunos = new System.Windows.Forms.DataGridView();
            this.CB_CPalestraPalestras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CPalestraCodAluno = new System.Windows.Forms.TextBox();
            this.Txt_CPalestraNomeAluno = new System.Windows.Forms.TextBox();
            this.Txt_CPalestraCPFAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_CPalestraPesquisarAlunos = new System.Windows.Forms.TextBox();
            this.Btn_CPalestraNovo = new System.Windows.Forms.Button();
            this.Btn_CPalestraEditar = new System.Windows.Forms.Button();
            this.Btn_CPalestraExcluir = new System.Windows.Forms.Button();
            this.Btn_CPalestraCancelar = new System.Windows.Forms.Button();
            this.Btn_CPalestraGravar = new System.Windows.Forms.Button();
            this.Txt_CPalestraPesquisarPrincipal = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CPalestraPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CPalestraAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_CPalestraGravar);
            this.panel2.Controls.Add(this.Btn_CPalestraCancelar);
            this.panel2.Location = new System.Drawing.Point(12, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 50);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_CPalestraExcluir);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_CPalestraNovo);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_CPalestraEditar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Txt_CPalestraPesquisarPrincipal);
            this.splitContainer1.Size = new System.Drawing.Size(734, 66);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 66);
            this.panel1.TabIndex = 0;
            // 
            // GV_CPalestraPrincipal
            // 
            this.GV_CPalestraPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_CPalestraPrincipal.Location = new System.Drawing.Point(12, 338);
            this.GV_CPalestraPrincipal.Name = "GV_CPalestraPrincipal";
            this.GV_CPalestraPrincipal.Size = new System.Drawing.Size(734, 176);
            this.GV_CPalestraPrincipal.TabIndex = 2;
            // 
            // GV_CPalestraAlunos
            // 
            this.GV_CPalestraAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_CPalestraAlunos.Location = new System.Drawing.Point(12, 128);
            this.GV_CPalestraAlunos.Name = "GV_CPalestraAlunos";
            this.GV_CPalestraAlunos.Size = new System.Drawing.Size(360, 190);
            this.GV_CPalestraAlunos.TabIndex = 3;
            // 
            // CB_CPalestraPalestras
            // 
            this.CB_CPalestraPalestras.FormattingEnabled = true;
            this.CB_CPalestraPalestras.Location = new System.Drawing.Point(558, 145);
            this.CB_CPalestraPalestras.Name = "CB_CPalestraPalestras";
            this.CB_CPalestraPalestras.Size = new System.Drawing.Size(189, 21);
            this.CB_CPalestraPalestras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palestra";
            // 
            // Txt_CPalestraCodAluno
            // 
            this.Txt_CPalestraCodAluno.Location = new System.Drawing.Point(378, 145);
            this.Txt_CPalestraCodAluno.Name = "Txt_CPalestraCodAluno";
            this.Txt_CPalestraCodAluno.ReadOnly = true;
            this.Txt_CPalestraCodAluno.Size = new System.Drawing.Size(173, 20);
            this.Txt_CPalestraCodAluno.TabIndex = 6;
            // 
            // Txt_CPalestraNomeAluno
            // 
            this.Txt_CPalestraNomeAluno.Location = new System.Drawing.Point(378, 228);
            this.Txt_CPalestraNomeAluno.Name = "Txt_CPalestraNomeAluno";
            this.Txt_CPalestraNomeAluno.ReadOnly = true;
            this.Txt_CPalestraNomeAluno.Size = new System.Drawing.Size(173, 20);
            this.Txt_CPalestraNomeAluno.TabIndex = 7;
            // 
            // Txt_CPalestraCPFAluno
            // 
            this.Txt_CPalestraCPFAluno.Location = new System.Drawing.Point(378, 298);
            this.Txt_CPalestraCPFAluno.Name = "Txt_CPalestraCPFAluno";
            this.Txt_CPalestraCPFAluno.ReadOnly = true;
            this.Txt_CPalestraCPFAluno.Size = new System.Drawing.Size(173, 20);
            this.Txt_CPalestraCPFAluno.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF";
            // 
            // Txt_CPalestraPesquisarAlunos
            // 
            this.Txt_CPalestraPesquisarAlunos.ForeColor = System.Drawing.Color.Silver;
            this.Txt_CPalestraPesquisarAlunos.Location = new System.Drawing.Point(12, 102);
            this.Txt_CPalestraPesquisarAlunos.Name = "Txt_CPalestraPesquisarAlunos";
            this.Txt_CPalestraPesquisarAlunos.Size = new System.Drawing.Size(189, 20);
            this.Txt_CPalestraPesquisarAlunos.TabIndex = 12;
            this.Txt_CPalestraPesquisarAlunos.Text = "Pesquisar aluno...";
            this.Txt_CPalestraPesquisarAlunos.Enter += new System.EventHandler(this.Txt_CPalestraPesquisarAlunos_Enter);
            this.Txt_CPalestraPesquisarAlunos.Leave += new System.EventHandler(this.Txt_CPalestraPesquisarAlunos_Leave);
            // 
            // Btn_CPalestraNovo
            // 
            this.Btn_CPalestraNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CPalestraNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CPalestraNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CPalestraNovo.Image = global::Sistema_Tecweek.Properties.Resources.novo;
            this.Btn_CPalestraNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_CPalestraNovo.Location = new System.Drawing.Point(6, 3);
            this.Btn_CPalestraNovo.Name = "Btn_CPalestraNovo";
            this.Btn_CPalestraNovo.Size = new System.Drawing.Size(70, 60);
            this.Btn_CPalestraNovo.TabIndex = 13;
            this.Btn_CPalestraNovo.Text = "Novo";
            this.Btn_CPalestraNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_CPalestraNovo.UseVisualStyleBackColor = true;
            this.Btn_CPalestraNovo.Click += new System.EventHandler(this.Btn_CPalestraNovo_Click);
            // 
            // Btn_CPalestraEditar
            // 
            this.Btn_CPalestraEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CPalestraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CPalestraEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CPalestraEditar.Image = global::Sistema_Tecweek.Properties.Resources.Editar;
            this.Btn_CPalestraEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_CPalestraEditar.Location = new System.Drawing.Point(87, 3);
            this.Btn_CPalestraEditar.Name = "Btn_CPalestraEditar";
            this.Btn_CPalestraEditar.Size = new System.Drawing.Size(70, 60);
            this.Btn_CPalestraEditar.TabIndex = 14;
            this.Btn_CPalestraEditar.Text = "Editar";
            this.Btn_CPalestraEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_CPalestraEditar.UseVisualStyleBackColor = true;
            this.Btn_CPalestraEditar.Click += new System.EventHandler(this.Btn_CPalestraEditar_Click);
            // 
            // Btn_CPalestraExcluir
            // 
            this.Btn_CPalestraExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CPalestraExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CPalestraExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CPalestraExcluir.Image = global::Sistema_Tecweek.Properties.Resources.Excluir;
            this.Btn_CPalestraExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_CPalestraExcluir.Location = new System.Drawing.Point(168, 3);
            this.Btn_CPalestraExcluir.Name = "Btn_CPalestraExcluir";
            this.Btn_CPalestraExcluir.Size = new System.Drawing.Size(70, 60);
            this.Btn_CPalestraExcluir.TabIndex = 15;
            this.Btn_CPalestraExcluir.Text = "Excluir";
            this.Btn_CPalestraExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_CPalestraExcluir.UseVisualStyleBackColor = true;
            // 
            // Btn_CPalestraCancelar
            // 
            this.Btn_CPalestraCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CPalestraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CPalestraCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CPalestraCancelar.Image = global::Sistema_Tecweek.Properties.Resources.Cancelar;
            this.Btn_CPalestraCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CPalestraCancelar.Location = new System.Drawing.Point(613, 9);
            this.Btn_CPalestraCancelar.Name = "Btn_CPalestraCancelar";
            this.Btn_CPalestraCancelar.Size = new System.Drawing.Size(118, 38);
            this.Btn_CPalestraCancelar.TabIndex = 13;
            this.Btn_CPalestraCancelar.Text = "Cancelar";
            this.Btn_CPalestraCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CPalestraCancelar.UseVisualStyleBackColor = true;
            this.Btn_CPalestraCancelar.Click += new System.EventHandler(this.Btn_CPalestraCancelar_Click);
            // 
            // Btn_CPalestraGravar
            // 
            this.Btn_CPalestraGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CPalestraGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CPalestraGravar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CPalestraGravar.Image = global::Sistema_Tecweek.Properties.Resources.Gravar;
            this.Btn_CPalestraGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CPalestraGravar.Location = new System.Drawing.Point(502, 9);
            this.Btn_CPalestraGravar.Name = "Btn_CPalestraGravar";
            this.Btn_CPalestraGravar.Size = new System.Drawing.Size(105, 38);
            this.Btn_CPalestraGravar.TabIndex = 14;
            this.Btn_CPalestraGravar.Text = "Gravar";
            this.Btn_CPalestraGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CPalestraGravar.UseVisualStyleBackColor = true;
            // 
            // Txt_CPalestraPesquisarPrincipal
            // 
            this.Txt_CPalestraPesquisarPrincipal.ForeColor = System.Drawing.Color.Silver;
            this.Txt_CPalestraPesquisarPrincipal.Location = new System.Drawing.Point(297, 40);
            this.Txt_CPalestraPesquisarPrincipal.Name = "Txt_CPalestraPesquisarPrincipal";
            this.Txt_CPalestraPesquisarPrincipal.Size = new System.Drawing.Size(186, 20);
            this.Txt_CPalestraPesquisarPrincipal.TabIndex = 0;
            this.Txt_CPalestraPesquisarPrincipal.Text = "Digite para pesquisar...";
            this.Txt_CPalestraPesquisarPrincipal.Enter += new System.EventHandler(this.Txt_CPalestraPesquisarPrincipal_Enter);
            this.Txt_CPalestraPesquisarPrincipal.Leave += new System.EventHandler(this.Txt_CPalestraPesquisarPrincipal_Leave);
            // 
            // Frm_CadastrarAlunoNaPalestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 582);
            this.Controls.Add(this.Txt_CPalestraPesquisarAlunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_CPalestraCPFAluno);
            this.Controls.Add(this.Txt_CPalestraNomeAluno);
            this.Controls.Add(this.Txt_CPalestraCodAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_CPalestraPalestras);
            this.Controls.Add(this.GV_CPalestraAlunos);
            this.Controls.Add(this.GV_CPalestraPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_CadastrarAlunoNaPalestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Participante na Palestra";
            this.Load += new System.EventHandler(this.Frm_CadastrarAlunoNaPalestra_Load);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GV_CPalestraPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_CPalestraAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GV_CPalestraPrincipal;
        private System.Windows.Forms.DataGridView GV_CPalestraAlunos;
        private System.Windows.Forms.ComboBox CB_CPalestraPalestras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_CPalestraCodAluno;
        private System.Windows.Forms.TextBox Txt_CPalestraNomeAluno;
        private System.Windows.Forms.TextBox Txt_CPalestraCPFAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_CPalestraPesquisarAlunos;
        private System.Windows.Forms.Button Btn_CPalestraNovo;
        private System.Windows.Forms.Button Btn_CPalestraEditar;
        private System.Windows.Forms.Button Btn_CPalestraExcluir;
        private System.Windows.Forms.Button Btn_CPalestraCancelar;
        private System.Windows.Forms.Button Btn_CPalestraGravar;
        private System.Windows.Forms.TextBox Txt_CPalestraPesquisarPrincipal;
    }
}