using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormularioSaludador : Form
    {
        public FormularioSaludador()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                FrmSaludo frmSaludo = new FrmSaludo("¡Hola, Windows Forms!", $"Soy {this.txtNombre.Text} {this.txtApellido.Text} y mi materia favorita es {this.cboMateria.SelectedItem}");
                frmSaludo.ShowDialog();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtApellido.Text))
                {
                    MessageBox.Show($"Se debe completar los siguientes campos \n {this.txtNombre.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    if (string.IsNullOrWhiteSpace(this.txtApellido.Text) && !string.IsNullOrWhiteSpace(this.txtNombre.Text))
                    {
                        MessageBox.Show($"Se debe completar los siguientes campos \n {this.txtApellido.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        MessageBox.Show($"Se debe completar los siguientes campos \n {this.txtNombre.Name}\n {this.txtApellido.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormularioSaludador_Load(object sender, EventArgs e)
        {
            this.cboMateria.Items.Add("Programación I");
            this.cboMateria.Items.Add("Laboratorio I");
            this.cboMateria.Items.Add("Programación II");
            this.cboMateria.Items.Add("Laboratorio II");
            this.cboMateria.Items.Add("Inglés");
            this.cboMateria.Items.Add("SPD");
            this.cboMateria.SelectedIndex = 0;
        }
    }
}
