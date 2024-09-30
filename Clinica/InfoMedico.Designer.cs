namespace Clinica
{
    partial class InfoMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> //LOL//
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.epmedico = new System.Windows.Forms.ErrorProvider(this.components);
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epmedico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Información Medico";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.txtnombre);
            this.Datos.Controls.Add(this.txtdui);
            this.Datos.Controls.Add(this.txtid);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label9);
            this.Datos.Location = new System.Drawing.Point(19, 84);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(547, 169);
            this.Datos.TabIndex = 9;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(121, 117);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(385, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(121, 76);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(385, 22);
            this.txtdui.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(121, 37);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(387, 22);
            this.txtid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DUI: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID: ";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(225, 269);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(176, 46);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // epmedico
            // 
            this.epmedico.ContainerControl = this;
            // 
            // InfoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 325);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "InfoMedico";
            this.Text = "RegistrarMedico";
            this.Load += new System.EventHandler(this.RegistrarMedico_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epmedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.GroupBox Datos;
        protected System.Windows.Forms.TextBox txtnombre;
        protected System.Windows.Forms.TextBox txtdui;
        protected System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ErrorProvider epmedico;
    }
}