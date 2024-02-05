using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salon_Fiesta;
using static System.Windows.Forms.DataFormats;
using Salon_Fiesta.Classes;


namespace Salon_Fiesta
{
    public partial class ConsultarTablas : Form
    {
        private MySqlConnection conexion;
        String NombreTabla;
        Conexion Conexion = new Conexion();

        public ConsultarTablas()
        {
            InitializeComponent();
            //evita que modifiquen el nombre de las rablas
            cmbTabla.DropDownStyle = ComboBoxStyle.DropDownList;
        } // end iniciador

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbTabla.SelectedIndex;
            NombreTabla = cmbTabla.Items[indice].ToString();
        }// end cmbTabla_SelectedIndexChangedcmbTabla_SelectedIndexChanged

        private void buttonCons_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = Conexion.Conectar();
            String sql = "SELECT * FROM salon_fiesta."+NombreTabla+";";
            // se crea el select (mejorar para evitar el *)

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = sql;

                DataSet dsResultado = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                adapter.SelectCommand = cmd;
                adapter.Fill(dsResultado, "res");

                dgvConsulta.DataSource = dsResultado;
                dgvConsulta.DataMember = "res";
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }// end try catch

            Conexion.Desconectar();
        }// end buttonCons_Click


    }// end class
}// end namespace
