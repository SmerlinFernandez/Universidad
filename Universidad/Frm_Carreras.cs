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
    public partial class Frm_Carreras : Form
    {
        Operaciones op = new Operaciones();
        public Frm_Carreras()
        {
            InitializeComponent();
        }

    
        private void Frm_Carreras_Load(object sender, EventArgs e)
        {
            MostrarCarreras();
        }


        private void MostrarCarreras()
        {
            try
            {
                
                dataGridView1.DataSource = op.CargarDatos().ToList();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void MostrarCarreras(string NombreCarrera)
        {
            try
            {

                dataGridView1.DataSource = op.CargarDatos(NombreCarrera).ToList();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }



        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            if (CarreraTexto.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar un nombre de carrera válido", "Error");
            }
            else
            {
                try
                {
                    op.AgregarCarrera(CarreraTexto.Text);
                    dataGridView1.DataSource = op.CargarDatos().ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Caja_BuscarCarrera_TextChanged(object sender, EventArgs e)
        {
            if (Caja_BuscarCarrera.Text != string.Empty)
            {
                MostrarCarreras(Caja_BuscarCarrera.Text);
            }
            else
            {
                MostrarCarreras();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string nombrecarrera = op.DevolverNombreCarrera(int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            if (MessageBox.Show($"¿Estas seguro de que deseas eliminar {nombrecarrera}?", "Eliminar carrera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    op.EliminarCarrera(int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                    MostrarCarreras();
                }
                catch (Exception c)
                {

                    MessageBox.Show(c.Message);
                }
            }
            
        }
    }
}
