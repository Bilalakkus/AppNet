using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Notification;
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
    public partial class FrmProductList : Form
    {
        private readonly IServiceProvider _sp;
        private readonly IProductService _productService;
        private readonly ICategoriService _categoriService;
        //private readonly FileLogger _lg;
        public FrmProductList(IServiceProvider sp, IProductService productService, ICategoriService categoriService)
        {
            InitializeComponent();
            this._sp = sp;
            this._productService = productService;
            this._categoriService = categoriService;
        }
        private async void FrmProductList_Load(object sender, EventArgs e)
        {
            //cmbCategories.Items.Clear();
            var list = (await _categoriService.GetAll()).OrderBy(c => c.CategoryName).ToList();
            list.Insert(0, new Category { CategoryId = 0, CategoryName = "Seçiniz" });
            cmbCategorySearch.DataSource = list;
            cmbCategorySearch.DisplayMember = "CategoryName";
            cmbCategorySearch.ValueMember = "CategoryId";

            //LoadGridData();
            var productList = (await _productService.GetAll()).OrderBy(p => p.ProductName).ToList();
            dtGridProduct.DataSource = productList;
        }
        public async void LoadGridData()
        {
            var product = (await _productService.GetAll()).ToList();
            var data = from q in product
                       orderby q.ProductName ascending
                       select new Product
                       {
                           ProductId = q.ProductId,
                           ProductName = q.ProductName,
                           CategoryId = q.CategoryId
                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
        }
        private void AddRowToGrid(Product model)
        {
            DataGridViewRow row = (DataGridViewRow)dtGridProduct.Rows[0].Clone();
            row.Cells[0].Value = model.ProductId;
            row.Cells[1].Value = model.Category.CategoryName;
            row.Cells[2].Value = model.ProductName;
            dtGridProduct.Rows.Add(row);
        }

        private void dtGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            txtProductName.Text= dtGridProduct.CurrentRow.Cells[1].Value.ToString();
            txtStock.Text = dtGridProduct.CurrentRow.Cells[6].Value.ToString();
            txtStockMin.Text = dtGridProduct.CurrentRow.Cells[5].Value.ToString();
            txtUnitPrice.Text = dtGridProduct.CurrentRow.Cells[3].Value.ToString();
            pictureProduct.ImageLocation=dtGridProduct.CurrentRow.Cells[4].Value.ToString();
            txtPtoductId.Text= dtGridProduct.CurrentRow.Cells[0].Value.ToString();


        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"{txtProductName.Text} ürününü silmek istediğinizden emin misiniz?",
                 "Silme Onayı!",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _productService.Remove(Convert.ToInt32(txtPtoductId.Text));
                //_lg.AddLog($"{txtProductName.Text} ürünü silindi.",1);
                SentTelegram sent = new SentTelegram();
                sent.TelegramMesjGonder($"{txtProductName.Text} ürünü silindi.");
                LoadGridData();
            }
        }
    }
}
