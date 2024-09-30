namespace Clinica
{
    partial class InfoCita
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
            this.components = new System.ComponentModel.Container();
            this.btnguardar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidpaciente = new System.Windows.Forms.TextBox();
            this.txtidmedico = new System.Windows.Forms.TextBox();
            this.txtidcita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpcita = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.epcita = new System.Windows.Forms.ErrorProvider(this.components);
            this.Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epcita)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(206, 412);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(208, 44);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.dateTimePicker1);
            this.Datos.Controls.Add(this.dtpcita);
            this.Datos.Controls.Add(this.label8);
            this.Datos.Controls.Add(this.label7);
            this.Datos.Controls.Add(this.label6);
            this.Datos.Controls.Add(this.textBox1);
            this.Datos.Controls.Add(this.label5);
            this.Datos.Controls.Add(this.txtidpaciente);
            this.Datos.Controls.Add(this.txtidmedico);
            this.Datos.Controls.Add(this.txtidcita);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label4);
            this.Datos.Location = new System.Drawing.Point(22, 81);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(573, 321);
            this.Datos.TabIndex = 8;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Motivo:";
            // 
            // txtidpaciente
            // 
            this.txtidpaciente.Location = new System.Drawing.Point(166, 278);
            this.txtidpaciente.Name = "txtidpaciente";
            this.txtidpaciente.Size = new System.Drawing.Size(385, 22);
            this.txtidpaciente.TabIndex = 5;
            // 
            // txtidmedico
            // 
            this.txtidmedico.Location = new System.Drawing.Point(166, 237);
            this.txtidmedico.Name = "txtidmedico";
            this.txtidmedico.Size = new System.Drawing.Size(385, 22);
            this.txtidmedico.TabIndex = 4;
            // 
            // txtidcita
            // 
            this.txtidcita.Location = new System.Drawing.Point(166, 43);
            this.txtidcita.Name = "txtidcita";
            this.txtidcita.Size = new System.Drawing.Size(385, 22);
            this.txtidcita.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Paciente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Medico: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID  Cita: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Información Cita";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha Cita: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "            ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha Generación: ";
            // 
            // dtpcita
            // 
            this.dtpcita.Location = new System.Drawing.Point(166, 144);
            this.dtpcita.Name = "dtpcita";
            this.dtpcita.Size = new System.Drawing.Size(385, 22);
            this.dtpcita.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(382, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // epcita
            // 
            this.epcita.ContainerControl = this;
            // 
            // InfoCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.btnguardar);
            this.Name = "InfoCita";
            this.Text = "Cita";
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epcita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.TextBox txtidpaciente;
        private System.Windows.Forms.TextBox txtidmedico;
        private System.Windows.Forms.TextBox txtidcita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpcita;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider epcita;
    }
}