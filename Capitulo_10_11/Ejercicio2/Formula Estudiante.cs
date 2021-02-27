using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Capitulo_10_11.Ejercicio2.Ejercicio2;

namespace Capitulo_10_11.Ejercicio2
{
    public partial class Formula_Estudiante : Form
    {
        public Formula_Estudiante()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Clear();
            DirecciontextBox.Clear();
            EdadtextBox.Clear();
            PromediotextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio = new Ejercicio2(NombretextBox.Text, Convert.ToInt32(EdadtextBox.Text), DirecciontextBox.Text, Convert.ToInt32(PromediotextBox.Text));
        }
    }
}
