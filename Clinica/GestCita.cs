using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinica.conexion;

namespace Clinica
{
    public partial class GestCita : Form
    {
        public GestCita()
        {
            InitializeComponent();
        }

        private void gestcita_fc(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GestCita_Load(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
