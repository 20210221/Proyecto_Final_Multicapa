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
    public partial class ConfigRegistre : Form
    {

        private bool Editarse = false;

        private String Code = "";

        public ConfigRegistre()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ListVisits Visits = new ListVisits();

            Visits.Show();

            this.Hide();


        }

        private void ConfigRegistre_Load(object sender, EventArgs e)
        {
            MostarBuscarTablaConfig("");

            
        }

        public void MostarBuscarTablaConfig(String buscar)
        {

            CN_Visitantes ObjectoNegocio = new CN_Visitantes();

            TablaConfig.DataSource = ObjectoNegocio.ListarLugar(buscar);

            TablaConfig.Columns[0].Visible = false;

            TablaConfig.Columns[1].Visible = false;

            TablaConfig.Columns[2].Visible = false;

            TablaConfig.Columns[3].Visible = false;

            TablaConfig.Columns[4].Visible = false;

            TablaConfig.Columns[5].Visible = false;

            TablaConfig.Columns[6].Visible = false;

            TablaConfig.Columns[7].Visible = false;

            TablaConfig.Columns[8].Visible = false;

            TablaConfig.Columns[9].Width = 250;

            TablaConfig.Columns[10].Width = 250;

            TablaConfig.ClearSelection();

            EdificioLugar.Enabled = false;

            AulaLugar.Enabled = false;

            EdificioLugar.Text = "";

            AulaLugar.Text = "";


        }

        private void btnAddLugar_Click(object sender, EventArgs e)
        {
            EdificioLugar.Enabled = true;

            AulaLugar.Enabled = true;

            EdificioLugar.Text = "";

            AulaLugar.Text = "";

            btnSaveLugar.Enabled = true;
        }

        private void btnEditLugar_Click(object sender, EventArgs e)
        {
            if (TablaConfig.SelectedRows.Count > 0) {

                Editarse = true;

                EdificioLugar.Enabled = true;

                AulaLugar.Enabled = true;

                btnSaveLugar.Enabled = true;

                Code = TablaConfig.CurrentRow.Cells[8].Value.ToString();

                EdificioLugar.Text = TablaConfig.CurrentRow.Cells[9].Value.ToString(); 

                AulaLugar.Text = TablaConfig.CurrentRow.Cells[10].Value.ToString();

                
            }

            else
            {

                MessageBox.Show("Seleccione La Fila Que Quiere Editar", "Editar Fila");
            }
        }

        private void btnSaveLugar_Click(object sender, EventArgs e)
        {
            if (EdificioLugar.Text == "" || AulaLugar.Text == "")
            {


                MessageBox.Show("Complete Todos Los Campos Para Guardar Los Cambios", "Campos Vacios");

                return;

            }


            if (Editarse == false)
            {

                try
                {
                    CE_Visitantes ObjectoEntidad = new CE_Visitantes();

                    CN_Visitantes ObjectoNegocio = new CN_Visitantes();

                    ObjectoEntidad.EdificioLugar = EdificioLugar.Text;

                    ObjectoEntidad.AulaLugar = AulaLugar.Text;


                    ObjectoNegocio.InsertarLugar(ObjectoEntidad);

                    MessageBox.Show("El Registro Fue Guardado Correctamente", "Registro Guardado");

                    MostarBuscarTablaConfig("");

                    btnSaveLugar.Enabled = false;


                }
                catch (Exception ex)
                {


                    MessageBox.Show("El Registro No Pudo Guardarse" + ex, "Error: Registro No Guardado");


                }



            }


            if (Editarse == true)
            {

                try
                {

                    CE_Visitantes ObjectoEntidad = new CE_Visitantes();

                    CN_Visitantes ObjectoNegocio = new CN_Visitantes();

                    ObjectoEntidad.CodeLugar = Code;

                    ObjectoEntidad.EdificioLugar = EdificioLugar.Text;

                    ObjectoEntidad.AulaLugar = AulaLugar.Text;

                   

                    ObjectoNegocio.EditarLugar(ObjectoEntidad);

                    MessageBox.Show("El Registro Fue Actualizado Correctamente", "Registro Actualizado");

                    MostarBuscarTablaConfig("");

                    btnSaveLugar.Enabled = false;

                    Editarse = false;


                }
                catch (Exception ex)
                {


                    MessageBox.Show("El Registro No Pudo Actualizarse" + ex, "Error: Registro No Actualizado");


                }
            }
        }
    }
}
