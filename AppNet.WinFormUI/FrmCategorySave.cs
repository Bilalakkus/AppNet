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
        private readonly ICategoriService _CategoriService;
        public FrmCategorySave(ICategoriService categoriService)
        {
            InitializeComponent();
            this._CategoriService = categoriService;
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoriName.Text.Length < 2)
                {
                    MessageBox.Show("Kategori adı zorunlu!!!");
                }
                else
                {
                    Category category = new Category { CategoryName = txtCategoriName.Text };
                    _CategoriService.Add(category);
                    MessageBox.Show($"{txtCategoriName.Text} kategorisi eklendi!!!");
                    txtCategoriName.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem gerçekleştirilemedi!!!");
            }

        }

        private void FrmCategorySave_Load(object sender, EventArgs e)
        {

        }
    }
}
