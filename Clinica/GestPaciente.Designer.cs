namespace Clinica
{
    partial class GestPaciente
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.SCpaciente = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SCpaciente)).BeginInit();
            this.SCpaciente.Panel1.SuspendLayout();
            this.SCpaciente.Panel2.SuspendLayout();
            this.SCpaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gestionar Pacientes";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(3, 7);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 41);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar Información";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(492, 7);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(157, 41);
            this.btnconsultar.TabIndex = 14;
            this.btnconsultar.Text = "Consultar Información";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(329, 7);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(157, 41);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar Informacion ";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(166, 7);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(157, 41);
            this.btnactualizar.TabIndex = 12;
            this.btnactualizar.Text = "Actualizar Informacion";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // SCpaciente
            // 
            this.SCpaciente.Location = new System.Drawing.Point(12, 53);
            this.SCpaciente.Name = "SCpaciente";
            this.SCpaciente.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SCpaciente.Panel1
            // 
            this.SCpaciente.Panel1.Controls.Add(this.btnRegistrar);
            this.SCpaciente.Panel1.Controls.Add(this.btnconsultar);
            this.SCpaciente.Panel1.Controls.Add(this.btnactualizar);
            this.SCpaciente.Panel1.Controls.Add(this.btneliminar);
            // 
            // SCpaciente.Panel2
            // 
            this.SCpaciente.Panel2.Controls.Add(this.dataGridView1);
            this.SCpaciente.Size = new System.Drawing.Size(659, 397);
            this.SCpaciente.SplitterDistance = 56;
            this.SCpaciente.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(445, 456);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(108, 41);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(559, 456);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(108, 41);
            this.btnvolver.TabIndex = 17;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // GestPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 504);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.SCpaciente);
            this.Controls.Add(this.label4);
            this.Name = "GestPaciente";
            this.Text = "GestPaciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gestpacientes_fc);
            this.SCpaciente.Panel1.ResumeLayout(false);
            this.SCpaciente.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCpaciente)).EndInit();
            this.SCpaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        protected System.Windows.Forms.Button btnconsultar;
        protected System.Windows.Forms.Button btneliminar;
        protected System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.SplitContainer SCpaciente;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}