using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMVCProyecto.Datos;
using WinFormMVCProyecto.Modelo;

namespace WinFormMVCProyecto.Vista
{
    public partial class TareaForm : Form
    {
        public string NombreTarea => tareaNombre.Text;
        public bool CompletarTarea => tareaCompletada.Checked;
        public DateTime FechaCreacion => TareaFechaCreacion.Value;

        public event EventHandler GuardarTareaClick;
        public event EventHandler EliminarUltimaFila;

        public TareaForm()
        {
            InitializeComponent();
            guardarTarea.Click += (s, e) => GuardarTareaClick?.Invoke(this, EventArgs.Empty);
            //eliminarUltimo.Click += (s, e) => EliminarUltimaFila?.Invoke(this, EventArgs.Empty);
        }

        public void MostrarTareasDataGrid(TareaDataGridModel[] listaTareasRecibidas)
        {
            listaTareas.Columns.Clear();

            // Evitar la generación automática
            //listaTareas.AutoGenerateColumns = false;

            //Bloquea la modificación de información
            listaTareas.ReadOnly = true;

            //Ancho automatico ajustado a columna más larga
            listaTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Configurar columnas manualmente
            listaTareas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columna1",
                HeaderText = "Nombre de la tarea", // Nombre visible en el encabezado
                DataPropertyName = "NombreTarea" // Propiedad del objeto a mostrar
            });

            listaTareas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columna2",
                HeaderText = "Completada",
                DataPropertyName = "Completada"
            });
            listaTareas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "columna3",
                HeaderText = "Fecha de creación",
                DataPropertyName = "FechaCreacion",
            });

            listaTareas.DataSource = listaTareasRecibidas;
        }

        private void TareaForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
