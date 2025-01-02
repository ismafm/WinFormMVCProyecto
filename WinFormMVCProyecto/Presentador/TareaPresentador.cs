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
        public void OnGuardarTareaClick(object sender, EventArgs e)
        {
            string nombreTarea = this.vista.NombreTarea;
            if (!string.IsNullOrWhiteSpace(nombreTarea))
            {
                bool completada = this.vista.CompletarTarea;
                DateTime fechaTarea = this.vista.FechaCreacion;
                TareaModel nuevaTarea = new TareaModel(nombreTarea, completada, fechaTarea);

                datos.AnyadirTarea(nuevaTarea);
                vista.MostrarTareas(datos.getTarea());

            }

        }

        public void CargarTareas()
        {
            vista.MostrarTareas(datos.getTarea());
        }

    }
}
