
namespace Universidad
{
    partial class Profesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesores));
            this.lbl_NombreProfesor = new System.Windows.Forms.Label();
            this.txt_NombreProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ApellidoProfesor = new System.Windows.Forms.TextBox();
            this.Btn_EliminarProfesor = new System.Windows.Forms.Button();
            this.Btn_GuardarProfesor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreProfesor
            // 
            this.lbl_NombreProfesor.AutoSize = true;
            this.lbl_NombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProfesor.Location = new System.Drawing.Point(13, 30);
            this.lbl_NombreProfesor.Name = "lbl_NombreProfesor";
            this.lbl_NombreProfesor.Size = new System.Drawing.Size(91, 24);
            this.lbl_NombreProfesor.TabIndex = 0;
            this.lbl_NombreProfesor.Text = "Nombre:";
            // 
            // txt_NombreProfesor
            // 
            this.txt_NombreProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProfesor.Location = new System.Drawing.Point(110, 27);
            this.txt_NombreProfesor.Name = "txt_NombreProfesor";
            this.txt_NombreProfesor.Size = new System.Drawing.Size(311, 29);
            this.txt_NombreProfesor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido:";
            // 
            // txt_ApellidoProfesor
            // 
            this.txt_ApellidoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ApellidoProfesor.Location = new System.Drawing.Point(110, 122);
            this.txt_ApellidoProfesor.Name = "txt_ApellidoProfesor";
            this.txt_ApellidoProfesor.Size = new System.Drawing.Size(311, 29);
            this.txt_ApellidoProfesor.TabIndex = 3;
            // 
            // Btn_EliminarProfesor
            // 
            this.Btn_EliminarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EliminarProfesor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EliminarProfesor.Image")));
            this.Btn_EliminarProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EliminarProfesor.Location = new System.Drawing.Point(241, 257);
            this.Btn_EliminarProfesor.Name = "Btn_EliminarProfesor";
            this.Btn_EliminarProfesor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_EliminarProfesor.Size = new System.Drawing.Size(180, 74);
            this.Btn_EliminarProfesor.TabIndex = 11;
            this.Btn_EliminarProfesor.Text = "Eliminar";
            this.Btn_EliminarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EliminarProfesor.UseVisualStyleBackColor = true;
            this.Btn_EliminarProfesor.Click += new System.EventHandler(this.Btn_EliminarProfesor_Click);
            // 
            // Btn_GuardarProfesor
            // 
            this.Btn_GuardarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarProfesor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_GuardarProfesor.Image")));
            this.Btn_GuardarProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_GuardarProfesor.Location = new System.Drawing.Point(17, 257);
            this.Btn_GuardarProfesor.Name = "Btn_GuardarProfesor";
            this.Btn_GuardarProfesor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_GuardarProfesor.Size = new System.Drawing.Size(180, 74);
            this.Btn_GuardarProfesor.TabIndex = 10;
            this.Btn_GuardarProfesor.Text = "Guardar";
            this.Btn_GuardarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_GuardarProfesor.UseVisualStyleBackColor = true;
            this.Btn_GuardarProfesor.Click += new System.EventHandler(this.Btn_GuardarProfesor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(348, 304);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar Profesor:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(628, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 358);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_EliminarProfesor);
            this.Controls.Add(this.Btn_GuardarProfesor);
            this.Controls.Add(this.txt_ApellidoProfesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NombreProfesor);
            this.Controls.Add(this.lbl_NombreProfesor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profesores";
            this.ShowIcon = false;
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.Frm_Profesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NombreProfesor;
        private System.Windows.Forms.TextBox txt_NombreProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ApellidoProfesor;
        private System.Windows.Forms.Button Btn_EliminarProfesor;
        private System.Windows.Forms.Button Btn_GuardarProfesor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}