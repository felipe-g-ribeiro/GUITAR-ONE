namespace GUITAR_ONE {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bootstrapBtn1 = new BootstrapBtn();
            this.label1 = new System.Windows.Forms.Label();
            this.bootstrapBtn2 = new BootstrapBtn();
            this.guitar_HubDataSet = new GUITAR_ONE.Guitar_HubDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new GUITAR_ONE.Guitar_HubDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(138, 352);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 27);
            this.txtNome.TabIndex = 5;
            this.txtNome.Text = "admin";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(138, 408);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 27);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Text = "1234";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUITAR_ONE.Properties.Resources.logo0001;
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bootstrapBtn1
            // 
            this.bootstrapBtn1.BorderRadius = 8;
            this.bootstrapBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn1.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn1.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn1.Location = new System.Drawing.Point(48, 460);
            this.bootstrapBtn1.Name = "bootstrapBtn1";
            this.bootstrapBtn1.Size = new System.Drawing.Size(260, 68);
            this.bootstrapBtn1.Style = BootstrapBtn.BootstrapStyle.Primary;
            this.bootstrapBtn1.TabIndex = 8;
            this.bootstrapBtn1.Text = "Entrar";
            this.bootstrapBtn1.UseVisualStyleBackColor = true;
            this.bootstrapBtn1.Click += new System.EventHandler(this.bootstrapBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Não tem Cadastro Clique:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bootstrapBtn2
            // 
            this.bootstrapBtn2.BorderRadius = 8;
            this.bootstrapBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn2.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn2.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn2.Location = new System.Drawing.Point(218, 578);
            this.bootstrapBtn2.Name = "bootstrapBtn2";
            this.bootstrapBtn2.Size = new System.Drawing.Size(90, 39);
            this.bootstrapBtn2.Style = BootstrapBtn.BootstrapStyle.Primary;
            this.bootstrapBtn2.TabIndex = 10;
            this.bootstrapBtn2.Text = "Cadastrar";
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUITAR_ONE.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(360, 640);
            this.Controls.Add(this.bootstrapBtn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bootstrapBtn1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guitar_HubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BootstrapBtn bootstrapBtn1;
        private System.Windows.Forms.Label label1;
        private BootstrapBtn bootstrapBtn2;
        private Guitar_HubDataSet guitar_HubDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Guitar_HubDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private Guitar_HubDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

