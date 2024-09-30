using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngestmedicos_Click(object sender, EventArgs e)
        {
            GestMedico medico = new GestMedico();
            medico.Show();
            this.Hide();
        }

        private void btngestpacientes_Click(object sender, EventArgs e)
        {
            GestPaciente paciente = new GestPaciente();
            paciente.Show();
            this.Hide();
        }

        private void btngestcitas_Click(object sender, EventArgs e)
        {
            GestCita cita = new GestCita();
            cita.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void f1_fc(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
