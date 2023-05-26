using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUD_MYSQL
{
    internal class Action : connection
    {
        private static DataTable getAllData(string sql)
        {
            DataTable dt = new DataTable();

            dt.Reset();
            dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand(sql, cnn);

            cnn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            cnn.Close();
            return dt;
        }    

        public static DataGridView fillAllData(DataGridView DGV, string sql)
        {
            DGV.DataSource = getAllData(sql);
            return DGV;
        }

        public static void Kirim(string sql ,string id, string input1, string input2, string input3)
        {
            MySqlCommand cmd;
            cnn.Open();

            try
            {
                cmd = cnn.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@input1", input1);
                cmd.Parameters.AddWithValue("@input2", input2);
                cmd.Parameters.AddWithValue("@input3", input3);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Proses Berhasil");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cnn.Close();
        }

        public static void Remove(string sql, string id)
        {
            MySqlCommand cmd;
            cnn.Open();

            try
            {
                cmd = cnn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cnn.Close();
        }

        public static void Login(string sql, string username, string password)
        {
            DataTable dt = new DataTable();

            dt.Reset();
            dt = new DataTable();

            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cnn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Login Gagal");
            }
            else
            {
                MessageBox.Show("Login Berhasil");
                connection.Session = true;
            }
            cnn.Close();
        }
    }
}
