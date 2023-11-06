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

        private void Pierakstīties_Click(object sender, EventArgs e)
        {
            {
                if (Vards.Text != "")
                {
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "INSERT INTO Vārds (Vārds) VALUES('"Vards.Text + "');";
                    sqlite_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Lūdzu ievadien jūsu Vārdu");
                }


            }
        }
    }
}
