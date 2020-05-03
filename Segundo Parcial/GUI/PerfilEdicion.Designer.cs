namespace Segundo_Parcial.GUI
{
    partial class PerfilEdicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbPuerto = new System.Windows.Forms.TextBox();
            this.txbPerfil = new System.Windows.Forms.TextBox();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbBD = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(131, 408);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(324, 408);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(131, 42);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 22);
            this.txbID.TabIndex = 2;
            // 
            // txbPuerto
            // 
            this.txbPuerto.Location = new System.Drawing.Point(324, 42);
            this.txbPuerto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(100, 22);
            this.txbPuerto.TabIndex = 3;
            // 
            // txbPerfil
            // 
            this.txbPerfil.Location = new System.Drawing.Point(131, 115);
            this.txbPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPerfil.Name = "txbPerfil";
            this.txbPerfil.Size = new System.Drawing.Size(293, 22);
            this.txbPerfil.TabIndex = 4;
            // 
            // txbServidor
            // 
            this.txbServidor.Location = new System.Drawing.Point(131, 172);
            this.txbServidor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(293, 22);
            this.txbServidor.TabIndex = 5;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(131, 231);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(293, 22);
            this.txbUsuario.TabIndex = 6;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(131, 291);
            this.txbContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(293, 22);
            this.txbContraseña.TabIndex = 7;
            // 
            // txbBD
            // 
            this.txbBD.Location = new System.Drawing.Point(131, 350);
            this.txbBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBD.Name = "txbBD";
            this.txbBD.Size = new System.Drawing.Size(293, 22);
            this.txbBD.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(128, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(321, 20);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(50, 17);
            this.lblPuerto.TabIndex = 10;
            this.lblPuerto.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Servidor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Base de Datos";
            // 
            // PerfilEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 486);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbBD);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.txbPerfil);
            this.Controls.Add(this.txbPuerto);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PerfilEdicion";
            this.Text = "Edicion de Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbPuerto;
        private System.Windows.Forms.TextBox txbPerfil;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbBD;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}