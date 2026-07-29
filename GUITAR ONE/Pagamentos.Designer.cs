namespace GUITAR_ONE {
    partial class Pagamentos {
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
            System.Windows.Forms.Label dataPagamentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label statusLabel;
            this.guitar_HubDataSet = new GUITAR_ONE.Guitar_HubDataSet();
            this.pagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentosTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.PagamentosTableAdapter();
            this.tableAdapterManager = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager();
            this.pagamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.AlunosTableAdapter();
            this.planosTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.PlanosTableAdapter();
            this.dataPagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bootstrapBtn5 = new BootstrapBtn();
            this.bootstrapBtn3 = new BootstrapBtn();
            this.bootstrapBtn2 = new BootstrapBtn();
            this.bootstrapBtn1 = new BootstrapBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.bootstrapBtn4 = new BootstrapBtn();
            dataPagamentoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPagamentoLabel
            // 
            dataPagamentoLabel.AutoSize = true;
            dataPagamentoLabel.Location = new System.Drawing.Point(25, 470);
            dataPagamentoLabel.Name = "dataPagamentoLabel";
            dataPagamentoLabel.Size = new System.Drawing.Size(112, 16);
            dataPagamentoLabel.TabIndex = 22;
            dataPagamentoLabel.Text = "Data Pagamento:";
            // 
            // guitar_HubDataSet
            // 
            this.guitar_HubDataSet.DataSetName = "Guitar_HubDataSet";
            this.guitar_HubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagamentosBindingSource
            // 
            this.pagamentosBindingSource.DataMember = "Pagamentos";
            this.pagamentosBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // pagamentosTableAdapter
            // 
            this.pagamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.AulasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PagamentosTableAdapter = this.pagamentosTableAdapter;
            this.tableAdapterManager.PlanosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pagamentosDataGridView
            // 
            this.pagamentosDataGridView.AllowUserToAddRows = false;
            this.pagamentosDataGridView.AllowUserToOrderColumns = true;
            this.pagamentosDataGridView.AutoGenerateColumns = false;
            this.pagamentosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.pagamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagamentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.pagamentosDataGridView.DataSource = this.pagamentosBindingSource;
            this.pagamentosDataGridView.Location = new System.Drawing.Point(12, 85);
            this.pagamentosDataGridView.Name = "pagamentosDataGridView";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pagamentosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.pagamentosDataGridView.RowHeadersVisible = false;
            this.pagamentosDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.pagamentosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.pagamentosDataGridView.RowTemplate.Height = 24;
            this.pagamentosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pagamentosDataGridView.Size = new System.Drawing.Size(976, 372);
            this.pagamentosDataGridView.TabIndex = 22;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // planosBindingSource
            // 
            this.planosBindingSource.DataMember = "Planos";
            this.planosBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // planosTableAdapter
            // 
            this.planosTableAdapter.ClearBeforeFill = true;
            // 
            // dataPagamentoDateTimePicker
            // 
            this.dataPagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagamentosBindingSource, "DataPagamento", true));
            this.dataPagamentoDateTimePicker.Location = new System.Drawing.Point(143, 466);
            this.dataPagamentoDateTimePicker.Name = "dataPagamentoDateTimePicker";
            this.dataPagamentoDateTimePicker.Size = new System.Drawing.Size(338, 22);
            this.dataPagamentoDateTimePicker.TabIndex = 23;
            // 
            // bootstrapBtn5
            // 
            this.bootstrapBtn5.BorderRadius = 8;
            this.bootstrapBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn5.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn5.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn5.Location = new System.Drawing.Point(844, 532);
            this.bootstrapBtn5.Name = "bootstrapBtn5";
            this.bootstrapBtn5.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn5.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn5.TabIndex = 21;
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
            this.bootstrapBtn3.Location = new System.Drawing.Point(304, 532);
            this.bootstrapBtn3.Name = "bootstrapBtn3";
            this.bootstrapBtn3.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn3.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn3.TabIndex = 20;
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
            this.bootstrapBtn2.Location = new System.Drawing.Point(166, 532);
            this.bootstrapBtn2.Name = "bootstrapBtn2";
            this.bootstrapBtn2.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn2.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn2.TabIndex = 19;
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
            this.bootstrapBtn1.Location = new System.Drawing.Point(28, 531);
            this.bootstrapBtn1.Name = "bootstrapBtn1";
            this.bootstrapBtn1.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn1.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn1.TabIndex = 18;
            this.bootstrapBtn1.Text = "Adicionar";
            this.bootstrapBtn1.UseVisualStyleBackColor = true;
            this.bootstrapBtn1.Click += new System.EventHandler(this.bootstrapBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gestão Pagamentos";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdAluno";
            this.dataGridViewTextBoxColumn6.DataSource = this.alunosBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "NomeAluno";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome do Aluno";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IdAluno";
            this.dataGridViewTextBoxColumn6.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TipoPagamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Pagamento";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataPagamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data do Pagamento";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdPlano";
            this.dataGridViewTextBoxColumn7.DataSource = this.planosBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "NomePlano";
            this.dataGridViewTextBoxColumn7.HeaderText = "Plano";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "IdPlano";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(583, 472);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 24;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentosBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pago",
            "Pendente"});
            this.statusComboBox.Location = new System.Drawing.Point(636, 469);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusComboBox.TabIndex = 25;
            // 
            // bootstrapBtn4
            // 
            this.bootstrapBtn4.BorderRadius = 8;
            this.bootstrapBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn4.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn4.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn4.Location = new System.Drawing.Point(763, 469);
            this.bootstrapBtn4.Name = "bootstrapBtn4";
            this.bootstrapBtn4.Size = new System.Drawing.Size(132, 24);
            this.bootstrapBtn4.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn4.TabIndex = 26;
            this.bootstrapBtn4.Text = "Pesquisar";
            this.bootstrapBtn4.UseVisualStyleBackColor = true;
            this.bootstrapBtn4.Click += new System.EventHandler(this.bootstrapBtn4_Click);
            // 
            // Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 600);
            this.Controls.Add(this.bootstrapBtn4);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(dataPagamentoLabel);
            this.Controls.Add(this.dataPagamentoDateTimePicker);
            this.Controls.Add(this.pagamentosDataGridView);
            this.Controls.Add(this.bootstrapBtn5);
            this.Controls.Add(this.bootstrapBtn3);
            this.Controls.Add(this.bootstrapBtn2);
            this.Controls.Add(this.bootstrapBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            this.Load += new System.EventHandler(this.Pagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BootstrapBtn bootstrapBtn5;
        private BootstrapBtn bootstrapBtn3;
        private BootstrapBtn bootstrapBtn2;
        private BootstrapBtn bootstrapBtn1;
        private Guitar_HubDataSet guitar_HubDataSet;
        private System.Windows.Forms.BindingSource pagamentosBindingSource;
        private Guitar_HubDataSetTableAdapters.PagamentosTableAdapter pagamentosTableAdapter;
        private Guitar_HubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pagamentosDataGridView;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private Guitar_HubDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.BindingSource planosBindingSource;
        private Guitar_HubDataSetTableAdapters.PlanosTableAdapter planosTableAdapter;
        private System.Windows.Forms.DateTimePicker dataPagamentoDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox statusComboBox;
        private BootstrapBtn bootstrapBtn4;
    }
}