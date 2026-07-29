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
    public partial class Guitarras : Form {
        public Guitarras() {
            InitializeComponent();
        }

        private void Guitarras_Load(object sender, EventArgs e) {

        }

        private void AbrirFormNoPainel(Form form) {
           
            //panel1.Controls.Clear();           
            form.TopLevel = false;                      
            form.Dock = DockStyle.Fill;        
            panel1.Controls.Add(form);         
            form.Show();
            form.BringToFront();
        }


        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void bootstrapBtn2_Click(object sender, EventArgs e) {

            foreach (Control ctrl in panel1.Controls) {
                if (ctrl is LesPaul)
                    return;
            }

            LesPaul lp = new LesPaul();
            AbrirFormNoPainel(lp);
        }

        private void btnVoltar_Click(object sender, EventArgs e) {

            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void bootstrapBtn1_Click(object sender, EventArgs e) {

            foreach (Control ctrl in panel1.Controls) {
                if (ctrl is Telecaster)
                    return; 
            }

            Telecaster tc = new Telecaster();
            AbrirFormNoPainel(tc);
        }
    }
    
}
