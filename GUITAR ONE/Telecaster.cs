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
    public partial class Telecaster : Form {
        public Telecaster() {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
              
            this.Close();
        }
    }
}
