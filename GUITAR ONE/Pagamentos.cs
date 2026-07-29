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
    public partial class Pagamentos : Form {
        public Pagamentos() {
            InitializeComponent();
        }

        private void pagamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.pagamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }

        private void Pagamentos_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Planos'. Você pode movê-la ou removê-la conforme necessário.
            this.planosTableAdapter.Fill(this.guitar_HubDataSet.Planos);
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.guitar_HubDataSet.Alunos);
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Pagamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentosTableAdapter.Fill(this.guitar_HubDataSet.Pagamentos);

        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {

            pagamentosBindingSource.AddNew();
        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {

            pagamentosBindingSource.RemoveCurrent();
        }

        private void bootstrapBtn3_Click(object sender, EventArgs e) {

            this.Validate();
            this.pagamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }

        private void bootstrapBtn5_Click(object sender, EventArgs e) {

            Luthieria menu = new Luthieria();
            menu.Show();
            this.Hide();
        }

        private void bootstrapBtn4_Click(object sender, EventArgs e) {           

            string status = statusComboBox.Text; 
            pagamentosBindingSource.Filter = "Status = '" + status + "'";


           


        }
    }
}
