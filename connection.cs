using MySql.Data.MySqlClient;

namespace CRUD_MYSQL
{
    public class connection
    {
        // CHECKING CONNECTION TO DATABASE
        public static MySqlConnection cnn = new MySqlConnection("server=localhost;database=sembako;uid=root;pwd=\"\";");
        public static bool Session;

        // SQL CODE FOR LOGIN
        public static string SQL_login = "SELECT * FROM admin WHERE username=@username AND password=@password";

        // SQL CODE FOR BARANG
        public static string SQL_showAllBarang = "SELECT * FROM barang";
        public static string SQL_insertBarang = "INSERT INTO barang (nama_barang, satuan_barang, jml_barang) VALUES (@input1, @input2, @input3)";
        public static string SQL_updateBarang = "UPDATE barang SET nama_barang=@input1, satuan_barang=@input2, jml_barang=@input3 WHERE idbarang=@id";
        public static string SQL_deleteBarang = "DELETE FROM barang WHERE idbarang=@id";

        // SQL CODE FOR SUPLIER
        public static string SQL_showAllSuplier = "SELECT * FROM suplier";


        // SQL CODE BUAT NAVIGASI
        public static Tes Tes = new Tes();
        public static Login Login = new Login();
    }
}
