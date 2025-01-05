using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVCProyecto.Datos;
using WinFormMVCProyecto.Modelo;
using WinFormMVCProyecto.Vista;

namespace WinFormMVCProyecto.Presentador
{
    internal class TareaPresentador
    {
        private readonly TareaForm vista;
        private readonly TareaModel modelo;
        private readonly Tarea datos;

        public TareaPresentador(TareaForm vista)
        {
            this.vista = vista;
            this.modelo = new TareaModel();
            this.datos = new Tarea();


            this.vista.GuardarTareaClick += OnGuardarTareaClick;
            CargarTareas();
        }
        private TareaDataGridModel[] GetVisualTareaArray(TareaModel[] tareaArray)
        {
            return tareaArray.Select(t => new TareaDataGridModel()
            {
                NombreTarea = t.NombreTarea,
                Completada = t.Completada ? "Sí" : "No",
                FechaCreacion = t.FechaCreacion.ToString("dd/MM/yyyy"),
            }).ToArray();
        }
        public void OnGuardarTareaClick(object sender, EventArgs e)
        {
            string nombreTarea = this.vista.NombreTarea;
            if (!string.IsNullOrWhiteSpace(nombreTarea))
            {
                bool completada = this.vista.CompletarTarea;
                DateTime fechaTarea = this.vista.FechaCreacion;
                TareaModel nuevaTarea = new TareaModel(nombreTarea, completada, fechaTarea);

                datos.AnyadirTarea(nuevaTarea);
                vista.MostrarTareasDataGrid(GetVisualTareaArray(datos.getTareaObject()));

            }

        }

        public void CargarTareas()
        {
            vista.MostrarTareasDataGrid(GetVisualTareaArray(datos.getTareaObject()));
        }

    }
}
