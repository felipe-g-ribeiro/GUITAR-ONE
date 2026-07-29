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
    public partial class Professores : Form {
        public Professores() {
            InitializeComponent();
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }

        private void Professores_Load(object sender, EventArgs e) {
            // TODO: esta linha de código carrega dados na tabela 'guitar_HubDataSet.Professores'. Você pode movê-la ou removê-la conforme necessário.
            this.professoresTableAdapter.Fill(this.guitar_HubDataSet.Professores);

        }

        private void bootstrapBtn5_Click(object sender, EventArgs e) {

            Luthieria menu = new Luthieria();
            menu.Show();
            this.Hide();
        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {

            professoresBindingSource.AddNew();
        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {


            professoresBindingSource.RemoveCurrent();
        }

        private void bootstrapBtn3_Click(object sender, EventArgs e) {

            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guitar_HubDataSet);

        }
    }
}
