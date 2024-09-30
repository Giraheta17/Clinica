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
    public partial class GestMedico : Form
    {
        public GestMedico()
        {
            InitializeComponent();
        }


        private void gestmedico_fc(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void GestMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 from = new Form1();
            from.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Esto es para salir  va ahora suerte con el codigo ahi escribis si necesitas ayuda en algo    
        }
    }
}
