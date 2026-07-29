namespace GUITAR_ONE {
    partial class Professores {
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
            this.bootstrapBtn5 = new BootstrapBtn();
            this.bootstrapBtn3 = new BootstrapBtn();
            this.bootstrapBtn2 = new BootstrapBtn();
            this.bootstrapBtn1 = new BootstrapBtn();
            this.guitar_HubDataSet = new GUITAR_ONE.Guitar_HubDataSet();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.ProfessoresTableAdapter();
            this.tableAdapterManager = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager();
            this.professoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bootstrapBtn5
            // 
            this.bootstrapBtn5.BorderRadius = 8;
            this.bootstrapBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn5.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn5.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn5.Location = new System.Drawing.Point(624, 495);
            this.bootstrapBtn5.Name = "bootstrapBtn5";
            this.bootstrapBtn5.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn5.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn5.TabIndex = 17;
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
            this.bootstrapBtn3.Location = new System.Drawing.Point(299, 495);
            this.bootstrapBtn3.Name = "bootstrapBtn3";
            this.bootstrapBtn3.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn3.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn3.TabIndex = 16;
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
            this.bootstrapBtn2.Location = new System.Drawing.Point(161, 495);
            this.bootstrapBtn2.Name = "bootstrapBtn2";
            this.bootstrapBtn2.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn2.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn2.TabIndex = 15;
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
            this.bootstrapBtn1.Location = new System.Drawing.Point(23, 494);
            this.bootstrapBtn1.Name = "bootstrapBtn1";
            this.bootstrapBtn1.Size = new System.Drawing.Size(132, 47);
            this.bootstrapBtn1.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn1.TabIndex = 14;
            this.bootstrapBtn1.Text = "Adicionar";
            this.bootstrapBtn1.UseVisualStyleBackColor = true;
            this.bootstrapBtn1.Click += new System.EventHandler(this.bootstrapBtn1_Click);
            // 
            // guitar_HubDataSet
            // 
            this.guitar_HubDataSet.DataSetName = "Guitar_HubDataSet";
            this.guitar_HubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.AulasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PagamentosTableAdapter = null;
            this.tableAdapterManager.PlanosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professoresDataGridView
            // 
            this.professoresDataGridView.AllowUserToAddRows = false;
            this.professoresDataGridView.AllowUserToOrderColumns = true;
            this.professoresDataGridView.AutoGenerateColumns = false;
            this.professoresDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.professoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.professoresDataGridView.DataSource = this.professoresBindingSource;
            this.professoresDataGridView.Location = new System.Drawing.Point(12, 109);
            this.professoresDataGridView.Name = "professoresDataGridView";
            this.professoresDataGridView.RowHeadersVisible = false;
            this.professoresDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.professoresDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.professoresDataGridView.RowTemplate.Height = 24;
            this.professoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.professoresDataGridView.Size = new System.Drawing.Size(758, 309);
            this.professoresDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeProfessor";
            this.dataGridViewTextBoxColumn2.FillWeight = 79.23351F;
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeProfessor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Instrumento";
            this.dataGridViewTextBoxColumn3.FillWeight = 79.23351F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Instrumento";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.FillWeight = 79.23351F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gestão Professores";
            // 
            // Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.professoresDataGridView);
            this.Controls.Add(this.bootstrapBtn5);
            this.Controls.Add(this.bootstrapBtn3);
            this.Controls.Add(this.bootstrapBtn2);
            this.Controls.Add(this.bootstrapBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professores";
            this.Load += new System.EventHandler(this.Professores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BootstrapBtn bootstrapBtn5;
        private BootstrapBtn bootstrapBtn3;
        private BootstrapBtn bootstrapBtn2;
        private BootstrapBtn bootstrapBtn1;
        private Guitar_HubDataSet guitar_HubDataSet;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private Guitar_HubDataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private Guitar_HubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView professoresDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}