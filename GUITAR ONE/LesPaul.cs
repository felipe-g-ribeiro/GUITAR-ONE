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
    public partial class LesPaul : Form {
        public LesPaul() {
            InitializeComponent();
        }

        private void Fechar_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

            

        }

        private void LesPaul_Load(object sender, EventArgs e) {
            
            label1.Text = "Gibson Les Paul:\nmodelo custom clássico.\nAcabamento preto \nhardware dourado.";


        }

        private void label1_Click(object sender, EventArgs e) {
            
            
           

        }
    }
}
