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
    public partial class Alunos : Form {
        public Alunos() {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }

        private void Alunos_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Pagamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentosTableAdapter.Fill(this.guitar_HubDataSet.Pagamentos);
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.guitar_HubDataSet.Alunos);

        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {
            try {
                alunosBindingSource.AddNew();
            }
            catch {
                MessageBox.Show("Não é possível adicionar um novo aluno");
            }
        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {

            alunosBindingSource.RemoveCurrent();
        }

        private void bootstrapBtn3_Click(object sender, EventArgs e) {

            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);
        }

        private void bootstrapBtn5_Click(object sender, EventArgs e) {

            Luthieria menu = new Luthieria();
            menu.Show();
            this.Hide();
        }

        private void alunosDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            try { } catch { }
        }
    }
}
