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
    public partial class ListVisits : Form
    {

        public String UserNav;

        public ListVisits()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login Login = new Login();

            Login.Show();

            this.Hide();


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CreateVisits CreateVisits = new CreateVisits();

            CreateVisits.Show();

            CreateVisits.BackUser(UserNav);

            this.Hide();


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            if (bunifuFlatButton2.Enabled == false) { return; }

            ConfigRegistre ConfigRegistre = new ConfigRegistre();

            ConfigRegistre.Show();

            this.Hide();


        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            if (bunifuFlatButton3.Enabled == false) { return; }
            
            CreateUsers CreateUsers = new CreateUsers();

            CreateUsers.Show();

            this.Hide();


        }

        private void ListVisits_Load(object sender, EventArgs e)
        { 

            MostarBuscarTablaVisitantes("");

            TablaVisitantes.Columns[0].Visible = false;

            TablaVisitantes.Columns[1].Visible = false;

            TablaVisitantes.Columns[2].Visible = false;

            TablaVisitantes.Columns[3].Visible = false;

            TablaVisitantes.Columns[4].Visible = false;

            TablaVisitantes.Columns[5].Visible = false;

            TablaVisitantes.Columns[6].Visible = false;

            TablaVisitantes.Columns[7].Visible = false;

            TablaVisitantes.Columns[8].Visible = false;

            TablaVisitantes.Columns[9].Visible = false;

            TablaVisitantes.Columns[10].Visible = false;


            
        }

        public void MostarBuscarTablaVisitantes(String buscar)
        {

            CN_Visitantes ObjectoNegocio = new CN_Visitantes();

            TablaVisitantes.DataSource = ObjectoNegocio.ListarVisitantes(buscar);

            TablaVisitantes.ClearSelection();

            TablaVisitantes.CurrentCell = null;

        }


       


        public void TypeUser(String type)
        {

           

            if (type == "Admin")
            {

                bunifuFlatButton2.Enabled = true;

                bunifuFlatButton3.Enabled = true;

                UserNav = "Admin";
                

            }

            else
            {

                bunifuFlatButton2.Enabled = false;

                bunifuFlatButton3.Enabled = false;

                UserNav = "General";

                
            }

        }
    }
}
