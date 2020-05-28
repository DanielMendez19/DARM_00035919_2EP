using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using Parcial_02.Controlador;
using Parcial_02.Modelo;

namespace Parcial_02
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
          Controles();
        }
        private void Controles()
        {
            // Actualizar ComboBox
            cmbUsername.DataSource = null;
            cmbUsername.ValueMember = "password";
            cmbUsername.DisplayMember = "username";
            cmbUsername.DataSource = APPUSER1.getLista();
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cmbUsername.SelectedValue.Equals(txtContrasena.Text))
            {
                APPUSER u = (APPUSER) cmbUsername.SelectedItem;

                if (u.userType)
                {
                    //APPUSER.iniciarSesion(u.usuario);
                    APPUSER1.getLista();
                    
                    MessageBox.Show("¡Bienvenido!", 
                        "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Form1 ventana = new Form1(u);
                    ventana.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Su cuenta se encuentra inactiva, favor hable con el administrador", 
                        "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Parcial02",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            CambiarContra unaVentana = new CambiarContra();
            unaVentana.ShowDialog();
            Controles();
        }


        private void txtContrasena_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnIniciarSesion_Click(sender, e);
        }
    }
}