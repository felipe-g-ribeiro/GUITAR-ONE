using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITAR_ONE {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {

            string user = txtNome.Text;
            string pass = txtSenha.Text;

            if (user == "admin" && pass == "1234") {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Login ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {

            string user = txtNome.Text;
            string pass = txtSenha.Text;

            if (user == "admin" && pass == "1234") {
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Login ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
