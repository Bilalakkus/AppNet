using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class FrmProductSave : Form
    {
        private readonly IServiceProvider _sp;
        private readonly IProductService _productService;
        private readonly ICategoriService _categoriService;
        //private readonly FileLogger _lg;
        public FrmProductSave(IServiceProvider sp, IProductService productService, ICategoriService categoriService)
        {
            this._sp = sp;
            this._productService = productService;
            //this._lg = lg;
            this._categoriService = categoriService;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbCategories.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen kategori seçiniz.", "Uyarı!!!");
                return;
            }
            if (txtProductName.Text.Trim().Length < 2)
            {
                MessageBox.Show("Ürün adını giriniz.", "Uyarı!!!");
                return;
            }
            if (btnSave.Text == "Kaydet")
            {
                var IMG = pictureProduct.Image;
                Product product = new Product
                {
                    ProductName = txtProductName.Text,
                    Stock = Convert.ToInt32(txtStock.Text),
                    StockMin = Convert.ToInt16(txtStockMin.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    CategoryId = Convert.ToInt32(cmbCategories.SelectedValue),
                    ImgPath = lblImgPath.Text,
                    AddingId = 1,
                    IsItPassive = true,
                    Type = "",
                    CreateDate = DateTime.Now,
                };
                _productService.Add(product);
                MessageBox.Show("Kayıt başarılı.", "Bilgi mesajı");
                //_lg.AddLog($"{txtProductName.Text} ürünü eklendi!!!",1);
                ClearForm();
            }
            else
            {
                var IMG = pictureProduct.Image;
                Product product = new Product
                {
                    ProductId = Convert.ToInt32(txtId.Text.Trim()),
                    ProductName = txtProductName.Text,
                    Stock = Convert.ToInt32(txtStock.Text),
                    StockMin = Convert.ToInt16(txtStockMin.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    CategoryId = Convert.ToInt32(cmbCategories.SelectedValue),
                    ImgPath = lblImgPath.Text,
                    AddingId = 1,
                    IsItPassive = true,
                    Type = "",
                    CreateDate = DateTime.Now,
                };
                _productService.Update(product);
                MessageBox.Show("Güncelleme başarılı.", "Bilgi mesajı");
                //_lg.AddLog($"{txtProductName.Text} ürünü eklendi!!!",1);
                ClearForm();
            }


        }

        private async void FrmProductSave_Load(object sender, EventArgs e)
        {
            //cmbCategories.Items.Clear();
            var list = (await _categoriService.GetAll()).OrderBy(c => c.CategoryName).ToList();
            list.Insert(0, new Category { CategoryId = 0, CategoryName = "Seçiniz" });
            cmbCategories.DataSource = list;
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            cmbCategories.SelectedIndex = 0;
            txtProductName.Text = "";
            txtStock.Text = "";
            txtStockMin.Text = "";
            txtUnitPrice.Text = "";
            pictureProduct.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opnfd = new OpenFileDialog();
            //opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            //if (opnfd.ShowDialog() == DialogResult.OK)
            //{
            //    pictureProduct.Image = new Bitmap(opnfd.FileName);
            //}
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            file.ShowDialog();
            string filePath = file.FileName;
            lblImgPath.Text = filePath;
            pictureProduct.ImageLocation = filePath;
        }
    }
}
