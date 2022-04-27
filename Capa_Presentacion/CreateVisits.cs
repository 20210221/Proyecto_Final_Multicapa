using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using Capa_Entidad;

namespace Capa_Presentacion
{

    public partial class CreateVisits : Form
    {

        String BackUserNav;

        public CreateVisits()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ListVisits Visits = new ListVisits();

            Visits.Show();

           


            if (BackUserNav == "Admin")
            {


                Visits.TypeUser("Admin");


            }


            if (BackUserNav == "General") {


                Visits.TypeUser("General");


            }


            this.Hide();

        }

       public void BackUser(String Nav)
        {

            if (Nav == "Admin") { BackUserNav = "Admin"; }

            if (Nav == "General") { BackUserNav = "General"; }

        }


        private void CreateVisits_Load(object sender, EventArgs e)
        {
            CN_Visitantes ObjectoNegocio = new CN_Visitantes();


            VisitanteEdificio.DataSource = ObjectoNegocio.ListarLugarEdificio("");

            VisitanteEdificio.DisplayMember = "EdificioLugar";

            VisitanteEdificio.ValueMember = "EdificioLugar";

            VisitanteEdificio.SelectedIndex = -1;


            ViewAulas(VisitanteEdificio.Text);


            VisitanteFoto.ImageLocation = "";
        }


        public void ViewAulas(String Aula)
        {
            CN_Visitantes ObjectoNegocio = new CN_Visitantes();

            VisitanteAula.DataSource = ObjectoNegocio.ListarLugarAula(Aula);

            VisitanteAula.DisplayMember = "AulaLugar";

            VisitanteAula.ValueMember = "AulaLugar";
        }

        private void VisitanteEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewAulas(VisitanteEdificio.Text);
        }

        private void VisitantebtnSave_Click(object sender, EventArgs e)
        {
            String Name = VisitanteName.Text;

            String LName = VisitanteLName.Text;

            String Carrera = VisitanteCarrera.Text;

            String Email = VisitanteEmail.Text;   

            String Entrada = VisitanteEntrada.Text + ", " + DateTime.Now.ToString("HH:mm:ss");

            String Salida = VisitanteSalida.Text + ", " + DateTime.Now.ToString("HH:mm:ss");

            String Motivo = VisitanteMotivo.Text;

            String Foto = VisitanteFoto.ImageLocation;

            String Edificio = VisitanteEdificio.Text;

            String Aula = VisitanteAula.Text;


            if (Name == "" || LName == "" || Entrada == "" || Salida == "" || Motivo == "")
            {

                MessageBox.Show("Para Guardar Complete Los Campos Requeridos", "Campos Requeridos Vacios");

                return;

            }

            if (Carrera == "") { Carrera = "Ninguna"; }

            if (Email == "") { Email = "Ninguno"; }

            if (Foto == "") { Foto = "Ninguna"; }


            try
            {

                CE_Visitantes ObjectoEntidad = new CE_Visitantes();

                CN_Visitantes ObjectoNegocio = new CN_Visitantes();

                ObjectoEntidad.NombreVisitante = Name;

                ObjectoEntidad.ApellidoVisitante = LName;

                ObjectoEntidad.CarreraVisitante = Carrera;

                ObjectoEntidad.EmailVisitante = Email;

                ObjectoEntidad.EntradaVisitante = Entrada;

                ObjectoEntidad.SalidaVisitante = Salida;

                ObjectoEntidad.MotivoVisitante = Motivo;

                ObjectoEntidad.FotoVisitante = Foto;

                ObjectoEntidad.EdificioVisitante = Edificio;

                ObjectoEntidad.AulaVisitante = Aula;

                ObjectoNegocio.InsertarVisitante(ObjectoEntidad);

                MessageBox.Show("El Visitante Fue Guardado Correctamente", "Visitante Guardado");

               
                ListVisits Visits = new ListVisits();

                Visits.Show();

                if (BackUserNav == "Admin")
                {


                    Visits.TypeUser("Admin");


                }


                if (BackUserNav == "General")
                {


                    Visits.TypeUser("General");


                }

                this.Hide();


            }
            catch (Exception ex)
            {


                MessageBox.Show("El Visitante No Pudo Guardarse" + ex, "Error: Visitante No Guardado");


            }

        }

        private void VisitanteSubirImagenbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog UpImage = new OpenFileDialog();

            if (UpImage.ShowDialog() == DialogResult.OK) {


                VisitanteFoto.ImageLocation = UpImage.FileName;

                VisitanteFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }
    }
}
