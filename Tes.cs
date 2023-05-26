using System;
using System.Windows.Forms;

namespace CRUD_MYSQL
{
    public partial class Tes : Form 
    {
        public Tes()
        {
            InitializeComponent();
        }

        private void Tes_Load(object sender, EventArgs e)
        {
            LoadBarang();
            AddButton();
        }

        //CLICK CONTROLLER

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_nama.Text) || String.IsNullOrEmpty(txt_satuan.Text) || String.IsNullOrEmpty(txt_jumlah.Text))
            {
                MessageBox.Show("Tolong Isi Semua Input");
            }
            else
            {
                Action.Kirim(connection.SQL_insertBarang, txt_id.Text, txt_nama.Text, txt_satuan.Text, txt_jumlah.Text);
                Tes_Load(sender, e);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_nama.Text) || String.IsNullOrEmpty(txt_satuan.Text) || String.IsNullOrEmpty(txt_jumlah.Text))
            {
                MessageBox.Show("Tolong Isi Semua Input");
            }
            else
            {
                Action.Kirim(connection.SQL_updateBarang, txt_id.Text, txt_nama.Text, txt_satuan.Text, txt_jumlah.Text);
                Tes_Load(sender, e);
            }
        }

        //LOAD SOME VALUE AND PROPERTIES

        void AddButton()
        {
            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Name = "Edit",
                Text = "Edit"
            };
            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Name = "Delete",
                Text = "Delete"
            };
            DGV.Columns.Add(colDelete);
            DGV.Columns.Add(colEdit);
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = DGV.Rows[e.RowIndex];

            if (rows.Cells[e.ColumnIndex].Value.ToString() == "Edit")
                FillInputsBarang(
                    rows.Cells[0].Value.ToString(),
                    rows.Cells[1].Value.ToString(),
                    rows.Cells[2].Value.ToString(),
                    rows.Cells[3].Value.ToString());

            if (rows.Cells[e.ColumnIndex].Value.ToString() == "Delete")
            {
                Action.Remove(connection.SQL_deleteBarang, rows.Cells[0].Value.ToString());
                Tes_Load(sender, e);
            }
                
        }

        //LOAD SOME DATA FROM TB BARANG

        void LoadBarang()
        {
            DGV.Columns.Clear();

            Action.fillAllData(DGV, connection.SQL_showAllBarang);
            DGV.Columns[0].Visible = false;
        }

        void FillInputsBarang(string id, string nama, string satuan, string jumlah)
        {
            txt_id.Text = id; txt_jumlah.Text = jumlah; txt_nama.Text = nama; txt_satuan.Text = satuan;
        }

        private void Tes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
