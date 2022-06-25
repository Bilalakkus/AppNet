using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
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
        private readonly Logger _Lg;
        public FrmCategorySave(ICategoriService categoriService, Logger lg)
        {
            InitializeComponent();
            this._CategoriService = categoriService;
            this._Lg=lg;
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
                    _Lg.AddLog($"{txtCategoriName.Text} kategorisi eklendi!!!");
                    txtCategoriName.Text = "";
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception xe)
            {

                MessageBox.Show("İşlem gerçekleştirilemedi!!!");
                _Lg.AddLog($"{txtCategoriName.Text} kategorisi eklenemedi kategorisi eklendi. (Hata:{xe.Message})");
            }

        }

        private void FrmCategorySave_Load(object sender, EventArgs e)
        {

        }
    }
}
