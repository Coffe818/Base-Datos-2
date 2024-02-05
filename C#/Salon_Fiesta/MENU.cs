using MySql.Data.MySqlClient;
using Salon_Fiesta.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Fiesta
{
    public partial class MENU : Form
    {
      
        Conexion Conexion = new Conexion();
       
        public MENU()
        {
            InitializeComponent();
        }// end iniciador


        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            
            
            if (Conexion.ConexionValida())
            {
                this.Hide();
                ConsultarTablas ConsultarTablas = new ConsultarTablas();
                ConsultarTablas.FormClosed += (s, args) => this.Show();
                ConsultarTablas.FormClosed += (s, args) => Conexion.Desconectar();
                ConsultarTablas.ShowDialog();
            }// end if para validar

        }// end buttonConsultar_Click

        private void buttonInsertar_Click(object sender, EventArgs e)
        {

        }// end buttonInsertar_Click

        private void buttonBorrar_Click(object sender, EventArgs e)
        {

        }// end buttonBorrar_Click
    }// end class
}// end namespace
