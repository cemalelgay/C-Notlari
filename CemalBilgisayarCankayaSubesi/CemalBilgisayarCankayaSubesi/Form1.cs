using CemalBilgisayarCankayaSubesi.DB_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemalBilgisayarCankayaSubesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (cemalDBCon con = new cemalDBCon())
            {
                //var result = con.Urunlers.ToList();
                //dataGridView1.DataSource = result;

                dataGridView1.DataSource = con.Urunlers.ToList();
            }
        }
    }
}
