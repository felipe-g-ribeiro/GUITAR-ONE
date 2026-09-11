namespace GUITAR_ONE {
    partial class Alunos {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guitar_HubDataSet = new GUITAR_ONE.Guitar_HubDataSet();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.AlunosTableAdapter();
            this.tableAdapterManager = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager();
            this.pagamentosTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.PagamentosTableAdapter();
            this.alunosDataGridView = new System.Windows.Forms.DataGridView();
            this.pagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAluno = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.bootstrapBtn7 = new BootstrapBtn();
            this.bootstrapBtn6 = new BootstrapBtn();
            this.bootstrapBtn4 = new BootstrapBtn();
            this.bootstrapBtn5 = new BootstrapBtn();
            this.bootstrapBtn3 = new BootstrapBtn();
            this.bootstrapBtn2 = new BootstrapBtn();
            this.bootstrapBtn1 = new BootstrapBtn();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guitar_HubDataSet
            // 
            this.guitar_HubDataSet.DataSetName = "Guitar_HubDataSet";
            this.guitar_HubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.AulasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PagamentosTableAdapter = this.pagamentosTableAdapter;
            this.tableAdapterManager.PlanosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pagamentosTableAdapter
            // 
            this.pagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // alunosDataGridView
            // 
            this.alunosDataGridView.AllowUserToAddRows = false;
            this.alunosDataGridView.AllowUserToOrderColumns = true;
            this.alunosDataGridView.AutoGenerateColumns = false;
            this.alunosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.alunosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.alunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alunosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.IdAluno});
            this.alunosDataGridView.DataSource = this.alunosBindingSource;
            this.alunosDataGridView.Location = new System.Drawing.Point(12, 89);
            this.alunosDataGridView.Name = "alunosDataGridView";
            this.alunosDataGridView.RowHeadersVisible = false;
            this.alunosDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.alunosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.alunosDataGridView.RowTemplate.Height = 24;
            this.alunosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alunosDataGridView.Size = new System.Drawing.Size(782, 232);
            this.alunosDataGridView.TabIndex = 14;
            this.alunosDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.alunosDataGridView_DataError);
            // 
            // pagamentosBindingSource
            // 
            this.pagamentosBindingSource.DataMember = "Pagamentos";
            this.pagamentosBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUITAR_ONE.Properties.Resources.Alunos;
            this.pictureBox1.Location = new System.Drawing.Point(12, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtAluno
            // 
            this.txtAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno.Location = new System.Drawing.Point(150, 339);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(286, 30);
            this.txtAluno.TabIndex = 17;
            this.txtAluno.Text = "Ricardo";
            this.txtAluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdAluno";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdAluno";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nivel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeAluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Aluno";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // IdAluno
            // 
            this.IdAluno.DataPropertyName = "IdAluno";
            this.IdAluno.DataSource = this.pagamentosBindingSource;
            this.IdAluno.DisplayMember = "Status";
            this.IdAluno.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdAluno.HeaderText = "IdAluno";
            this.IdAluno.MinimumWidth = 6;
            this.IdAluno.Name = "IdAluno";
            this.IdAluno.ReadOnly = true;
            this.IdAluno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdAluno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdAluno.ValueMember = "IdAluno";
            this.IdAluno.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Telefone:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(149, 376);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(286, 30);
            this.txtTel.TabIndex = 20;
            this.txtTel.Text = "910000002";
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bootstrapBtn7
            // 
            this.bootstrapBtn7.BorderRadius = 8;
            this.bootstrapBtn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn7.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn7.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn7.Location = new System.Drawing.Point(637, 336);
            this.bootstrapBtn7.Name = "bootstrapBtn7";
            this.bootstrapBtn7.Size = new System.Drawing.Size(132, 70);
            this.bootstrapBtn7.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn7.TabIndex = 22;
            this.bootstrapBtn7.Text = "Limpar";
            this.bootstrapBtn7.UseVisualStyleBackColor = true;
            this.bootstrapBtn7.Click += new System.EventHandler(this.bootstrapBtn7_Click);
            // 
            // bootstrapBtn6
            // 
            this.bootstrapBtn6.BorderRadius = 8;
            this.bootstrapBtn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn6.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn6.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn6.Location = new System.Drawing.Point(452, 373);
            this.bootstrapBtn6.Name = "bootstrapBtn6";
            this.bootstrapBtn6.Size = new System.Drawing.Size(178, 33);
            this.bootstrapBtn6.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn6.TabIndex = 19;
            this.bootstrapBtn6.Text = "Pesquisar";
            this.bootstrapBtn6.UseVisualStyleBackColor = true;
            this.bootstrapBtn6.Click += new System.EventHandler(this.bootstrapBtn6_Click);
            // 
            // bootstrapBtn4
            // 
            this.bootstrapBtn4.BorderRadius = 8;
            this.bootstrapBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn4.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn4.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn4.Location = new System.Drawing.Point(453, 336);
            this.bootstrapBtn4.Name = "bootstrapBtn4";
            this.bootstrapBtn4.Size = new System.Drawing.Size(178, 33);
            this.bootstrapBtn4.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn4.TabIndex = 16;
            this.bootstrapBtn4.Text = "Pesquisar";
            this.bootstrapBtn4.UseVisualStyleBackColor = true;
            this.bootstrapBtn4.Click += new System.EventHandler(this.bootstrapBtn4_Click);
            // 
            // bootstrapBtn5
            // 
            this.bootstrapBtn5.BorderRadius = 8;
            this.bootstrapBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn5.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn5.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn5.Location = new System.Drawing.Point(637, 485);
            this.bootstrapBtn5.Name = "bootstrapBtn5";
            this.bootstrapBtn5.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn5.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn5.TabIndex = 13;
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
            this.bootstrapBtn3.Location = new System.Drawing.Point(312, 485);
            this.bootstrapBtn3.Name = "bootstrapBtn3";
            this.bootstrapBtn3.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn3.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn3.TabIndex = 12;
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
            this.bootstrapBtn2.Location = new System.Drawing.Point(174, 485);
            this.bootstrapBtn2.Name = "bootstrapBtn2";
            this.bootstrapBtn2.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn2.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn2.TabIndex = 11;
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
            this.bootstrapBtn1.Location = new System.Drawing.Point(36, 484);
            this.bootstrapBtn1.Name = "bootstrapBtn1";
            this.bootstrapBtn1.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn1.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn1.TabIndex = 10;
            this.bootstrapBtn1.Text = "Adicionar";
            this.bootstrapBtn1.UseVisualStyleBackColor = true;
            this.bootstrapBtn1.Click += new System.EventHandler(this.bootstrapBtn1_Click);
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 552);
            this.Controls.Add(this.bootstrapBtn7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.bootstrapBtn6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.bootstrapBtn4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.alunosDataGridView);
            this.Controls.Add(this.bootstrapBtn5);
            this.Controls.Add(this.bootstrapBtn3);
            this.Controls.Add(this.bootstrapBtn2);
            this.Controls.Add(this.bootstrapBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BootstrapBtn bootstrapBtn5;
        private BootstrapBtn bootstrapBtn3;
        private BootstrapBtn bootstrapBtn2;
        private BootstrapBtn bootstrapBtn1;
        private Guitar_HubDataSet guitar_HubDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private Guitar_HubDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private Guitar_HubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView alunosDataGridView;
        private System.Windows.Forms.BindingSource pagamentosBindingSource;
        private Guitar_HubDataSetTableAdapters.PagamentosTableAdapter pagamentosTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BootstrapBtn bootstrapBtn4;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private BootstrapBtn bootstrapBtn6;
        private BootstrapBtn bootstrapBtn7;
    }
}