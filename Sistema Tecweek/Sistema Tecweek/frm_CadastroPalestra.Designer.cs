namespace Sistema_Tecweek
{
    partial class frm_CadastroPalestra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_PalestraExcluir = new System.Windows.Forms.Button();
            this.Btn_PalestraEditar = new System.Windows.Forms.Button();
            this.Btn_PalestraNovo = new System.Windows.Forms.Button();
            this.Txt_PalestraPesquisar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_PalestraCancelar = new System.Windows.Forms.Button();
            this.Btn_PalestraGravar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_PalestraNome = new System.Windows.Forms.TextBox();
            this.Txt_PalestraMaxAlunos = new System.Windows.Forms.TextBox();
            this.Dt_PalestraDataHora = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 67);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_PalestraExcluir);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_PalestraEditar);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_PalestraNovo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Txt_PalestraPesquisar);
            this.splitContainer1.Size = new System.Drawing.Size(534, 67);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 0;
            // 
            // Btn_PalestraExcluir
            // 
            this.Btn_PalestraExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PalestraExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PalestraExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PalestraExcluir.Image = global::Sistema_Tecweek.Properties.Resources.Excluir;
            this.Btn_PalestraExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PalestraExcluir.Location = new System.Drawing.Point(158, 4);
            this.Btn_PalestraExcluir.Name = "Btn_PalestraExcluir";
            this.Btn_PalestraExcluir.Size = new System.Drawing.Size(70, 60);
            this.Btn_PalestraExcluir.TabIndex = 3;
            this.Btn_PalestraExcluir.Text = "Excluir";
            this.Btn_PalestraExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_PalestraExcluir.UseVisualStyleBackColor = true;
            this.Btn_PalestraExcluir.Click += new System.EventHandler(this.Btn_PalestraExcluir_Click);
            // 
            // Btn_PalestraEditar
            // 
            this.Btn_PalestraEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PalestraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PalestraEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PalestraEditar.Image = global::Sistema_Tecweek.Properties.Resources.Editar;
            this.Btn_PalestraEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PalestraEditar.Location = new System.Drawing.Point(82, 4);
            this.Btn_PalestraEditar.Name = "Btn_PalestraEditar";
            this.Btn_PalestraEditar.Size = new System.Drawing.Size(70, 60);
            this.Btn_PalestraEditar.TabIndex = 2;
            this.Btn_PalestraEditar.Text = "Editar";
            this.Btn_PalestraEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_PalestraEditar.UseVisualStyleBackColor = true;
            this.Btn_PalestraEditar.Click += new System.EventHandler(this.Btn_PalestraEditar_Click);
            // 
            // Btn_PalestraNovo
            // 
            this.Btn_PalestraNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PalestraNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PalestraNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PalestraNovo.Image = global::Sistema_Tecweek.Properties.Resources.novo;
            this.Btn_PalestraNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_PalestraNovo.Location = new System.Drawing.Point(6, 4);
            this.Btn_PalestraNovo.Name = "Btn_PalestraNovo";
            this.Btn_PalestraNovo.Size = new System.Drawing.Size(70, 60);
            this.Btn_PalestraNovo.TabIndex = 1;
            this.Btn_PalestraNovo.Text = "Novo";
            this.Btn_PalestraNovo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_PalestraNovo.UseVisualStyleBackColor = true;
            this.Btn_PalestraNovo.Click += new System.EventHandler(this.Btn_PalestraNovo_Click);
            // 
            // Txt_PalestraPesquisar
            // 
            this.Txt_PalestraPesquisar.ForeColor = System.Drawing.Color.Silver;
            this.Txt_PalestraPesquisar.Location = new System.Drawing.Point(122, 44);
            this.Txt_PalestraPesquisar.Name = "Txt_PalestraPesquisar";
            this.Txt_PalestraPesquisar.Size = new System.Drawing.Size(172, 20);
            this.Txt_PalestraPesquisar.TabIndex = 1;
            this.Txt_PalestraPesquisar.Text = "Digite para pesquisar...";
            this.Txt_PalestraPesquisar.TextChanged += new System.EventHandler(this.Txt_PalestraPesquisar_TextChanged);
            this.Txt_PalestraPesquisar.Enter += new System.EventHandler(this.Txt_PalestraPesquisar_Enter);
            this.Txt_PalestraPesquisar.Leave += new System.EventHandler(this.Txt_PalestraPesquisar_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_PalestraCancelar);
            this.panel2.Controls.Add(this.Btn_PalestraGravar);
            this.panel2.Location = new System.Drawing.Point(12, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 45);
            this.panel2.TabIndex = 1;
            // 
            // Btn_PalestraCancelar
            // 
            this.Btn_PalestraCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PalestraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PalestraCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PalestraCancelar.Image = global::Sistema_Tecweek.Properties.Resources.Cancelar;
            this.Btn_PalestraCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PalestraCancelar.Location = new System.Drawing.Point(413, 3);
            this.Btn_PalestraCancelar.Name = "Btn_PalestraCancelar";
            this.Btn_PalestraCancelar.Size = new System.Drawing.Size(118, 38);
            this.Btn_PalestraCancelar.TabIndex = 4;
            this.Btn_PalestraCancelar.Text = "Cancelar";
            this.Btn_PalestraCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PalestraCancelar.UseVisualStyleBackColor = true;
            this.Btn_PalestraCancelar.Click += new System.EventHandler(this.Btn_PalestraCancelar_Click);
            // 
            // Btn_PalestraGravar
            // 
            this.Btn_PalestraGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PalestraGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PalestraGravar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PalestraGravar.Image = global::Sistema_Tecweek.Properties.Resources.Gravar;
            this.Btn_PalestraGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PalestraGravar.Location = new System.Drawing.Point(302, 3);
            this.Btn_PalestraGravar.Name = "Btn_PalestraGravar";
            this.Btn_PalestraGravar.Size = new System.Drawing.Size(105, 38);
            this.Btn_PalestraGravar.TabIndex = 3;
            this.Btn_PalestraGravar.Text = "Gravar";
            this.Btn_PalestraGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_PalestraGravar.UseVisualStyleBackColor = true;
            this.Btn_PalestraGravar.Click += new System.EventHandler(this.Btn_PalestraGravar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Máx. Alunos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data e Hora:";
            // 
            // Txt_PalestraNome
            // 
            this.Txt_PalestraNome.Location = new System.Drawing.Point(67, 94);
            this.Txt_PalestraNome.Name = "Txt_PalestraNome";
            this.Txt_PalestraNome.Size = new System.Drawing.Size(221, 20);
            this.Txt_PalestraNome.TabIndex = 6;
            // 
            // Txt_PalestraMaxAlunos
            // 
            this.Txt_PalestraMaxAlunos.Location = new System.Drawing.Point(425, 126);
            this.Txt_PalestraMaxAlunos.Name = "Txt_PalestraMaxAlunos";
            this.Txt_PalestraMaxAlunos.Size = new System.Drawing.Size(121, 20);
            this.Txt_PalestraMaxAlunos.TabIndex = 7;
            // 
            // Dt_PalestraDataHora
            // 
            this.Dt_PalestraDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            this.Dt_PalestraDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt_PalestraDataHora.Location = new System.Drawing.Point(104, 126);
            this.Dt_PalestraDataHora.Name = "Dt_PalestraDataHora";
            this.Dt_PalestraDataHora.Size = new System.Drawing.Size(184, 20);
            this.Dt_PalestraDataHora.TabIndex = 8;
            this.Dt_PalestraDataHora.Value = new System.DateTime(2019, 5, 13, 13, 19, 15, 0);
            // 
            // frm_CadastroPalestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 373);
            this.Controls.Add(this.Dt_PalestraDataHora);
            this.Controls.Add(this.Txt_PalestraMaxAlunos);
            this.Controls.Add(this.Txt_PalestraNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frm_CadastroPalestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Palestras";
            this.Load += new System.EventHandler(this.frm_CadastroPalestra_Load);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Btn_PalestraNovo;
        private System.Windows.Forms.Button Btn_PalestraEditar;
        private System.Windows.Forms.Button Btn_PalestraExcluir;
        private System.Windows.Forms.TextBox Txt_PalestraPesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_PalestraGravar;
        private System.Windows.Forms.Button Btn_PalestraCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_PalestraNome;
        private System.Windows.Forms.TextBox Txt_PalestraMaxAlunos;
        private System.Windows.Forms.DateTimePicker Dt_PalestraDataHora;
    }
}