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

            foreach (Guitar_HubDataSet.LoginRow linha in guitar_HubDataSet.Login) {
                if (linha.Username == user && linha.Senha == pass) {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Login ou senha incorretos!", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {

            Cadastro cad = new Cadastro();
            cad.Show();
            this.Hide();

        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.guitar_HubDataSet.Login);

        }
    }
    
}
