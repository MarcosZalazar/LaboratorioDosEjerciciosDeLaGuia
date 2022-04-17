using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Vista
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string generoElegido= " ";
            string[] cursosElegidos = new string[3];
            //string paisElegido = " ";

            if (radFemenino.Checked) 
            {
                generoElegido = radFemenino.Text;
            }
            if (radMasculino.Checked)
            {
                generoElegido = radMasculino.Text;
            }
            if (radNoBinario.Checked)
            {
                generoElegido = radNoBinario.Text;
            }

            if (chkCSharp.Checked)
            {
                cursosElegidos[0] = chkCSharp.Text;
            }
            if (chkCPlusPlus.Checked)
            {
                cursosElegidos[1] = chkCPlusPlus.Text;
            }
            if (chkJavascript.Checked)
            {
                cursosElegidos[2] = chkJavascript.Text;
            }

            Ingresante alumno =new Ingresante(txtNombre.Text, txtDireccion.Text,generoElegido, lsbPais.Text, cursosElegidos,(int)nudEdad.Value);

            MessageBox.Show(alumno.Mostrar());

        }
    }
}
