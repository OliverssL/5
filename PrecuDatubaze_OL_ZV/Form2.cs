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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


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

        private void Pierakstīties_Click(object sender, EventArgs e)
        {
            {
                if (Vards.Text != "")
                {
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "INSERT INTO Vards (Vards) VALUES('" + Vards.Text + "');";
                    sqlite_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Lūdzu ievadien jūsu Vārdu");
                }
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();

            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
