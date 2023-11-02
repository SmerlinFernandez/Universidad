
namespace Universidad
{
    partial class Frm_Asignaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Asignaturas));
            this.label1 = new System.Windows.Forms.Label();
            this.Caja_NombreAsignatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Carreras = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Combo_Horario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Caja_BuscarAsignatura = new System.Windows.Forms.TextBox();
            this.Btn_EliminarAsignatura = new System.Windows.Forms.Button();
            this.Btn_GuardarAsignatura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Caja_NombreAsignatura
            // 
            this.Caja_NombreAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caja_NombreAsignatura.Location = new System.Drawing.Point(110, 34);
            this.Caja_NombreAsignatura.Name = "Caja_NombreAsignatura";
            this.Caja_NombreAsignatura.Size = new System.Drawing.Size(292, 29);
            this.Caja_NombreAsignatura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carrera:";
            // 
            // Combo_Carreras
            // 
            this.Combo_Carreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Carreras.FormattingEnabled = true;
            this.Combo_Carreras.Location = new System.Drawing.Point(110, 105);
            this.Combo_Carreras.Name = "Combo_Carreras";
            this.Combo_Carreras.Size = new System.Drawing.Size(292, 32);
            this.Combo_Carreras.TabIndex = 3;
            this.Combo_Carreras.SelectedIndexChanged += new System.EventHandler(this.Combo_Carreras_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(508, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(411, 342);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horario:";
            // 
            // Combo_Horario
            // 
            this.Combo_Horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Horario.FormattingEnabled = true;
            this.Combo_Horario.Location = new System.Drawing.Point(110, 174);
            this.Combo_Horario.Name = "Combo_Horario";
            this.Combo_Horario.Size = new System.Drawing.Size(292, 32);
            this.Combo_Horario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buscar Asignatura:";
            // 
            // Caja_BuscarAsignatura
            // 
            this.Caja_BuscarAsignatura.Location = new System.Drawing.Point(677, 369);
            this.Caja_BuscarAsignatura.Name = "Caja_BuscarAsignatura";
            this.Caja_BuscarAsignatura.Size = new System.Drawing.Size(242, 20);
            this.Caja_BuscarAsignatura.TabIndex = 7;
            this.Caja_BuscarAsignatura.TextChanged += new System.EventHandler(this.Caja_BuscarAsignatura_TextChanged);
            // 
            // Btn_EliminarAsignatura
            // 
            this.Btn_EliminarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EliminarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EliminarAsignatura.Image")));
            this.Btn_EliminarAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EliminarAsignatura.Location = new System.Drawing.Point(241, 280);
            this.Btn_EliminarAsignatura.Name = "Btn_EliminarAsignatura";
            this.Btn_EliminarAsignatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_EliminarAsignatura.Size = new System.Drawing.Size(180, 74);
            this.Btn_EliminarAsignatura.TabIndex = 9;
            this.Btn_EliminarAsignatura.Text = "Eliminar";
            this.Btn_EliminarAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EliminarAsignatura.UseVisualStyleBackColor = true;
            this.Btn_EliminarAsignatura.Click += new System.EventHandler(this.Btn_EliminarAsignatura_Click);
            // 
            // Btn_GuardarAsignatura
            // 
            this.Btn_GuardarAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarAsignatura.Image = ((System.Drawing.Image)(resources.GetObject("Btn_GuardarAsignatura.Image")));
            this.Btn_GuardarAsignatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_GuardarAsignatura.Location = new System.Drawing.Point(17, 280);
            this.Btn_GuardarAsignatura.Name = "Btn_GuardarAsignatura";
            this.Btn_GuardarAsignatura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_GuardarAsignatura.Size = new System.Drawing.Size(180, 74);
            this.Btn_GuardarAsignatura.TabIndex = 8;
            this.Btn_GuardarAsignatura.Text = "Guardar";
            this.Btn_GuardarAsignatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_GuardarAsignatura.UseVisualStyleBackColor = true;
            this.Btn_GuardarAsignatura.Click += new System.EventHandler(this.Btn_GuardarAsignatura_Click);
            // 
            // Frm_Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 395);
            this.Controls.Add(this.Btn_EliminarAsignatura);
            this.Controls.Add(this.Btn_GuardarAsignatura);
            this.Controls.Add(this.Caja_BuscarAsignatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Combo_Horario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Combo_Carreras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Caja_NombreAsignatura);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Asignaturas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Frm_Asignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Caja_NombreAsignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_Carreras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combo_Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Caja_BuscarAsignatura;
        private System.Windows.Forms.Button Btn_EliminarAsignatura;
        private System.Windows.Forms.Button Btn_GuardarAsignatura;
    }
}