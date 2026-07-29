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
    public partial class MenuPrincipal : Form {
        public MenuPrincipal() {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e) {

            Application.Exit();
        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {

            Guitarras guitarras = new Guitarras();
            guitarras.Show();
            this.Hide();
        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {

            Aulas aulas = new Aulas();
            aulas.Show();
            this.Hide();
        }

        private void btnLuthieria_Click(object sender, EventArgs e) {

            Luthieria form = new Luthieria();            
            form.Show();
            this.Hide();
        }

        private void bootstrapBtn4_Click(object sender, EventArgs e) {
            
            Equipamentos form = new Equipamentos();
            form.Show();
            this.Hide();
        }
    }
    
}
