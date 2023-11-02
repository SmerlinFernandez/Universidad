using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universidad
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Carreras Carrera = new Frm_Carreras();
            Carrera.MdiParent = this;
            Carrera.StartPosition = FormStartPosition.CenterScreen;
            Carrera.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Asignaturas asignaturas = new Frm_Asignaturas();
            asignaturas.MdiParent = this;
            asignaturas.StartPosition = FormStartPosition.CenterScreen;
            asignaturas.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores profesores = new Profesores();
            profesores.MdiParent = this;
            profesores.StartPosition = FormStartPosition.CenterScreen;
            profesores.Show();
        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inscripcion inscripcion = new Frm_Inscripcion();
            inscripcion.MdiParent = this;
            inscripcion.StartPosition = FormStartPosition.CenterScreen;
            inscripcion.Show();
        }

        private void asignaturaProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AsignaturaProfesor asignaturaProfesor = new Frm_AsignaturaProfesor();
            asignaturaProfesor.MdiParent = this;
            asignaturaProfesor.StartPosition = FormStartPosition.CenterScreen;
            asignaturaProfesor.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EstudiantesMaterias frm_EstudiantesMaterias = new Frm_EstudiantesMaterias();
            frm_EstudiantesMaterias.MdiParent = this;
            frm_EstudiantesMaterias.StartPosition = FormStartPosition.CenterScreen;
            frm_EstudiantesMaterias.Show();
        }
    }
}
