namespace Sistema_Tecweek
{
    partial class frm_Escolaridade
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
            this.Txt_escolaPesquisar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_escolaEditar = new System.Windows.Forms.Button();
            this.Btn_escolaNovo = new System.Windows.Forms.Button();
            this.Btn_escolaExcluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_escolaCancelar = new System.Windows.Forms.Button();
            this.Btn_escolaSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_escolaCod = new System.Windows.Forms.TextBox();
            this.Txt_escolaNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_escolaPesquisar
            // 
            this.Txt_escolaPesquisar.ForeColor = System.Drawing.Color.Silver;
            this.Txt_escolaPesquisar.Location = new System.Drawing.Point(124, 40);
            this.Txt_escolaPesquisar.Name = "Txt_escolaPesquisar";
            this.Txt_escolaPesquisar.Size = new System.Drawing.Size(173, 20);
            this.Txt_escolaPesquisar.TabIndex = 1;
            this.Txt_escolaPesquisar.Text = "Digite para pesquisar...";
            this.Txt_escolaPesquisar.Enter += new System.EventHandler(this.Txt_pesquisar_Enter);
            this.Txt_escolaPesquisar.Leave += new System.EventHandler(this.Txt_pesquisar_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 66);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_escolaEditar);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_escolaNovo);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_escolaExcluir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Txt_escolaPesquisar);
            this.splitContainer1.Size = new System.Drawing.Size(534, 66);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // Btn_escolaEditar
            // 
            this.Btn_escolaEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_escolaEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_escolaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_escolaEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_escolaEditar.Image = global::Sistema_Tecweek.Properties.Resources.Editar;
            this.Btn_escolaEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_escolaEditar.Location = new System.Drawing.Point(80, 3);
            this.Btn_escolaEditar.Name = "Btn_escolaEditar";
            this.Btn_escolaEditar.Size = new System.Drawing.Size(70, 60);
            this.Btn_escolaEditar.TabIndex = 3;
            this.Btn_escolaEditar.Text = "Editar";
            this.Btn_escolaEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_escolaEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_escolaEditar.UseVisualStyleBackColor = true;
            // 
            // Btn_escolaNovo
            // 
            this.Btn_escolaNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_escolaNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_escolaNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_escolaNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_escolaNovo.Image = global::Sistema_Tecweek.Properties.Resources.novo;
            this.Btn_escolaNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_escolaNovo.Location = new System.Drawing.Point(4, 3);
            this.Btn_escolaNovo.Name = "Btn_escolaNovo";
            this.Btn_escolaNovo.Size = new System.Drawing.Size(70, 60);
            this.Btn_escolaNovo.TabIndex = 0;
            this.Btn_escolaNovo.Text = "Novo";
            this.Btn_escolaNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_escolaNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_escolaNovo.UseVisualStyleBackColor = true;
            this.Btn_escolaNovo.Click += new System.EventHandler(this.Btn_escolaNovo_Click);
            // 
            // Btn_escolaExcluir
            // 
            this.Btn_escolaExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_escolaExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_escolaExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_escolaExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_escolaExcluir.Image = global::Sistema_Tecweek.Properties.Resources.Excluir;
            this.Btn_escolaExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_escolaExcluir.Location = new System.Drawing.Point(156, 3);
            this.Btn_escolaExcluir.Name = "Btn_escolaExcluir";
            this.Btn_escolaExcluir.Size = new System.Drawing.Size(70, 60);
            this.Btn_escolaExcluir.TabIndex = 4;
            this.Btn_escolaExcluir.Text = "Excluir";
            this.Btn_escolaExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_escolaExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Btn_escolaExcluir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_escolaCancelar);
            this.panel2.Controls.Add(this.Btn_escolaSalvar);
            this.panel2.Location = new System.Drawing.Point(12, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 44);
            this.panel2.TabIndex = 3;
            // 
            // Btn_escolaCancelar
            // 
            this.Btn_escolaCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_escolaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_escolaCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_escolaCancelar.Image = global::Sistema_Tecweek.Properties.Resources.Cancelar;
            this.Btn_escolaCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_escolaCancelar.Location = new System.Drawing.Point(413, 3);
            this.Btn_escolaCancelar.Name = "Btn_escolaCancelar";
            this.Btn_escolaCancelar.Size = new System.Drawing.Size(118, 38);
            this.Btn_escolaCancelar.TabIndex = 5;
            this.Btn_escolaCancelar.Text = "Cancelar";
            this.Btn_escolaCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_escolaCancelar.UseVisualStyleBackColor = true;
            this.Btn_escolaCancelar.Click += new System.EventHandler(this.Btn_escolaCancelar_Click);
            // 
            // Btn_escolaSalvar
            // 
            this.Btn_escolaSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_escolaSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_escolaSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_escolaSalvar.Image = global::Sistema_Tecweek.Properties.Resources.Gravar;
            this.Btn_escolaSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_escolaSalvar.Location = new System.Drawing.Point(302, 3);
            this.Btn_escolaSalvar.Name = "Btn_escolaSalvar";
            this.Btn_escolaSalvar.Size = new System.Drawing.Size(105, 38);
            this.Btn_escolaSalvar.TabIndex = 4;
            this.Btn_escolaSalvar.Text = "Gravar";
            this.Btn_escolaSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_escolaSalvar.UseVisualStyleBackColor = true;
            this.Btn_escolaSalvar.Click += new System.EventHandler(this.Btn_escolaSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Curso:";
            // 
            // Txt_escolaCod
            // 
            this.Txt_escolaCod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_escolaCod.Location = new System.Drawing.Point(80, 95);
            this.Txt_escolaCod.Name = "Txt_escolaCod";
            this.Txt_escolaCod.ReadOnly = true;
            this.Txt_escolaCod.Size = new System.Drawing.Size(100, 20);
            this.Txt_escolaCod.TabIndex = 6;
            // 
            // Txt_escolaNome
            // 
            this.Txt_escolaNome.Location = new System.Drawing.Point(80, 120);
            this.Txt_escolaNome.Name = "Txt_escolaNome";
            this.Txt_escolaNome.Size = new System.Drawing.Size(204, 20);
            this.Txt_escolaNome.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // frm_Escolaridade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 373);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_escolaNome);
            this.Controls.Add(this.Txt_escolaCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Escolaridade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Escolaridade";
            this.Load += new System.EventHandler(this.frm_Escolaridade_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_escolaPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_escolaNovo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Btn_escolaEditar;
        private System.Windows.Forms.Button Btn_escolaExcluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_escolaCancelar;
        private System.Windows.Forms.Button Btn_escolaSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_escolaCod;
        private System.Windows.Forms.TextBox Txt_escolaNome;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}