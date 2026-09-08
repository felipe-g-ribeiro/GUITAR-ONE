using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITAR_ONE {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Login'. Você pode movê-la ou removê-la conforme necessário.
            this.loginTableAdapter.Fill(this.guitar_HubDataSet.Login);

        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {
            
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e) {

        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {

            string user = txtNome.Text;
            string pass = txtSenha.Text;

            // Regex username
            Regex regexUser = new Regex(@"^[A-Za-z]+$");

            // Regex 4 números
            Regex regexPass = new Regex(@"^\d{4}$");

            if (!regexUser.IsMatch(user)) {
                MessageBox.Show("O nome deve conter apenas letras (A–Z ou a–z).");
                return;
            }

            if (!regexPass.IsMatch(pass)) {
                MessageBox.Show("A senha deve conter exatamente 4 números.");
                return;
            }

            // grava no banco de dados
            this.loginTableAdapter.Insert(user, pass);

            MessageBox.Show("Cadastro realizado com sucesso!");

            // volta para o login
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
