using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain.Entities.Concrete;
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
    public partial class FrmCategorySave : Form
    {
        private readonly CategoriService _CategoriService;
        public FrmCategorySave()
        {
            InitializeComponent();
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            if (txtCategoriName.Text.Length < 2)
            {
                MessageBox.Show("Kategori adı zorunlu!!!");
            }
            else
            {
                Category category = new Category { CategoryName = txtCategoriName.Text.Trim() };
                var result= _CategoriService.Add(category);
                MessageBox.Show($"{result.CategoryName} Kaydedildi.");
                txtCategoriName.Text = "";
            }

        }
    }
}
