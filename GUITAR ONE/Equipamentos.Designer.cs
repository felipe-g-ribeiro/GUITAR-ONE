namespace GUITAR_ONE {
    partial class Equipamentos {
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
            this.bootstrapBtn1 = new BootstrapBtn();
            this.bootstrapBtn5 = new BootstrapBtn();
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
            this.bootstrapBtn1.Location = new System.Drawing.Point(12, 232);
            this.bootstrapBtn1.Name = "bootstrapBtn1";
            this.bootstrapBtn1.Size = new System.Drawing.Size(318, 40);
            this.bootstrapBtn1.Style = BootstrapBtn.BootstrapStyle.Primary;
            this.bootstrapBtn1.TabIndex = 1;
            this.bootstrapBtn1.Text = "Guitarras";
            this.bootstrapBtn1.UseVisualStyleBackColor = true;
            this.bootstrapBtn1.Click += new System.EventHandler(this.bootstrapBtn1_Click);
            // 
            // bootstrapBtn5
            // 
            this.bootstrapBtn5.BorderRadius = 8;
            this.bootstrapBtn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapBtn5.FlatAppearance.BorderSize = 0;
            this.bootstrapBtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootstrapBtn5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.bootstrapBtn5.ForeColor = System.Drawing.Color.White;
            this.bootstrapBtn5.Location = new System.Drawing.Point(12, 517);
            this.bootstrapBtn5.Name = "bootstrapBtn5";
            this.bootstrapBtn5.Size = new System.Drawing.Size(318, 47);
            this.bootstrapBtn5.Style = BootstrapBtn.BootstrapStyle.Info;
            this.bootstrapBtn5.TabIndex = 10;
            this.bootstrapBtn5.Text = "Voltar";
            this.bootstrapBtn5.UseVisualStyleBackColor = true;
            this.bootstrapBtn5.Click += new System.EventHandler(this.bootstrapBtn5_Click);
            // 
            // Equipamentos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GUITAR_ONE.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 593);
            this.Controls.Add(this.bootstrapBtn5);
            this.Controls.Add(this.bootstrapBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipamentos";
            this.Load += new System.EventHandler(this.Equipamentos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BootstrapBtn bootstrapBtn1;
        private BootstrapBtn bootstrapBtn5;
    }
}