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
        private readonly IServiceProvider _sp;
        private readonly ICategoriService _categoriService;
        //private readonly FileLogger _lg;
        public FrmCategorySave(IServiceProvider sp, ICategoriService categoriService)
        {
            this._sp = sp;
            this._categoriService = categoriService;
            //this._lg = lg;
            InitializeComponent();

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
                    if (btnCategorySave.Text == "Kaydet")
                    {
                        Category category = new Category { CategoryName = txtCategoriName.Text };
                        _categoriService.Add(category.CategoryName);
                        MessageBox.Show($"{txtCategoriName.Text} kategorisi eklendi!!!");
                        //_lg.AddLog($"{txtCategoriName.Text} kategorisi eklendi!!!");
                        txtCategoriName.Text = "";
                    }
                    else
                    {
                        _categoriService.Update(Convert.ToInt32(txtCategoryId.Text), txtCategoriName.Text);
                        var frmCategoriList = _sp.GetService(typeof(FrmCategoryList)) as FrmCategoryList;
                        frmCategoriList.Show();
                        this.Close();
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception xe)
            {

                MessageBox.Show("İşlem gerçekleştirilemedi!!!");
                //_lg.AddLog($"{txtCategoriName.Text} kategorisi eklenemedi kategorisi eklendi. (Hata:{xe.Message})");
            }

        }

        private void FrmCategorySave_Load(object sender, EventArgs e)
        {

        }
    }
}
