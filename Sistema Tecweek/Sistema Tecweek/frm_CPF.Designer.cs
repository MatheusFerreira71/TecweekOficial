namespace Sistema_Tecweek
{
    partial class frm_CPF
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
            this.Btn_cpfEditar = new System.Windows.Forms.Button();
            this.Btn_cpfExcluir = new System.Windows.Forms.Button();
            this.Btn_cpfNovo = new System.Windows.Forms.Button();
            this.Txt_cpfPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_cpfNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_cpfCancelar = new System.Windows.Forms.Button();
            this.Btn_cpfGravar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 67);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_cpfEditar);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_cpfExcluir);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_cpfNovo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Txt_cpfPesquisar);
            this.splitContainer1.Size = new System.Drawing.Size(534, 67);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // Btn_cpfEditar
            // 
            this.Btn_cpfEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cpfEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cpfEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cpfEditar.Image = global::Sistema_Tecweek.Properties.Resources.Editar;
            this.Btn_cpfEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cpfEditar.Location = new System.Drawing.Point(80, 4);
            this.Btn_cpfEditar.Name = "Btn_cpfEditar";
            this.Btn_cpfEditar.Size = new System.Drawing.Size(70, 60);
            this.Btn_cpfEditar.TabIndex = 1;
            this.Btn_cpfEditar.Text = "Editar";
            this.Btn_cpfEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cpfEditar.UseVisualStyleBackColor = true;
            this.Btn_cpfEditar.Click += new System.EventHandler(this.Btn_cpfEditar_Click);
            // 
            // Btn_cpfExcluir
            // 
            this.Btn_cpfExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cpfExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cpfExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cpfExcluir.Image = global::Sistema_Tecweek.Properties.Resources.Excluir;
            this.Btn_cpfExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cpfExcluir.Location = new System.Drawing.Point(156, 4);
            this.Btn_cpfExcluir.Name = "Btn_cpfExcluir";
            this.Btn_cpfExcluir.Size = new System.Drawing.Size(70, 60);
            this.Btn_cpfExcluir.TabIndex = 2;
            this.Btn_cpfExcluir.Text = "Excluir";
            this.Btn_cpfExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cpfExcluir.UseVisualStyleBackColor = true;
            this.Btn_cpfExcluir.Click += new System.EventHandler(this.Btn_cpfExcluir_Click);
            // 
            // Btn_cpfNovo
            // 
            this.Btn_cpfNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_cpfNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cpfNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cpfNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cpfNovo.Image = global::Sistema_Tecweek.Properties.Resources.novo;
            this.Btn_cpfNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cpfNovo.Location = new System.Drawing.Point(4, 4);
            this.Btn_cpfNovo.Name = "Btn_cpfNovo";
            this.Btn_cpfNovo.Size = new System.Drawing.Size(70, 60);
            this.Btn_cpfNovo.TabIndex = 0;
            this.Btn_cpfNovo.Text = "Novo";
            this.Btn_cpfNovo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cpfNovo.UseVisualStyleBackColor = true;
            this.Btn_cpfNovo.Click += new System.EventHandler(this.Btn_cpfNovo_Click);
            // 
            // Txt_cpfPesquisar
            // 
            this.Txt_cpfPesquisar.ForeColor = System.Drawing.Color.Silver;
            this.Txt_cpfPesquisar.Location = new System.Drawing.Point(125, 44);
            this.Txt_cpfPesquisar.Name = "Txt_cpfPesquisar";
            this.Txt_cpfPesquisar.Size = new System.Drawing.Size(172, 20);
            this.Txt_cpfPesquisar.TabIndex = 4;
            this.Txt_cpfPesquisar.Text = "Digite para pesquisar...";
            this.Txt_cpfPesquisar.TextChanged += new System.EventHandler(this.Txt_cpfPesquisar_TextChanged);
            this.Txt_cpfPesquisar.Enter += new System.EventHandler(this.Txt_periodoPesquisar_Enter);
            this.Txt_cpfPesquisar.Leave += new System.EventHandler(this.Txt_periodoPesquisar_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF:";
            // 
            // Txt_cpfNome
            // 
            this.Txt_cpfNome.Location = new System.Drawing.Point(54, 110);
            this.Txt_cpfNome.MaxLength = 11;
            this.Txt_cpfNome.Name = "Txt_cpfNome";
            this.Txt_cpfNome.Size = new System.Drawing.Size(118, 20);
            this.Txt_cpfNome.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_cpfCancelar);
            this.panel2.Controls.Add(this.Btn_cpfGravar);
            this.panel2.Location = new System.Drawing.Point(12, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 45);
            this.panel2.TabIndex = 9;
            // 
            // Btn_cpfCancelar
            // 
            this.Btn_cpfCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cpfCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cpfCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cpfCancelar.Image = global::Sistema_Tecweek.Properties.Resources.Cancelar;
            this.Btn_cpfCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cpfCancelar.Location = new System.Drawing.Point(413, 4);
            this.Btn_cpfCancelar.Name = "Btn_cpfCancelar";
            this.Btn_cpfCancelar.Size = new System.Drawing.Size(118, 38);
            this.Btn_cpfCancelar.TabIndex = 11;
            this.Btn_cpfCancelar.Text = "Cancelar";
            this.Btn_cpfCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_cpfCancelar.UseVisualStyleBackColor = true;
            this.Btn_cpfCancelar.Click += new System.EventHandler(this.Btn_cpfCancelar_Click);
            // 
            // Btn_cpfGravar
            // 
            this.Btn_cpfGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cpfGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cpfGravar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cpfGravar.Image = global::Sistema_Tecweek.Properties.Resources.Gravar;
            this.Btn_cpfGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cpfGravar.Location = new System.Drawing.Point(302, 4);
            this.Btn_cpfGravar.Name = "Btn_cpfGravar";
            this.Btn_cpfGravar.Size = new System.Drawing.Size(105, 38);
            this.Btn_cpfGravar.TabIndex = 10;
            this.Btn_cpfGravar.Text = "Gravar";
            this.Btn_cpfGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_cpfGravar.UseVisualStyleBackColor = true;
            this.Btn_cpfGravar.Click += new System.EventHandler(this.Btn_cpfGravar_Click);
            // 
            // frm_CPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(558, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_cpfNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frm_CPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de CPF";
            this.Load += new System.EventHandler(this.frm_CPF_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_cpfNovo;
        private System.Windows.Forms.Button Btn_cpfEditar;
        private System.Windows.Forms.Button Btn_cpfExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox Txt_cpfPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_cpfNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_cpfGravar;
        private System.Windows.Forms.Button Btn_cpfCancelar;
    }
}