using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_02.Modelo;

namespace Parcial_02
{
    public partial class Form1 : Form
    {
        private APPUSER idUser;
        
        public Form1(APPUSER pUsuario)
        {
            InitializeComponent();
            idUser = pUsuario;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = 
                "Bienvenido " + idUser.username + " [" + (idUser.userType ? "Administrador" : "Usuario") + "]";
                
            if (idUser.userType)
            {
                // Los administradores si tienen acceso a esta informacion
                //configurarGrafico();
                //actualizarControles();
            }
            else
            {
                // Los usuarios NO administradores no tienen permiso de acceder a estas pestanas
                tabControl1.TabPages[3].Parent = null;
                tabControl1.TabPages[4].Parent = null;
                //tabControl1.TabPages[1].Parent = null;
            }
            
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text.Length >= 5)
                {
                    APPUSER1.crearNuevo(txtfullname.Text);
                    APPUSER1.crearNuevo(txtusername.Text);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                    "contrasena igual a usuario, no admin.", 
                        "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtfullname.Clear();
                    txtusername.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)", 
                        "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<APPUSER> lista = APPUSER1.getLista();
            
            // Tabla (data grid view)
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = lista;
            // Menu desplegable (combo box)
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "contrasena";
            comboBox1.DisplayMember = "usuario";
            comboBox1.DataSource = lista;
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            APPUSER1.actualizarPermisos(comboBox3.Text, radAdmin.Checked);
            
            MessageBox.Show("¡Usuario actualizado exitosamente!", 
                "Parcial02", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            actualizarControles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //direccion
            
            
            if (textBoxDIreccion.Text.Equals("") )
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    /*Conexion.ExecuteNonQuery( $"INSERT INTO ADDRESS VALUES ( " +
                                                 $"{idUser}," +
                                                 $"'{textBoxDIreccion.Text}'," );*/
                    
                    ADDRESS1.nuevaDireccion(Convert.ToInt32(idUser),textBoxDIreccion.Text);
                    
                    textBoxDIreccion.Clear();
                    MessageBox.Show("Se ha registrado el estudiante");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A ocurrido un error");
                }
                
                
            }
            
            
        }
    }
}