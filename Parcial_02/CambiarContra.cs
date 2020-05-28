using System;
using System.Windows.Forms;
using Parcial_02.Modelo;

namespace Parcial_02
{
    public partial class CambiarContra : Form
    {
        public CambiarContra()
        {
            InitializeComponent();
        }

        private void CambiarContra_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "password";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = APPUSER1.getLista();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            bool actualIgual = cmbUsuario.SelectedValue.Equals(txtActual.Text);
            bool nuevaIgual = txtNueva.Text.Equals(txtRepetir.Text);
            bool nuevaValida = txtNueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    APPUSER1.actualizarContra(cmbUsuario.Text, txtNueva.Text);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}