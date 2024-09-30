namespace Clinica
{
    partial class GestCita
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncrearcita = new System.Windows.Forms.Button();
            this.SCcita = new System.Windows.Forms.SplitContainer();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SCcita)).BeginInit();
            this.SCcita.Panel1.SuspendLayout();
            this.SCcita.Panel2.SuspendLayout();
            this.SCcita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestionar Cita ";
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(513, 8);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(157, 40);
            this.btnconsultar.TabIndex = 10;
            this.btnconsultar.Text = "Consultar Información";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(176, 8);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(157, 40);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar Informacion ";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(343, 8);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(157, 40);
            this.btnactualizar.TabIndex = 8;
            this.btnactualizar.Text = "Actualizar Informacion";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btncrearcita
            // 
            this.btncrearcita.Location = new System.Drawing.Point(12, 8);
            this.btncrearcita.Name = "btncrearcita";
            this.btncrearcita.Size = new System.Drawing.Size(157, 40);
            this.btncrearcita.TabIndex = 7;
            this.btncrearcita.Text = "Crear Cita ";
            this.btncrearcita.UseVisualStyleBackColor = true;
            // 
            // SCcita
            // 
            this.SCcita.Location = new System.Drawing.Point(12, 50);
            this.SCcita.Name = "SCcita";
            this.SCcita.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SCcita.Panel1
            // 
            this.SCcita.Panel1.Controls.Add(this.btncrearcita);
            this.SCcita.Panel1.Controls.Add(this.btnconsultar);
            this.SCcita.Panel1.Controls.Add(this.btneliminar);
            this.SCcita.Panel1.Controls.Add(this.btnactualizar);
            // 
            // SCcita.Panel2
            // 
            this.SCcita.Panel2.Controls.Add(this.dataGridView1);
            this.SCcita.Size = new System.Drawing.Size(682, 357);
            this.SCcita.SplitterDistance = 56;
            this.SCcita.TabIndex = 11;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(455, 416);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(108, 41);
            this.btnvolver.TabIndex = 21;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(587, 416);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(108, 41);
            this.btnsalir.TabIndex = 20;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(682, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // GestCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 466);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.SCcita);
            this.Controls.Add(this.label1);
            this.Name = "GestCita";
            this.Text = "GestCita";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gestcita_fc);
            this.Load += new System.EventHandler(this.GestCita_Load);
            this.SCcita.Panel1.ResumeLayout(false);
            this.SCcita.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SCcita)).EndInit();
            this.SCcita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btncrearcita;
        private System.Windows.Forms.SplitContainer SCcita;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnsalir;
    }
}