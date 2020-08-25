using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayordeEdad
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            double edad;

            edad = double.Parse(txtEdad.Text);

            if (edad > 18) {
                lblRespuesta.Text = ("Eres mayor de edad");
                
            }
            else if (edad > 1 && edad <= 18)  {
                lblRespuesta.Text = ("Eres menor de edad");
            }
            else if (edad <= 0) {
                lblRespuesta.Text= ("La edad ingresada no es permitida");
             }
            lblRespuesta.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEdad.Text = string.Empty;
            lblRespuesta.Text = " ";
            txtEdad.Focus();
        }
    }
}
