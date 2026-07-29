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
    public partial class Luthieria : Form {
        public Luthieria() {
            InitializeComponent();
        }

        private void Luthieria_Load(object sender, EventArgs e) {

        }

        private void bootstrapBtn5_Click(object sender, EventArgs e) {

            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void bootstrapBtn4_Click(object sender, EventArgs e) {

            Alunos alunos = new Alunos();
            alunos.Show();
            this.Hide();
        }

        private void bootstrapBtn3_Click(object sender, EventArgs e) {

            Professores professores = new Professores();
            professores.Show();
            this.Hide();
        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {

            Pagamentos pagamentos = new Pagamentos();
            pagamentos.Show();
            this.Hide();

        }
    }
}
