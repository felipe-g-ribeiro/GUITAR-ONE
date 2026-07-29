namespace GUITAR_ONE {
    partial class Aulas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label conteudoLabel;
            System.Windows.Forms.Label duraçãoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guitar_HubDataSet = new GUITAR_ONE.Guitar_HubDataSet();
            this.salasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aulasTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.AulasTableAdapter();
            this.tableAdapterManager = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager();
            this.alunosTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.AlunosTableAdapter();
            this.pagamentosTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.PagamentosTableAdapter();
            this.professoresTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.ProfessoresTableAdapter();
            this.salasTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.SalasTableAdapter();
            this.aulasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bootstrapBtn5 = new BootstrapBtn();
            this.bootstrapBtn3 = new BootstrapBtn();
            this.bootstrapBtn2 = new BootstrapBtn();
            this.bootstrapBtn1 = new BootstrapBtn();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.conteudoTextBox = new System.Windows.Forms.TextBox();
            this.duraçãoTextBox = new System.Windows.Forms.TextBox();
            this.txtAulasPesq = new System.Windows.Forms.TextBox();
            this.bootstrapBtn4 = new BootstrapBtn();
            dataLabel = new System.Windows.Forms.Label();
            conteudoLabel = new System.Windows.Forms.Label();
            duraçãoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(33, 484);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(55, 20);
            dataLabel.TabIndex = 16;
            dataLabel.Text = "Data:";
            // 
            // conteudoLabel
            // 
            conteudoLabel.AutoSize = true;
            conteudoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            conteudoLabel.Location = new System.Drawing.Point(33, 432);
            conteudoLabel.Name = "conteudoLabel";
            conteudoLabel.Size = new System.Drawing.Size(94, 20);
            conteudoLabel.TabIndex = 17;
            conteudoLabel.Text = "Conteudo:";
            // 
            // duraçãoLabel
            // 
            duraçãoLabel.AutoSize = true;
            duraçãoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duraçãoLabel.Location = new System.Drawing.Point(517, 429);
            duraçãoLabel.Name = "duraçãoLabel";
            duraçãoLabel.Size = new System.Drawing.Size(86, 20);
            duraçãoLabel.TabIndex = 18;
            duraçãoLabel.Text = "Duração:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(33, 528);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 18);
            label1.TabIndex = 22;
            label1.Text = "Agenda Dia:";
            // 
            // aulasBindingSource
            // 
            this.aulasBindingSource.DataMember = "Aulas";
            this.aulasBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // guitar_HubDataSet
            // 
            this.guitar_HubDataSet.DataSetName = "Guitar_HubDataSet";
            this.guitar_HubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salasBindingSource
            // 
            this.salasBindingSource.DataMember = "Salas";
            this.salasBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // pagamentosBindingSource
            // 
            this.pagamentosBindingSource.DataMember = "Pagamentos";
            this.pagamentosBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 315);
            this.label5.MaximumSize = new System.Drawing.Size(0, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 2);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 459);
            this.label6.MaximumSize = new System.Drawing.Size(0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 2);
            this.label6.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUITAR_ONE.Properties.Resources.Aulas;
            this.pictureBox1.Location = new System.Drawing.Point(145, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // aulasTableAdapter
            // 
            this.aulasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.AulasTableAdapter = this.aulasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PagamentosTableAdapter = this.pagamentosTableAdapter;
            this.tableAdapterManager.PlanosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.SalasTableAdapter = this.salasTableAdapter;
            this.tableAdapterManager.UpdateOrder = GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentosTableAdapter
            // 
            this.pagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // salasTableAdapter
            // 
            this.salasTableAdapter.ClearBeforeFill = true;
            // 
            // aulasDataGridView
            // 
            this.aulasDataGridView.AllowUserToAddRows = false;
            this.aulasDataGridView.AllowUserToOrderColumns = true;
            this.aulasDataGridView.AutoGenerateColumns = false;
            this.aulasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aulasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aulasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.aulasDataGridView.DataSource = this.aulasBindingSource;
            this.aulasDataGridView.Location = new System.Drawing.Point(18, 115);
            this.aulasDataGridView.Name = "aulasDataGridView";
            this.aulasDataGridView.RowHeadersVisible = false;
            this.aulasDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            this.aulasDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.aulasDataGridView.RowTemplate.Height = 24;
            this.aulasDataGridView.Size = new System.Drawing.Size(776, 294);
            this.aulasDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdProfessor";
            this.dataGridViewTextBoxColumn6.DataSource = this.professoresBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "NomeProfessor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Professor";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IdProfessor";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdAluno";
            this.dataGridViewTextBoxColumn7.DataSource = this.alunosBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "NomeAluno";
            this.dataGridViewTextBoxColumn7.HeaderText = "Aluno";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "IdAluno";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdSala";
            this.dataGridViewTextBoxColumn8.DataSource = this.salasBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "NomeSala";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sala";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IdSala";
            // 
            // bootstrapBtn5
            // 
            this.bootstrapBtn5.BorderRadius = 8;
            this.bootstrapBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn5.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn5.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn5.Location = new System.Drawing.Point(648, 639);
            this.bootstrapBtn5.Name = "bootstrapBtn5";
            this.bootstrapBtn5.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn5.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn5.TabIndex = 9;
            this.bootstrapBtn5.Text = "Voltar";
            this.bootstrapBtn5.UseVisualStyleBackColor = true;
            this.bootstrapBtn5.Click += new System.EventHandler(this.bootstrapBtn5_Click);
            // 
            // bootstrapBtn3
            // 
            this.bootstrapBtn3.BorderRadius = 8;
            this.bootstrapBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn3.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn3.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn3.Location = new System.Drawing.Point(323, 639);
            this.bootstrapBtn3.Name = "bootstrapBtn3";
            this.bootstrapBtn3.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn3.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn3.TabIndex = 7;
            this.bootstrapBtn3.Text = "Gravar";
            this.bootstrapBtn3.UseVisualStyleBackColor = true;
            this.bootstrapBtn3.Click += new System.EventHandler(this.bootstrapBtn3_Click);
            // 
            // bootstrapBtn2
            // 
            this.bootstrapBtn2.BorderRadius = 8;
            this.bootstrapBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn2.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn2.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn2.Location = new System.Drawing.Point(185, 639);
            this.bootstrapBtn2.Name = "bootstrapBtn2";
            this.bootstrapBtn2.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn2.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn2.TabIndex = 6;
            this.bootstrapBtn2.Text = "Eliminar";
            this.bootstrapBtn2.UseVisualStyleBackColor = true;
            this.bootstrapBtn2.Click += new System.EventHandler(this.bootstrapBtn2_Click);
            // 
            // bootstrapBtn1
            // 
            this.bootstrapBtn1.BorderRadius = 8;
            this.bootstrapBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn1.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn1.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn1.Location = new System.Drawing.Point(47, 638);
            this.bootstrapBtn1.Name = "bootstrapBtn1";
            this.bootstrapBtn1.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn1.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn1.TabIndex = 5;
            this.bootstrapBtn1.Text = "Adicionar";
            this.bootstrapBtn1.UseVisualStyleBackColor = true;
            this.bootstrapBtn1.Click += new System.EventHandler(this.bootstrapBtn1_Click);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aulasBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(155, 484);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(319, 22);
            this.dataDateTimePicker.TabIndex = 17;
            // 
            // conteudoTextBox
            // 
            this.conteudoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Conteudo", true));
            this.conteudoTextBox.Location = new System.Drawing.Point(155, 429);
            this.conteudoTextBox.Multiline = true;
            this.conteudoTextBox.Name = "conteudoTextBox";
            this.conteudoTextBox.Size = new System.Drawing.Size(319, 49);
            this.conteudoTextBox.TabIndex = 18;
            // 
            // duraçãoTextBox
            // 
            this.duraçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulasBindingSource, "Duração", true));
            this.duraçãoTextBox.Location = new System.Drawing.Point(623, 429);
            this.duraçãoTextBox.Name = "duraçãoTextBox";
            this.duraçãoTextBox.Size = new System.Drawing.Size(100, 22);
            this.duraçãoTextBox.TabIndex = 19;
            // 
            // txtAulasPesq
            // 
            this.txtAulasPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAulasPesq.Location = new System.Drawing.Point(155, 523);
            this.txtAulasPesq.Name = "txtAulasPesq";
            this.txtAulasPesq.Size = new System.Drawing.Size(319, 28);
            this.txtAulasPesq.TabIndex = 20;
            // 
            // bootstrapBtn4
            // 
            this.bootstrapBtn4.BorderRadius = 8;
            this.bootstrapBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn4.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bootstrapBtn4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn4.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn4.Location = new System.Drawing.Point(488, 520);
            this.bootstrapBtn4.Name = "bootstrapBtn4";
            this.bootstrapBtn4.Size = new System.Drawing.Size(132, 31);
            this.bootstrapBtn4.Style = BootstrapBtn.BootstrapStyle.Warning;
            this.bootstrapBtn4.TabIndex = 21;
            this.bootstrapBtn4.Text = "Pesquisar";
            this.bootstrapBtn4.UseVisualStyleBackColor = true;
            this.bootstrapBtn4.Click += new System.EventHandler(this.bootstrapBtn4_Click);
            // 
            // Aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(816, 707);
            this.Controls.Add(label1);
            this.Controls.Add(this.bootstrapBtn4);
            this.Controls.Add(this.txtAulasPesq);
            this.Controls.Add(duraçãoLabel);
            this.Controls.Add(this.duraçãoTextBox);
            this.Controls.Add(conteudoLabel);
            this.Controls.Add(this.conteudoTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(this.aulasDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bootstrapBtn5);
            this.Controls.Add(this.bootstrapBtn3);
            this.Controls.Add(this.bootstrapBtn2);
            this.Controls.Add(this.bootstrapBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aulas";
            this.Load += new System.EventHandler(this.Aulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BootstrapBtn bootstrapBtn1;
        private BootstrapBtn bootstrapBtn2;
        private BootstrapBtn bootstrapBtn3;
        private BootstrapBtn bootstrapBtn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guitar_HubDataSet guitar_HubDataSet;
        private System.Windows.Forms.BindingSource aulasBindingSource;
        private Guitar_HubDataSetTableAdapters.AulasTableAdapter aulasTableAdapter;
        private Guitar_HubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private Guitar_HubDataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private Guitar_HubDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.BindingSource pagamentosBindingSource;
        private Guitar_HubDataSetTableAdapters.PagamentosTableAdapter pagamentosTableAdapter;
        private System.Windows.Forms.BindingSource salasBindingSource;
        private Guitar_HubDataSetTableAdapters.SalasTableAdapter salasTableAdapter;
        private System.Windows.Forms.DataGridView aulasDataGridView;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox conteudoTextBox;
        private System.Windows.Forms.TextBox duraçãoTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtAulasPesq;
        private BootstrapBtn bootstrapBtn4;
    }
}