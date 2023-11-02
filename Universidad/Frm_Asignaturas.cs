using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Logica;

namespace Universidad
{
    public partial class Frm_Asignaturas : Form
    {
        Operaciones op = new Operaciones();
        public Frm_Asignaturas()
        {
            InitializeComponent();
            Combo_Carreras.AutoCompleteSource = AutoCompleteSource.ListItems;
            Combo_Carreras.AutoCompleteMode = AutoCompleteMode.Suggest;

        }

        private void CargarComboBoxCarreras()
        {

            foreach (CarreraQuery i in op.CargarDatos())
            {
                Combo_Carreras.Items.Add(new CarreraQuery {NombreCarrera = i.NombreCarrera,CodigoCarrera=i.CodigoCarrera } );
            }

        }

        private void CargarComboBoxHorario()
        {
            List<string> ListaHorarios = new List<string> 
            {"8:00 AM a 10:00 AM","10:00 AM a 12:00 PM",
                "12:00 PM a 2:00 PM","2:00 PM a 4:00 PM",
                "4:00 PM a 6:00 PM", "6:00 PM a 8:00 PM",
                "8:00 PM a 10:00 PM"
            };

            foreach (string horario in ListaHorarios) Combo_Horario.Items.Add(horario);
        }

        private void Frm_Asignaturas_Load(object sender, EventArgs e)
        {
            CargarComboBoxCarreras();
            CargarComboBoxHorario();
        }

        private void CargarAsignaturas()
        {
            int seleccion = ((CarreraQuery)Combo_Carreras.SelectedItem).CodigoCarrera;
            dataGridView1.DataSource = op.CargarAsignaturas(seleccion).ToList();
        }
        private void Combo_Carreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarAsignaturas();
        }

        private void Caja_BuscarAsignatura_TextChanged(object sender, EventArgs e)
        {

            if (Caja_BuscarAsignatura.Text != string.Empty)
            {
                if (Combo_Carreras.SelectedItem != null)
                {
                    dataGridView1.DataSource = op.CargarAsignaturas(((CarreraQuery)Combo_Carreras.SelectedItem).CodigoCarrera, Caja_BuscarAsignatura.Text).ToList();
                }



            }
            else
            {
                if (Combo_Carreras.SelectedItem != null)
                {

                    dataGridView1.DataSource = op.CargarAsignaturas(((CarreraQuery)Combo_Carreras.SelectedItem).CodigoCarrera).ToList();
                }
            }
        }

        private void Btn_GuardarAsignatura_Click(object sender, EventArgs e)
        {
            if (Caja_NombreAsignatura.Text != string.Empty && Combo_Horario.SelectedItem != null && Combo_Carreras.SelectedItem != null)
            {
                op.AgregarAsignatura(Caja_NombreAsignatura.Text, Combo_Horario.SelectedItem.ToString());
                List<AsignaturaQuery> Asignatura = op.CargarAsignaturas(Caja_NombreAsignatura.Text).ToList();
                op.AgregarAsignaturaCarrera(((CarreraQuery)Combo_Carreras.SelectedItem).CodigoCarrera,Asignatura[0].CodigoAsignatura);

                CargarAsignaturas();
            }
        }

        private void Btn_EliminarAsignatura_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show($"¿Estas seguro de que deseas eliminar esta asignatura?", "Eliminar asignatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var asignatura = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                string a = asignatura.ToString();
                op.EliminarAsignatura(int.Parse(a));
                CargarAsignaturas();
            }
                
        }
    }
}
