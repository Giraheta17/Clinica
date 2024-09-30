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
// Esto es una prueba de que se puede conectar el porgrama en GitHUB 

        private void gestmedico_fc(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void GestMedico_Load(object sender, EventArgs e)
        {
            int funciona;
            if(funciona == true)
            {
            console.WriteLine("\nPORFIN FUNCIONA")
            }
            else
            {
            Console.WriteLine("\nFREGATE")
           }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 from = new Form1();
            from.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Esto es para salir    
        }
    }
}
