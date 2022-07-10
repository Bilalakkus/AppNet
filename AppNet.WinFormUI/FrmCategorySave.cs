using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Bussines.Validation;
using AppNet.Domain;
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
        public FrmCategorySave(IServiceProvider sp, ICategoriService categoriService)
        {
            this._sp = sp;
            this._categoriService = categoriService;
            InitializeComponent();

        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            try
            {
                txtCategoriName.Text.NullOrEmpty(nameof(txtCategoriName.Text));
                if (btnCategorySave.Text == "Kaydet")
                    {
                        Category category = new Category { CategoryName = txtCategoriName.Text };
                        _categoriService.Add(category.CategoryName);
                        MessageBox.Show($"{txtCategoriName.Text} kategorisi eklendi!!!");
                        Loggers.LoggerWrite($"{txtCategoriName.Text} kategorisi eklendi!!!", 1);
                        txtCategoriName.Text = "";
                    }
                    else
                    {
                        _categoriService.Update(Convert.ToInt32(txtCategoryId.Text), txtCategoriName.Text);
                        Loggers.LoggerWrite($"{txtCategoriName.Text} kategorisi güncellendi!!!", 1);
                        var frmCategoriList = _sp.GetService(typeof(FrmCategoryList)) as FrmCategoryList;
                        frmCategoriList.Show();
                        this.Close();
                    }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!");
                Loggers.LoggerWrite("Customer kayıt işleminde hata oluştu(Hata:" + ex.Message + ")", 1);
            }

        }
        private void FrmCategorySave_Load(object sender, EventArgs e)
        {

        }
    }
}
