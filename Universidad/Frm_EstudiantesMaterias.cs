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
    public partial class Frm_EstudiantesMaterias : Form
    {
        OperacionesP op = new OperacionesP();
        Operaciones op1 = new Operaciones();
        public Frm_EstudiantesMaterias()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            CargarComboBox1();
           
        }

        private void CargarEstudiantes()
        {
            dataGridView1.DataSource = op.CargarEstudiantes().ToList();
        }

        private void CargarComboBox1()
        {
            foreach(CarreraQuery i in op1.CargarDatos())
            {
                comboBox1.Items.Add(new CarreraQuery { NombreCarrera = i.NombreCarrera, CodigoCarrera = i.CodigoCarrera });
            }

        }

        private void CargarComboBox3()
        {
            string horario = ((AsignaturaQuery)comboBox2.SelectedItem).HorarioAsignatura;
            comboBox3.Items.Add(horario);
        }

        private void CargarAsignaturas(int IdCarrera)
        {
            foreach (AsignaturaQuery i in op1.CargarAsignaturas(IdCarrera))
            {
                comboBox2.Items.Add(new AsignaturaQuery { NombreAsignatura = i.NombreAsignatura, CodigoAsignatura = i.CodigoAsignatura, HorarioAsignatura = i.HorarioAsignatura });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            string NombreCarrera = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Carrera"].Value.ToString();
            comboBox1.Text = NombreCarrera;
            comboBox1.Enabled = false;
            int ID = op.DevolverIdCarrera(NombreCarrera);

            CargarAsignaturas(ID);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            CargarComboBox3();
        }

        private void Btn_GuardarAsignaturaEstudiante_Click(object sender, EventArgs e)
        {

        }
    }
}
