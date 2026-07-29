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
    public partial class Equipamentos : Form {
        public Equipamentos() {
            InitializeComponent();
        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {
            
            Guitarras guitarras = new Guitarras();
            guitarras.Show();
            this.Hide();
        }

        private void Equipamentos_Load(object sender, EventArgs e) {

        }

        private void bootstrapBtn5_Click(object sender, EventArgs e) {

            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
