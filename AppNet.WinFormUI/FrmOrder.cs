using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNet.WinFormUI
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            txtCount.Text =(Convert.ToInt16(txtCount.Text.Trim()) + 1).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (txtCount.Text!="1")
            {
                txtCount.Text = (Convert.ToInt16(txtCount.Text.Trim()) - 1).ToString();
            }
        }
    }
}
