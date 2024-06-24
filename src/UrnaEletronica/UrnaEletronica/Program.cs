<<<<<<< HEAD
using UrnaEletronica.View.Candidato;
=======
>>>>>>> origin/CrudHigor
using UrnaEletronica.View.Coligacao;
using UrnaEletronica.View.Eleicao;
using UrnaEletronica.View.Menu_Inicial;
using UrnaEletronica.View.Votacao;

namespace UrnaEletronica
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
<<<<<<< HEAD
            Application.Run(new MenuPrincipalForm());
=======
            Application.Run(new GestaoPartidoForm());
>>>>>>> origin/CrudHigor
        }
    }
}