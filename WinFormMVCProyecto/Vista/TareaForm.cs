using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMVCProyecto.Vista
{
    public partial class TareaForm : Form
    {
        public string NombreTarea => tareaNombre.Text;
        public bool CompletarTarea => tareaCompletada.Checked;
        public DateTime FechaCreacion => TareaFechaCreacion.Value;

        public event EventHandler GuardarTareaClick;

        public TareaForm()
        {
            InitializeComponent();
            guardarTarea.Click += (s, e) => GuardarTareaClick?.Invoke(this, EventArgs.Empty);
        }

        public void MostrarTareas(string[] listaTareasRecibidas)
        {
            listaTareas.Items.Clear();
            listaTareas.Items.AddRange(listaTareasRecibidas);
        }

        private void TareaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
