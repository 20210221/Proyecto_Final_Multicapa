using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Entidad
{
    public class CE_Visitantes
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

        private String _CodeUsuarioAdmid;

        private String _NombreAdmid;

        private String _ApellidoAdmid;

        private String _NacimientoAdmid;

        public string CodeUsuarioAdmid { get => _CodeUsuarioAdmid; set => _CodeUsuarioAdmid = value; }
        public string NombreAdmid { get => _NombreAdmid; set => _NombreAdmid = value; }
        public string ApellidoAdmid { get => _ApellidoAdmid; set => _ApellidoAdmid = value; }
        public string NacimientoAdmid { get => _NacimientoAdmid; set => _NacimientoAdmid = value; }



        private String _CodeUsuarioGeneral;

        private String _NombreGeneral;

        private String _ApellidoGeneral;

        private String _NacimientoGeneral;

        public string CodeUsuarioGeneral { get => _CodeUsuarioGeneral; set => _CodeUsuarioGeneral = value; }
        public string NombreGeneral { get => _NombreGeneral; set => _NombreGeneral = value; }
        public string ApellidoGeneral { get => _ApellidoGeneral; set => _ApellidoGeneral = value; }
        public string NacimientoGeneral { get => _NacimientoGeneral; set => _NacimientoGeneral = value; }
       


        private String _CodeLugar;

        private String _EdificioLugar;

        private String _AulaLugar;

        public string CodeLugar { get => _CodeLugar; set => _CodeLugar = value; }
        public string EdificioLugar { get => _EdificioLugar; set => _EdificioLugar = value; }
        public string AulaLugar { get => _AulaLugar; set => _AulaLugar = value; }
        

        private String _CodeVisitante;

        private String _NombreVisitante;

        private String _ApellidoVisitante;

        private String _CarreraVisitante;

        private String _EmailVisitante;

        private String _EntradaVisitante;

        private String _SalidaVisitante;

        private String _MotivoVisitante;

        private String _FotoVisitante;

        private String _EdificioVisitante;

        private String _AulaVisitante;


        public string CodeVisitante { get => _CodeVisitante; set => _CodeVisitante = value; }
        public string NombreVisitante { get => _NombreVisitante; set => _NombreVisitante = value; }
        public string ApellidoVisitante { get => _ApellidoVisitante; set => _ApellidoVisitante = value; }
        public string CarreraVisitante { get => _CarreraVisitante; set => _CarreraVisitante = value; }
        public string EmailVisitante { get => _EmailVisitante; set => _EmailVisitante = value; }
        public string EntradaVisitante { get => _EntradaVisitante; set => _EntradaVisitante = value; }
        public string SalidaVisitante { get => _SalidaVisitante; set => _SalidaVisitante = value; }
        public string MotivoVisitante { get => _MotivoVisitante; set => _MotivoVisitante = value; }
        public string FotoVisitante { get => _FotoVisitante; set => _FotoVisitante = value; }
        public string EdificioVisitante { get => _EdificioVisitante; set => _EdificioVisitante = value; }
        public string AulaVisitante { get => _AulaVisitante; set => _AulaVisitante = value; }



    }
}
