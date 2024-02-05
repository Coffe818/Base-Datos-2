using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Fiesta.Classes
{
    internal class Conexion
    {
        static string server = "localhost";
        static string port = "3306";
        static string user = "root";
        static string password = "coff818";
        static string database = "salon_fiesta";

        String Cadena = "server=" + server + ";port=" + port + ";user id=" + user + ";password=" + password + ";database=" + database + ";";
        MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection();
        bool seguir = true;

        public MySqlConnection Conectar()
        {
            try
            {
                conn.ConnectionString = Cadena;
                conn.Open();
                seguir = true;
            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                seguir = false;
            }// end try catch
            
            return conn;
        }// end Conectar

        public bool ConexionValida()
        {
            Conectar();
            return seguir;
        }// end ConexionValida

        public void Desconectar()
        {
            conn.Close();
        }// end desconectar
    }// end class
}// end namespace
