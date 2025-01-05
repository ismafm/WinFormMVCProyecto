using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMVCProyecto.Modelo
{
    public class TareaModel
    {
        //[DisplayName("Nombre")]
        public string NombreTarea { get; set; }
        public bool Completada { get; set; }
        public DateTime FechaCreacion { get; set; }

        public TareaModel() { }

        public TareaModel(string nombreTarea, bool completada, DateTime fechaCreacion)
        {
            this.NombreTarea = nombreTarea;
            this.Completada = completada;
            this.FechaCreacion = fechaCreacion;
        }

    }
}
