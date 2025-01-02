using WinFormMVCProyecto.Presentador;
using WinFormMVCProyecto.Vista;

namespace WinFormMVCProyecto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            TareaForm formulario = new TareaForm();
            TareaPresentador presentador = new TareaPresentador(formulario);
            Application.Run(formulario);
        }
    }
}