using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppUsersWithPicture
{
    internal class Database
    {
        static public MySqlCommand cmd;
        static public MySqlConnection connection;
        public Database(string server = "localhost", string user = "root", string password = "", string db = "felhasznalok")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            connection = new MySqlConnection(builder.ConnectionString);
            if (Kapcsolat())
            {
                cmd = connection.CreateCommand();
            }
        }

        public List<felhasznalok> getAllFelhasznalo()
        {
            List<felhasznalok> list = new List<felhasznalok>();
            cmd.CommandText = "SELECT * FROM `felhasznalok`;";
            Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    felhasznalok felhasznalo = new felhasznalok(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("szuletes"), dr.GetString("kep"));
                    list.Add(felhasznalo);
                }
            }
            Close();
            return list;
        }
        private void Open()
        {

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void Close()
        {

            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        private bool Kapcsolat()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal bool insertFelhasznalo(felhasznalok insertFelhasznalo)
        {
            cmd.CommandText = "INSERT INTO `felhasznalok`(`id`, `nev`, `szuletes`, `kep`) VALUES (null, @nev,@szuletes,@kep)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", insertFelhasznalo.Nev);
            cmd.Parameters.AddWithValue("@szuletes", insertFelhasznalo.Szuletes);
            cmd.Parameters.AddWithValue("@kep", insertFelhasznalo.Kep);
            Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }

        internal bool updateFelhasznalok(felhasznalok updateFelhasznalok)
        {
            cmd.CommandText = "UPDATE `felhasznalok` SET nev = @nev, szuletes = @szuletes, kep = @kep WHERE id = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Program.mainForm.textBox_id.Text);
            cmd.Parameters.AddWithValue("@nev", Program.mainForm.textBox_nev.Text);
            cmd.Parameters.AddWithValue("@szuletes", Program.mainForm.dateTimePicker_szuletes.Text);
            cmd.Parameters.AddWithValue("@kep", Program.mainForm.textBox_kep_neve.Text);

            Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }

        internal bool deleteFelhasznalok(felhasznalok deleteFelhasznalok)
        {
            cmd.CommandText = "DELETE FROM `felhasznalok` WHERE `id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Program.mainForm.textBox_id.Text);
            Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }
    }
}
