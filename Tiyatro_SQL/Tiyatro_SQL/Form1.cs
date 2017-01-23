using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiyatro_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Server=ALS-YG39104-J12;Database=Tiyatro;UID=sa;PWD=123456789?");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Tiyatro_1", baglan);
            
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Tiyatro_1 (OyunAdı, Yönetmen, Senarist, Oyuncular,ID) VALUES (@OyunAdi,@Yönetmen,@Senarist,@OyuncuListesi,@ID)", baglan);
            cmd.Parameters.AddWithValue("@OyunAdi", TxtOyunadi.Text);
            cmd.Parameters.AddWithValue("@Yönetmen", TxtYonetmen.Text);
            cmd.Parameters.AddWithValue("@Senarist", TxtSenarist.Text);
            cmd.Parameters.AddWithValue("@OyuncuListesi", TxtOyuncuListesi.Text);
            cmd.Parameters.AddWithValue("@ID",TxtID.Text);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            Form1_Load(sender, e);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Tiyatro WHERE ID="+TxtID.Text,baglan);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            Form1_Load(sender, e);
        }
    }
}
