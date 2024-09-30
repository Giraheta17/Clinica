namespace Clinica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btngestmedicos = new System.Windows.Forms.Button();
            this.btngestpacientes = new System.Windows.Forms.Button();
            this.btngestcitas = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de gestión de clinica ";
            // 
            // btngestmedicos
            // 
            this.btngestmedicos.Location = new System.Drawing.Point(42, 151);
            this.btngestmedicos.Name = "btngestmedicos";
            this.btngestmedicos.Size = new System.Drawing.Size(170, 161);
            this.btngestmedicos.TabIndex = 1;
            this.btngestmedicos.Text = "Gestionar Medicos";
            this.btngestmedicos.UseVisualStyleBackColor = true;
            this.btngestmedicos.Click += new System.EventHandler(this.btngestmedicos_Click);
            // 
            // btngestpacientes
            // 
            this.btngestpacientes.Location = new System.Drawing.Point(301, 151);
            this.btngestpacientes.Name = "btngestpacientes";
            this.btngestpacientes.Size = new System.Drawing.Size(170, 159);
            this.btngestpacientes.TabIndex = 2;
            this.btngestpacientes.Text = "Gestionar Pacientes ";
            this.btngestpacientes.UseVisualStyleBackColor = true;
            this.btngestpacientes.Click += new System.EventHandler(this.btngestpacientes_Click);
            // 
            // btngestcitas
            // 
            this.btngestcitas.Location = new System.Drawing.Point(548, 151);
            this.btngestcitas.Name = "btngestcitas";
            this.btngestcitas.Size = new System.Drawing.Size(170, 159);
            this.btngestcitas.TabIndex = 3;
            this.btngestcitas.Text = "Gestionar Citas";
            this.btngestcitas.UseVisualStyleBackColor = true;
            this.btngestcitas.Click += new System.EventHandler(this.btngestcitas_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(312, 386);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(149, 43);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngestcitas);
            this.Controls.Add(this.btngestpacientes);
            this.Controls.Add(this.btngestmedicos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f1_fc);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngestmedicos;
        private System.Windows.Forms.Button btngestpacientes;
        private System.Windows.Forms.Button btngestcitas;
        private System.Windows.Forms.Button btnsalir;
    }
}

