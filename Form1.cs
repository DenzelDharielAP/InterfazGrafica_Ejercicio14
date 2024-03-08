using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio15
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string asignatura, profesor;

            asignatura = txtAsignatura.Text;
            profesor = txtProfesor.Text;

            if (rbtnPresencial.Checked)
            {
                lblAsignatura.Text = asignatura;
                lblProfesor.Text = profesor;
                lblModalidad.Text = "Modalidad presencial";
            }

            else 
            {
                lblAsignatura.Text = asignatura;
                lblProfesor.Text = profesor;
                lblModalidad.Text = "Modalidad virtual";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAsignatura.Clear();
            txtProfesor.Clear();

            rbtnPresencial.Checked = false;
            rbtnVirtual.Checked = false;

            lblAsignatura.ResetText();
            lblModalidad.ResetText();
            lblProfesor.ResetText();

            txtAsignatura.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult  respuesta = (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (respuesta == DialogResult.Yes)
            {
                Close();

            }

            else { txtAsignatura.Focus(); }
        }
    }
}
