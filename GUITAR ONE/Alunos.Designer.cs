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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
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
            this.alunosDataGridView.Size = new System.Drawing.Size(782, 369);
            this.alunosDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeAluno";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeAluno";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}