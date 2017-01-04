using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniPortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBoxKisiSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxKisiSec.SelectedIndex.Equals(0))
            {
                OgrenciForm frm = new OgrenciForm();
                frm.ShowDialog();
            }
            else if (ComboBoxKisiSec.SelectedIndex.Equals(1))
            {
                AkademisyenForm frm = new AkademisyenForm();
                frm.ShowDialog();
            }
          
        }
    }
}
