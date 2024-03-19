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

namespace mysql1575
{
    public partial class Form3 : Form
    {
        string baglantiMetni = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiMetni))
            {
                baglan.Open();
                string sorgu = "SELECT filmler.film_id,filmler.film_ad,filmler.tur,elestiriler.elestiri_metin,elestiriler.elestirmen\r\nFROM filmler\r\nJOIN elestiriler ON filmler.film_id=elestiriler.film_id;\r\n";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
        }
    }
}
