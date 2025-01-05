using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVCProyecto.Modelo;

namespace WinFormMVCProyecto.Datos
{
    internal class Tarea
    {
        public List<TareaModel> ListaTareas { get; set; } = new List<TareaModel>();

        public void AnyadirTarea(TareaModel tarea)
        {
            this.ListaTareas.Add(tarea);
        }
        public string[] getTarea()
        {
            return this.ListaTareas
                .Select(tarea => $"Nombre: {tarea.NombreTarea}; " +
                $"Completada: {(tarea.Completada ? "Sí" : "No")}, Fecha creación: {tarea.FechaCreacion.ToString("dd/MM/yyyy")}").ToArray();
        }
        public TareaModel[] getTareaObject()
        {
            return this.ListaTareas.ToArray();
        }
    }
}
