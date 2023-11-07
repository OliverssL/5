using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PrecuDatubaze_OL_ZV
{
    public partial class Form3 : Form
    {
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn = null;

            try
            {
                sqlite_conn = new SQLiteConnection("Data Source=Datubaze.db; Version=3; New=True; Compress=True;");
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return sqlite_conn;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Vards";

                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    dataGridView1.DataSource = sTable;
                }

            }
        }
    }
}

