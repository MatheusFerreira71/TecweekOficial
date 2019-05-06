namespace Sistema_Tecweek
{
    partial class frm_cadastroParticipantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_partiCod = new System.Windows.Forms.TextBox();
            this.Txt_partiNome = new System.Windows.Forms.TextBox();
            this.Txt_partiCPF = new System.Windows.Forms.TextBox();
            this.dtp_partiNascimento = new System.Windows.Forms.DateTimePicker();
            this.Txt_partiEmail = new System.Windows.Forms.TextBox();
            this.Txt_partiTelefone = new System.Windows.Forms.TextBox();
            this.Cb_partiEscolaridade = new System.Windows.Forms.ComboBox();
            this.Btn_partiNovo = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_partiEditar = new System.Windows.Forms.Button();
            this.Btn_partiExcluir = new System.Windows.Forms.Button();
            this.Btn_partiGravar = new System.Windows.Forms.Button();
            this.Btn_partiCancelar = new System.Windows.Forms.Button();
            this.Txt_partiPesquisar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Escolaridade:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 67);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_partiCancelar);
            this.panel2.Controls.Add(this.Btn_partiGravar);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 45);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Txt_partiCod
            // 
            this.Txt_partiCod.Location = new System.Drawing.Point(71, 91);
            this.Txt_partiCod.Name = "Txt_partiCod";
            this.Txt_partiCod.ReadOnly = true;
            this.Txt_partiCod.Size = new System.Drawing.Size(100, 20);
            this.Txt_partiCod.TabIndex = 10;
            // 
            // Txt_partiNome
            // 
            this.Txt_partiNome.Location = new System.Drawing.Point(71, 143);
            this.Txt_partiNome.Name = "Txt_partiNome";
            this.Txt_partiNome.Size = new System.Drawing.Size(176, 20);
            this.Txt_partiNome.TabIndex = 11;
            // 
            // Txt_partiCPF
            // 
            this.Txt_partiCPF.Location = new System.Drawing.Point(71, 117);
            this.Txt_partiCPF.MaxLength = 11;
            this.Txt_partiCPF.Name = "Txt_partiCPF";
            this.Txt_partiCPF.Size = new System.Drawing.Size(100, 20);
            this.Txt_partiCPF.TabIndex = 12;
            // 
            // dtp_partiNascimento
            // 
            this.dtp_partiNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_partiNascimento.Location = new System.Drawing.Point(556, 117);
            this.dtp_partiNascimento.Name = "dtp_partiNascimento";
            this.dtp_partiNascimento.Size = new System.Drawing.Size(107, 20);
            this.dtp_partiNascimento.TabIndex = 13;
            // 
            // Txt_partiEmail
            // 
            this.Txt_partiEmail.Location = new System.Drawing.Point(485, 91);
            this.Txt_partiEmail.Name = "Txt_partiEmail";
            this.Txt_partiEmail.Size = new System.Drawing.Size(178, 20);
            this.Txt_partiEmail.TabIndex = 14;
            // 
            // Txt_partiTelefone
            // 
            this.Txt_partiTelefone.Location = new System.Drawing.Point(280, 91);
            this.Txt_partiTelefone.MaxLength = 11;
            this.Txt_partiTelefone.Name = "Txt_partiTelefone";
            this.Txt_partiTelefone.Size = new System.Drawing.Size(121, 20);
            this.Txt_partiTelefone.TabIndex = 15;
            // 
            // Cb_partiEscolaridade
            // 
            this.Cb_partiEscolaridade.FormattingEnabled = true;
            this.Cb_partiEscolaridade.Location = new System.Drawing.Point(280, 116);
            this.Cb_partiEscolaridade.Name = "Cb_partiEscolaridade";
            this.Cb_partiEscolaridade.Size = new System.Drawing.Size(121, 21);
            this.Cb_partiEscolaridade.TabIndex = 16;
            // 
            // Btn_partiNovo
            // 
            this.Btn_partiNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_partiNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_partiNovo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_partiNovo.Image = global::Sistema_Tecweek.Properties.Resources.novo;
            this.Btn_partiNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_partiNovo.Location = new System.Drawing.Point(4, 4);
            this.Btn_partiNovo.Name = "Btn_partiNovo";
            this.Btn_partiNovo.Size = new System.Drawing.Size(70, 60);
            this.Btn_partiNovo.TabIndex = 0;
            this.Btn_partiNovo.Text = "Novo";
            this.Btn_partiNovo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_partiNovo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_partiExcluir);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_partiEditar);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_partiNovo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Txt_partiPesquisar);
            this.splitContainer1.Size = new System.Drawing.Size(651, 67);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // Btn_partiEditar
            // 
            this.Btn_partiEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_partiEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_partiEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_partiEditar.Image = global::Sistema_Tecweek.Properties.Resources.Editar;
            this.Btn_partiEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_partiEditar.Location = new System.Drawing.Point(80, 4);
            this.Btn_partiEditar.Name = "Btn_partiEditar";
            this.Btn_partiEditar.Size = new System.Drawing.Size(70, 60);
            this.Btn_partiEditar.TabIndex = 1;
            this.Btn_partiEditar.Text = "Editar";
            this.Btn_partiEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_partiEditar.UseVisualStyleBackColor = true;
            // 
            // Btn_partiExcluir
            // 
            this.Btn_partiExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_partiExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_partiExcluir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_partiExcluir.Image = global::Sistema_Tecweek.Properties.Resources.Excluir;
            this.Btn_partiExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_partiExcluir.Location = new System.Drawing.Point(156, 4);
            this.Btn_partiExcluir.Name = "Btn_partiExcluir";
            this.Btn_partiExcluir.Size = new System.Drawing.Size(70, 60);
            this.Btn_partiExcluir.TabIndex = 2;
            this.Btn_partiExcluir.Text = "Excluir";
            this.Btn_partiExcluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_partiExcluir.UseVisualStyleBackColor = true;
            // 
            // Btn_partiGravar
            // 
            this.Btn_partiGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_partiGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_partiGravar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_partiGravar.Image = global::Sistema_Tecweek.Properties.Resources.Gravar;
            this.Btn_partiGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_partiGravar.Location = new System.Drawing.Point(419, 3);
            this.Btn_partiGravar.Name = "Btn_partiGravar";
            this.Btn_partiGravar.Size = new System.Drawing.Size(105, 38);
            this.Btn_partiGravar.TabIndex = 0;
            this.Btn_partiGravar.Text = "Gravar";
            this.Btn_partiGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_partiGravar.UseVisualStyleBackColor = true;
            // 
            // Btn_partiCancelar
            // 
            this.Btn_partiCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_partiCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_partiCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_partiCancelar.Image = global::Sistema_Tecweek.Properties.Resources.Cancelar;
            this.Btn_partiCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_partiCancelar.Location = new System.Drawing.Point(530, 3);
            this.Btn_partiCancelar.Name = "Btn_partiCancelar";
            this.Btn_partiCancelar.Size = new System.Drawing.Size(118, 38);
            this.Btn_partiCancelar.TabIndex = 1;
            this.Btn_partiCancelar.Text = "Cancelar";
            this.Btn_partiCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_partiCancelar.UseVisualStyleBackColor = true;
            // 
            // Txt_partiPesquisar
            // 
            this.Txt_partiPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_partiPesquisar.ForeColor = System.Drawing.Color.Silver;
            this.Txt_partiPesquisar.Location = new System.Drawing.Point(240, 44);
            this.Txt_partiPesquisar.Name = "Txt_partiPesquisar";
            this.Txt_partiPesquisar.Size = new System.Drawing.Size(172, 20);
            this.Txt_partiPesquisar.TabIndex = 0;
            this.Txt_partiPesquisar.Text = "Digite para pesquisar...";
            this.Txt_partiPesquisar.Enter += new System.EventHandler(this.Txt_partiPesquisar_Enter);
            this.Txt_partiPesquisar.Leave += new System.EventHandler(this.Txt_partiPesquisar_Leave);
            // 
            // frm_cadastroParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 381);
            this.Controls.Add(this.Cb_partiEscolaridade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_partiTelefone);
            this.Controls.Add(this.Txt_partiEmail);
            this.Controls.Add(this.dtp_partiNascimento);
            this.Controls.Add(this.Txt_partiCPF);
            this.Controls.Add(this.Txt_partiNome);
            this.Controls.Add(this.Txt_partiCod);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_cadastroParticipantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Participantes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_partiCod;
        private System.Windows.Forms.TextBox Txt_partiNome;
        private System.Windows.Forms.TextBox Txt_partiCPF;
        private System.Windows.Forms.DateTimePicker dtp_partiNascimento;
        private System.Windows.Forms.TextBox Txt_partiEmail;
        private System.Windows.Forms.TextBox Txt_partiTelefone;
        private System.Windows.Forms.ComboBox Cb_partiEscolaridade;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Btn_partiExcluir;
        private System.Windows.Forms.Button Btn_partiEditar;
        private System.Windows.Forms.Button Btn_partiNovo;
        private System.Windows.Forms.Button Btn_partiCancelar;
        private System.Windows.Forms.Button Btn_partiGravar;
        private System.Windows.Forms.TextBox Txt_partiPesquisar;
    }
}