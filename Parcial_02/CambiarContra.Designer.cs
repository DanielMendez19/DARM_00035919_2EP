using System.ComponentModel;

namespace Parcial_02
{
    partial class CambiarContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContra));
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(286, 137);
            this.txtRepetir.MaxLength = 25;
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(151, 20);
            this.txtRepetir.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(173, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Repetir nueva:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(286, 112);
            this.txtNueva.MaxLength = 25;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(151, 20);
            this.txtNueva.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(173, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Contrasena nueva:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.Location = new System.Drawing.Point(173, 183);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(129, 23);
            this.btnCambiarContra.TabIndex = 23;
            this.btnCambiarContra.Text = "Cambiar contrasena";
            this.btnCambiarContra.UseVisualStyleBackColor = true;
            this.btnCambiarContra.Click += new System.EventHandler(this.btnCambiarContra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(286, 87);
            this.txtActual.MaxLength = 25;
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            this.txtActual.Size = new System.Drawing.Size(151, 20);
            this.txtActual.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contrasena actual:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(266, 48);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(151, 21);
            this.cmbUsuario.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(173, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(510, 255);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarContra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CambiarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarContra";
            this.Load += new System.EventHandler(this.CambiarContra_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCambiarContra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.TextBox txtRepetir;

        #endregion
    }
}