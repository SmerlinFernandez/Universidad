using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace Universidad
{
    public partial class Profesores : Form
    {
        OperacionesP op = new OperacionesP();
        public Profesores()
        {
            InitializeComponent();
        }

        private void MostrarProfesores()
        {
            dataGridView1.DataSource= op.CargarProfesores().ToList();
        }

        private void Frm_Profesores_Load(object sender, EventArgs e)
        {
            MostrarProfesores();
        }

        private void Btn_GuardarProfesor_Click(object sender, EventArgs e)
        {
            if(txt_NombreProfesor.Text != string.Empty && txt_ApellidoProfesor.Text != string.Empty)
            {
                try
                {
                    op.AgregarProfesor(txt_NombreProfesor.Text, txt_ApellidoProfesor.Text);
                    MostrarProfesores();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_EliminarProfesor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Estas seguro de que deseas eliminar este profesor?", "Eliminar carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int ID = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                    op.EliminarProfesor(ID);
                    MostrarProfesores();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                dataGridView1.DataSource = op.CargarProfesores(textBox1.Text).ToList();
            }
            else
            {
                MostrarProfesores();
            }
        }
    }
}
