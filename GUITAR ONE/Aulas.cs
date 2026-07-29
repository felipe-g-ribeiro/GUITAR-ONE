using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUITAR_ONE {
    public partial class Aulas : Form {
        public Aulas() {
            InitializeComponent();
        }

        private void bootstrapBtn5_Click(object sender, EventArgs e) {


            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void aulasBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.aulasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }

        private void Aulas_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Salas'. Você pode movê-la ou removê-la conforme necessário.
            this.salasTableAdapter.Fill(this.guitar_HubDataSet.Salas);
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Pagamentos'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentosTableAdapter.Fill(this.guitar_HubDataSet.Pagamentos);
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.guitar_HubDataSet.Alunos);
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Professores'. Você pode movê-la ou removê-la conforme necessário.
            this.professoresTableAdapter.Fill(this.guitar_HubDataSet.Professores);
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Aulas'. Você pode movê-la ou removê-la conforme necessário.
            this.aulasTableAdapter.Fill(this.guitar_HubDataSet.Aulas);






        }

        private void bootstrapBtn3_Click(object sender, EventArgs e) {

            this.Validate();
            this.aulasBindingSource.EndEdit();
            try {
                this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);
            }
            catch {

                MessageBox.Show("\"Este professor já tem uma aula marcada nesta data e sala.\",\r\n        \"Conflito de Agendamento\"");

            }
            ;


        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {



            aulasBindingSource.AddNew();



        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {

            aulasBindingSource.RemoveCurrent();
        }

        private void bootstrapBtn4_Click(object sender, EventArgs e) {

            try {

                aulasBindingSource.Filter = "Data = '" + txtAulasPesq.Text + "'";
            }
            catch {
                MessageBox.Show("Data inválida, digite no formato: dd/mm/aaaa");

            }

        }

        private void bootstrapBtn6_Click(object sender, EventArgs e) {

            
        }
    }
}
