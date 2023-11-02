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
    public partial class Frm_Inscripcion : Form
    {
        OperacionesP op = new OperacionesP();
        Operaciones op1 = new Operaciones();
        public Frm_Inscripcion()
        {
            InitializeComponent();
        }

        private void Frm_Inscripcion_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            CargarComboEstudiantes();
        }

        private void CargarEstudiantes()
        {
            dataGridView1.DataSource = op.CargarEstudiantes().ToList();
        }
        private void CargarComboEstudiantes()
        {

            foreach (CarreraQuery i in op1.CargarDatos())
            {
                Combo_CarreraEstudiante.Items.Add(new CarreraQuery { NombreCarrera = i.NombreCarrera, CodigoCarrera = i.CodigoCarrera });
            }

        }

        private void Btn_GuardarEstudiante_Click(object sender, EventArgs e)
        {
            
            int CodigoCarrera = ((CarreraQuery)Combo_CarreraEstudiante.SelectedItem).CodigoCarrera;
            
            if (Txt_ContraseñaEstudiante.Text != string.Empty && Combo_CarreraEstudiante != null && Combo_CarreraEstudiante.SelectedItem != null)
            {
                op.AgregarEstudiante(Txt_NombreEstudiante.Text, Txt_ApellidoEstudiante.Text, Txt_ContraseñaEstudiante.Text,CodigoCarrera);
                CargarEstudiantes();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty)
            {
                dataGridView1.DataSource = op.CargarEstudiantes(textBox4.Text).ToList();
            }
            else
            {
                CargarEstudiantes();
            }
        }
    }
}
