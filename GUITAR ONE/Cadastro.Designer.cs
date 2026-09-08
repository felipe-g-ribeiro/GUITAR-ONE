namespace GUITAR_ONE {
    partial class Cadastro {
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
            this.bootstrapBtn1 = new BootstrapBtn();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bootstrapBtn2 = new BootstrapBtn();
            this.guitar_HubDataSet = new GUITAR_ONE.Guitar_HubDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bootstrapBtn1
            // 
            this.bootstrapBtn1.BorderRadius = 8;
            this.bootstrapBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn1.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn1.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn1.Location = new System.Drawing.Point(22, 159);
            this.bootstrapBtn1.Name = "bootstrapBtn1";
            this.bootstrapBtn1.Size = new System.Drawing.Size(261, 68);
            this.bootstrapBtn1.Style = BootstrapBtn.BootstrapStyle.Primary;
            this.bootstrapBtn1.TabIndex = 13;
            this.bootstrapBtn1.Text = "Cadastrar";
            this.bootstrapBtn1.UseVisualStyleBackColor = true;
            this.bootstrapBtn1.Click += new System.EventHandler(this.bootstrapBtn1_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(165, 76);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(395, 27);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.Text = "1234";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(165, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 27);
            this.txtNome.TabIndex = 11;
            this.txtNome.Text = "admin";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "UserName";
            // 
            // bootstrapBtn2
            // 
            this.bootstrapBtn2.BorderRadius = 8;
            this.bootstrapBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn2.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn2.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn2.Location = new System.Drawing.Point(299, 159);
            this.bootstrapBtn2.Name = "bootstrapBtn2";
            this.bootstrapBtn2.Size = new System.Drawing.Size(261, 68);
            this.bootstrapBtn2.Style = BootstrapBtn.BootstrapStyle.Success;
            this.bootstrapBtn2.TabIndex = 14;
            this.bootstrapBtn2.Text = "Voltar";
            this.bootstrapBtn2.UseVisualStyleBackColor = true;
            this.bootstrapBtn2.Click += new System.EventHandler(this.bootstrapBtn2_Click);
            // 
            // guitar_HubDataSet
            // 
            this.guitar_HubDataSet.DataSetName = "Guitar_HubDataSet";
            this.guitar_HubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.guitar_HubDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.AulasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.PagamentosTableAdapter = null;
            this.tableAdapterManager.PlanosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.SalasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUITAR_ONE.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 257);
            this.Controls.Add(this.bootstrapBtn2);
            this.Controls.Add(this.bootstrapBtn1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BootstrapBtn bootstrapBtn1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BootstrapBtn bootstrapBtn2;
        private Guitar_HubDataSet guitar_HubDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Guitar_HubDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private Guitar_HubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}