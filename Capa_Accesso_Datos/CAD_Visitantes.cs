using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
using System.Data;

namespace Capa_Accesso_Datos
{
    public class CAD_Visitantes
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

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        CE_Visitantes ObjectEntidad = new CE_Visitantes();


        public List<CE_Visitantes> ListarVisitantes(String buscar)
        {
            SqlDataReader Leerfilas;

            SqlCommand cmd = new SqlCommand("SP_BuscarVisitante", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            Leerfilas = cmd.ExecuteReader();

            List<CE_Visitantes> Listar = new List<CE_Visitantes>();

            while (Leerfilas.Read())
            {

                Listar.Add(new CE_Visitantes
                {

                    CodeVisitante = Leerfilas.GetString(1),

                    NombreVisitante = Leerfilas.GetString(2),

                    ApellidoVisitante = Leerfilas.GetString(3),

                    CarreraVisitante = Leerfilas.GetString(4),

                    EmailVisitante = Leerfilas.GetString(5),

                    EntradaVisitante = Leerfilas.GetString(6),

                    SalidaVisitante = Leerfilas.GetString(7),

                    MotivoVisitante = Leerfilas.GetString(8),

                    FotoVisitante = Leerfilas.GetString(9),

                    EdificioVisitante = Leerfilas.GetString(10),

                    AulaVisitante = Leerfilas.GetString(11)     

                });

            }

            conexion.Close();

            Leerfilas.Close();

            return Listar;
        }


        public List<CE_Visitantes> ListarLugar(String buscar)
        {
            SqlDataReader Leerfilas;

            SqlCommand cmd = new SqlCommand("SP_BuscarLugar", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            Leerfilas = cmd.ExecuteReader();

            List<CE_Visitantes> Listar = new List<CE_Visitantes>();

            while (Leerfilas.Read())
            {

                Listar.Add(new CE_Visitantes
                {

                    CodeLugar = Leerfilas.GetString(1),

                    EdificioLugar = Leerfilas.GetString(2),

                    AulaLugar = Leerfilas.GetString(3)          

                });

            }

            conexion.Close();

            Leerfilas.Close();

            return Listar;
        }


        public List<CE_Visitantes> ListarLugarEdificio(String buscar)
        {
            SqlDataReader Leerfilas;

            SqlCommand cmd = new SqlCommand("SP_BuscarLugarEdificio", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            Leerfilas = cmd.ExecuteReader();

            List<CE_Visitantes> Listar = new List<CE_Visitantes>();

            while (Leerfilas.Read())
            {

                Listar.Add(new CE_Visitantes
                {

                    

                    EdificioLugar = Leerfilas.GetString(0)

                   

                });

            }

            conexion.Close();

            Leerfilas.Close();

            return Listar;
        }

        public List<CE_Visitantes> ListarLugarAula(String buscar)
        {
            SqlDataReader Leerfilas;

            SqlCommand cmd = new SqlCommand("SP_BuscarLugarAulas", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            Leerfilas = cmd.ExecuteReader();

            List<CE_Visitantes> Listar = new List<CE_Visitantes>();

            while (Leerfilas.Read())
            {

                Listar.Add(new CE_Visitantes
                {



                    AulaLugar = Leerfilas.GetString(0)



                });

            }

            conexion.Close();

            Leerfilas.Close();

            return Listar;
        }

      
       

        public String ContarUsuarioGeneral(String buscar)
        {
            SqlDataReader Leerfilas;

            SqlCommand cmd = new SqlCommand("SP_CountUsuarioGeneral", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            Leerfilas = cmd.ExecuteReader();

            int countUser = 0;

            while (Leerfilas.Read())
            {

                countUser = countUser + 1;
            }

            conexion.Close();

            Leerfilas.Close();

            return countUser.ToString();
        }


        public String ContarUsuarioAdmin(String buscar)
        {
            SqlDataReader Leerfilas;

            SqlCommand cmd = new SqlCommand("SP_CountUsuarioAdmin", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);

            Leerfilas = cmd.ExecuteReader();

            int countUser = 0;

            while (Leerfilas.Read())
            {

                countUser = countUser + 1;
            }

            conexion.Close();

            Leerfilas.Close();

            return countUser.ToString();
        }


        public void InsertarUsuarioAdmid(CE_Visitantes Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuarioAdmid", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Usuario.NombreAdmid);

            cmd.Parameters.AddWithValue("@Apellido", Usuario.ApellidoAdmid);

            cmd.Parameters.AddWithValue("@Nacimiento", Usuario.NacimientoAdmid);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }


        public void InsertarUsuarioGeneral(CE_Visitantes Usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuarioGeneral", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Usuario.NombreGeneral);

            cmd.Parameters.AddWithValue("@Apellido", Usuario.ApellidoGeneral);

            cmd.Parameters.AddWithValue("@Nacimiento", Usuario.NacimientoGeneral);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }

       
        public void InsertarVisitante(CE_Visitantes Visitante)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarVisitante", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Visitante.NombreVisitante);

            cmd.Parameters.AddWithValue("@Apellido", Visitante.ApellidoVisitante);

            cmd.Parameters.AddWithValue("@Carrera", Visitante.CarreraVisitante);

            cmd.Parameters.AddWithValue("@Email", Visitante.EmailVisitante);

            cmd.Parameters.AddWithValue("@Entrada", Visitante.EntradaVisitante);

            cmd.Parameters.AddWithValue("@Salida", Visitante.SalidaVisitante);

            cmd.Parameters.AddWithValue("@Motivo", Visitante.MotivoVisitante);

            cmd.Parameters.AddWithValue("@Foto", Visitante.FotoVisitante);

            cmd.Parameters.AddWithValue("@Edifico", Visitante.EdificioVisitante);

            cmd.Parameters.AddWithValue("@Aula", Visitante.AulaVisitante);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }


        public void InsertarLugar(CE_Visitantes Lugar)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarLugar", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Edifico", Lugar.EdificioLugar);

            cmd.Parameters.AddWithValue("@Aula", Lugar.AulaLugar);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }


        public String BuscarUsuarioAdmid(String Usuario)
        {
            SqlDataReader Leerfilas;

            String Access;

            SqlCommand cmd = new SqlCommand("SP_BuscarUsuarioAdmid", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", Usuario);

            Leerfilas = cmd.ExecuteReader();


            if (Leerfilas.Read()) { Access = "Open"; }

            else {

                Access = "Close";

            }

            conexion.Close();

            Leerfilas.Close();

            return Access;
        }



        public String BuscarUsuarioGeneral(String Usuario)
        {
            SqlDataReader Leerfilas;

            String Access;

            SqlCommand cmd = new SqlCommand("SP_BuscarUsuarioGeneral", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", Usuario);

            Leerfilas = cmd.ExecuteReader();


            if (Leerfilas.Read()) { Access = "Open"; }

            else
            {

                Access = "Close";

            }

            conexion.Close();

            Leerfilas.Close();

            return Access;
        }



        public void EditarLugar(CE_Visitantes Lugar)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarLugar", conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@CodeLugar", Lugar.CodeLugar);

            cmd.Parameters.AddWithValue("@Edifico", Lugar.EdificioLugar);

            cmd.Parameters.AddWithValue("@Aula", Lugar.AulaLugar);

            cmd.ExecuteNonQuery();

            conexion.Close();
        }


    }
}
