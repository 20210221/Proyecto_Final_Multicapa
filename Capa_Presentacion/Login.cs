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

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
      

        public Login()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            SelectLogin.Items.Add("General");

            SelectLogin.Items.Add("Administrador");

            SelectLogin.SelectedIndex = 0;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           


            if (LoginUser.Text == "") {

                MessageBox.Show("Introduzca Su Código de Usuario", "Usuario Vacio");

                return;

             
            }

            if (SelectLogin.Text == "Administrador") {

                CN_Visitantes ObjectoNegocio = new CN_Visitantes();


               String Access = ObjectoNegocio.BuscarUsuarioAdmid(LoginUser.Text);


                if (Access == "Open") {

                    ListVisits Visits = new ListVisits();

                    Visits.Show();

                    Visits.TypeUser("Admin");

                    this.Hide();


                }

                else {

                    MessageBox.Show("No Se Ha Encontrado Ningún Usuario Administrador Con Ese Código", "Usuario No Encontrado");

                    return;
                }


               
            }

            if (SelectLogin.Text == "General") {



                CN_Visitantes ObjectoNegocio = new CN_Visitantes();


                String Access = ObjectoNegocio.BuscarUsuarioGeneral(LoginUser.Text);


                if (Access == "Open")
                {

                    ListVisits Visits = new ListVisits();

                    Visits.Show();

                    Visits.TypeUser("General");

                    this.Hide();


                }

                else
                {

                    MessageBox.Show("No Se Ha Encontrado Ningún Usuario General Con Ese Código", "Usuario No Encontrado");

                    return;
                }




            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
