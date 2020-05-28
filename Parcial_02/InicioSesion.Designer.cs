using System.ComponentModel;
using System.Windows.Forms;

namespace Parcial_02
{
    partial class InicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(329, 168);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(111, 23);
            this.btnIniciarSesion.TabIndex = 13;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.Location = new System.Drawing.Point(194, 168);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(129, 23);
            this.btnCambiarContra.TabIndex = 12;
            this.btnCambiarContra.Text = "Cambiar contrasena";
            this.btnCambiarContra.UseVisualStyleBackColor = true;
            this.btnCambiarContra.Click += new System.EventHandler(this.btnCambiarContra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(288, 126);
            this.txtContrasena.MaxLength = 25;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(151, 20);
            this.txtContrasena.TabIndex = 10;
            this.txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasena_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(194, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contrasena:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(288, 87);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(151, 21);
            this.cmbUsername.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(194, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(535, 285);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnCambiarContra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.label1);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCambiarContra;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtContrasena;

        #endregion
    }
}