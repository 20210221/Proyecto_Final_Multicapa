using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class CreateUsers : Form
    {


        public CreateUsers()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ListVisits Visits = new ListVisits();

            Visits.Show();

            this.Hide();


        }

        private void CreateUsers_Load(object sender, EventArgs e)
        {

            SelectUser.Items.Add("General");

            SelectUser.Items.Add("Administrador");

            SelectUser.SelectedIndex = 0;

            CN_Visitantes ObjectoNegocio = new CN_Visitantes();

            String Users = ObjectoNegocio.ContarUsuarioGeneral("");

            int CountUsers = Convert.ToInt32(Users) + 1;

            UserCode.Text = "Itla@General-0" + CountUsers.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || UserLName.Text == "") {


                MessageBox.Show("Complete Todos Los Campos Para Crear Un Usuario", "Campos Vacios");

                return;

            }


            if (SelectUser.Text == "Administrador") {


                try
                {

                    CE_Visitantes ObjectoEntidad = new CE_Visitantes();

                    CN_Visitantes ObjectoNegocio = new CN_Visitantes();

                    ObjectoEntidad.NombreAdmid = UserName.Text;

                    ObjectoEntidad.ApellidoAdmid = UserLName.Text;

                    ObjectoEntidad.NacimientoAdmid = UserDate.Text;

                    ObjectoNegocio.InsertarUsuarioAdmid(ObjectoEntidad);

                    MessageBox.Show("El Usuario Fue Creado Correctamente", "Usuario Creado");

                    ListVisits Visits = new ListVisits();

                    Visits.Show();

                    this.Hide();

                }
                catch (Exception ex)
                {


                    MessageBox.Show("El Usuario No Pudo Crearse" + ex, "Error: Usuario No Creado");


                }

            }


            if (SelectUser.Text == "General") {


                try
                {

                    CE_Visitantes ObjectoEntidad = new CE_Visitantes();

                    CN_Visitantes ObjectoNegocio = new CN_Visitantes();

                    ObjectoEntidad.NombreGeneral = UserName.Text;

                    ObjectoEntidad.ApellidoGeneral = UserLName.Text;

                    ObjectoEntidad.NacimientoGeneral = UserDate.Text;

                    ObjectoNegocio.InsertarUsuarioGeneral(ObjectoEntidad);

                    MessageBox.Show("El Usuario Fue Creado Correctamente", "Usuario Creado");
                    
                    ListVisits Visits = new ListVisits();

                    Visits.Show();

                    this.Hide();


                }
                catch (Exception ex)
                {


                    MessageBox.Show("El Usuario No Pudo Crearse" + ex, "Error: Usuario No Creado");


                }


            }
        }

        private void SelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectUser.Text == "Administrador") {


                CN_Visitantes ObjectoNegocio = new CN_Visitantes();

                String Users = ObjectoNegocio.ContarUsuarioAdmin("");

                int CountUsers = Convert.ToInt32(Users) + 1;

                UserCode.Text = "Itla@Admid-0" + CountUsers.ToString();



            }

            if(SelectUser.Text == "General") {



                CN_Visitantes ObjectoNegocio = new CN_Visitantes();

                String Users = ObjectoNegocio.ContarUsuarioGeneral("");

                int CountUsers = Convert.ToInt32(Users) + 1;

                UserCode.Text = "Itla@General-0" + CountUsers.ToString();



            }
        }
    }
}
