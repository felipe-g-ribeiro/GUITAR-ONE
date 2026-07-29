namespace GUITAR_ONE {
    partial class MenuPrincipal {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new BootstrapBtn();
            this.bootstrapBtn4 = new BootstrapBtn();
            this.btnLuthieria = new BootstrapBtn();
            this.bootstrapBtn2 = new BootstrapBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUITAR_ONE.Properties.Resources.logo0001;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BorderRadius = 8;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(12, 535);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(318, 46);
            this.btnFechar.Style = BootstrapBtn.BootstrapStyle.Info;
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // bootstrapBtn4
            // 
            this.bootstrapBtn4.BorderRadius = 8;
            this.bootstrapBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn4.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn4.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn4.Location = new System.Drawing.Point(12, 368);
            this.bootstrapBtn4.Name = "bootstrapBtn4";
            this.bootstrapBtn4.Size = new System.Drawing.Size(318, 81);
            this.bootstrapBtn4.Style = BootstrapBtn.BootstrapStyle.Primary;
            this.bootstrapBtn4.TabIndex = 4;
            this.bootstrapBtn4.Text = "Equipamentos";
            this.bootstrapBtn4.UseVisualStyleBackColor = true;
            this.bootstrapBtn4.Click += new System.EventHandler(this.bootstrapBtn4_Click);
            // 
            // btnLuthieria
            // 
            this.btnLuthieria.BorderRadius = 8;
            this.btnLuthieria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuthieria.FlatAppearance.BorderSize = 0;
            this.btnLuthieria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuthieria.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnLuthieria.ForeColor = System.Drawing.Color.White;
            this.btnLuthieria.Location = new System.Drawing.Point(12, 281);
            this.btnLuthieria.Name = "btnLuthieria";
            this.btnLuthieria.Size = new System.Drawing.Size(318, 81);
            this.btnLuthieria.Style = BootstrapBtn.BootstrapStyle.Primary;
            this.btnLuthieria.TabIndex = 3;
            this.btnLuthieria.Text = "Gestão";
            this.btnLuthieria.UseVisualStyleBackColor = true;
            this.btnLuthieria.Click += new System.EventHandler(this.btnLuthieria_Click);
            // 
            // bootstrapBtn2
            // 
            this.bootstrapBtn2.BorderRadius = 8;
            this.bootstrapBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn2.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn2.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn2.Location = new System.Drawing.Point(12, 194);
            this.bootstrapBtn2.Name = "bootstrapBtn2";
            this.bootstrapBtn2.Size = new System.Drawing.Size(318, 81);
            this.bootstrapBtn2.Style = BootstrapBtn.BootstrapStyle.Primary;
            this.bootstrapBtn2.TabIndex = 2;
            this.bootstrapBtn2.Text = "Aulas";
            this.bootstrapBtn2.UseVisualStyleBackColor = true;
            this.bootstrapBtn2.Click += new System.EventHandler(this.bootstrapBtn2_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUITAR_ONE.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(342, 593);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.bootstrapBtn4);
            this.Controls.Add(this.btnLuthieria);
            this.Controls.Add(this.bootstrapBtn2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private BootstrapBtn bootstrapBtn2;
        private BootstrapBtn btnLuthieria;
        private BootstrapBtn bootstrapBtn4;
        private BootstrapBtn btnFechar;
    }
}