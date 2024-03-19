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
    public partial class Form1 : Form
    {
        string baglantiMetni = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";

      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglantiMetni))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM filmler;";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwFilmler.DataSource = dt;
            }
        }

        private void btnelesriri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
