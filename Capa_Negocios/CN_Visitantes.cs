using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Accesso_Datos;
using Capa_Entidad;


namespace Capa_Negocios
{
    public class CN_Visitantes
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        CAD_Visitantes objDatatos = new CAD_Visitantes();

        public List<CE_Visitantes> ListarVisitantes(String buscar)
        {
            return objDatatos.ListarVisitantes(buscar);
        }


        public List<CE_Visitantes> ListarLugar(String buscar)
        {
            return objDatatos.ListarLugar(buscar);
        }


        public List<CE_Visitantes> ListarLugarEdificio(String buscar)
        {
            return objDatatos.ListarLugarEdificio(buscar);
        }

        public List<CE_Visitantes> ListarLugarAula(String buscar)
        {
            return objDatatos.ListarLugarAula(buscar);
        }


        public String ContarUsuarioGeneral(String buscar)
        {
            return objDatatos.ContarUsuarioGeneral(buscar);
        }

        public String ContarUsuarioAdmin(String buscar)
        {
            return objDatatos.ContarUsuarioAdmin(buscar);
        }


        public void InsertarUsuarioAdmid(CE_Visitantes Usuario)
        {

            objDatatos.InsertarUsuarioAdmid(Usuario);
        }


        public void InsertarUsuarioGeneral(CE_Visitantes Usuario)
        {

            objDatatos.InsertarUsuarioGeneral(Usuario);
        }


        public void InsertarVisitante(CE_Visitantes Visitante)
        {

            objDatatos.InsertarVisitante(Visitante);
        }


        public void InsertarLugar(CE_Visitantes Lugar)
        {

            objDatatos.InsertarLugar(Lugar);
        }


        public void EditarLugar(CE_Visitantes Lugar)
        {

            objDatatos.EditarLugar(Lugar);
        }


        public String BuscarUsuarioAdmid(String Usuario)
        {

           return objDatatos.BuscarUsuarioAdmid(Usuario);
        }


        public String BuscarUsuarioGeneral(String Usuario)
        {

            return objDatatos.BuscarUsuarioGeneral(Usuario);
        }


    }
}
