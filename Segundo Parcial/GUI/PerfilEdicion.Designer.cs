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
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbBD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(98, 306);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 24);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 306);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(58, 24);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Tag = "";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(98, 34);
            this.txbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(76, 20);
            this.txbID.TabIndex = 2;
            // 
            // txbPuerto
            // 
            this.txbPuerto.Location = new System.Drawing.Point(243, 34);
            this.txbPuerto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(76, 20);
            this.txbPuerto.TabIndex = 3;
            // 
            // txbPerfil
            // 
            this.txbPerfil.Location = new System.Drawing.Point(98, 99);
            this.txbPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPerfil.Name = "txbPerfil";
            this.txbPerfil.Size = new System.Drawing.Size(221, 20);
            this.txbPerfil.TabIndex = 4;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(98, 225);
            this.txbContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(221, 20);
            this.txbContraseña.TabIndex = 5;
            // 
            // txbServidor
            // 
            this.txbServidor.Location = new System.Drawing.Point(98, 143);
            this.txbServidor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(221, 20);
            this.txbServidor.TabIndex = 6;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(98, 188);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(221, 20);
            this.txbUsuario.TabIndex = 7;
            // 
            // txbBD
            // 
            this.txbBD.Location = new System.Drawing.Point(98, 260);
            this.txbBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBD.Name = "txbBD";
            this.txbBD.Size = new System.Drawing.Size(221, 20);
            this.txbBD.TabIndex = 8;
            // 
            // PerfilEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 362);
            this.Controls.Add(this.txbBD);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbServidor);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbPerfil);
            this.Controls.Add(this.txbPuerto);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PerfilEdicion";
            this.Text = "PerfilEdicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbPuerto;
        private System.Windows.Forms.TextBox txbPerfil;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbBD;
    }
}