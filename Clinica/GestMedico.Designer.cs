namespace Clinica
{
    partial class GestMedico
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
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SCmedico = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SCmedico)).BeginInit();
            this.SCmedico.Panel1.SuspendLayout();
            this.SCmedico.Panel2.SuspendLayout();
            this.SCmedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gestionar Medico";
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(487, 12);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(151, 42);
            this.btnconsultar.TabIndex = 10;
            this.btnconsultar.Text = "Consultar Información";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(328, 11);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(151, 42);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar Informacion ";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(167, 11);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(151, 42);
            this.btnactualizar.TabIndex = 8;
            this.btnactualizar.Text = "Actualizar Informacion";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(10, 11);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(151, 42);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar Información";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // SCmedico
            // 
            this.SCmedico.Location = new System.Drawing.Point(12, 60);
            this.SCmedico.Name = "SCmedico";
            this.SCmedico.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SCmedico.Panel1
            // 
            this.SCmedico.Panel1.Controls.Add(this.btnRegistrar);
            this.SCmedico.Panel1.Controls.Add(this.btnconsultar);
            this.SCmedico.Panel1.Controls.Add(this.btnactualizar);
            this.SCmedico.Panel1.Controls.Add(this.btneliminar);
            // 
            // SCmedico.Panel2
            // 
            this.SCmedico.Panel2.Controls.Add(this.dataGridView1);
            this.SCmedico.Size = new System.Drawing.Size(650, 378);
            this.SCmedico.SplitterDistance = 65;
            this.SCmedico.TabIndex = 12;
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
            this.dataGridView1.Size = new System.Drawing.Size(650, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(425, 444);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(108, 41);
            this.btnvolver.TabIndex = 19;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(557, 444);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(108, 41);
            this.btnsalir.TabIndex = 18;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // GestMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 495);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.SCmedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsalir);
            this.Name = "GestMedico";
            this.Text = "GestMedico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gestmedico_fc);
            this.Load += new System.EventHandler(this.GestMedico_Load);
            this.SCmedico.Panel1.ResumeLayout(false);
            this.SCmedico.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCmedico)).EndInit();
            this.SCmedico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button btnconsultar;
        protected System.Windows.Forms.Button btneliminar;
        protected System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.SplitContainer SCmedico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnsalir;
    }
}