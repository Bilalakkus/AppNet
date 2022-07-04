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
        private readonly IProductService _productService;
        private readonly Logger _lg;
        public FrmProductSave(IProductService productService,Logger lg)
        {
            InitializeComponent();
            this._productService = productService;
            this._lg = lg;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName=txtProductName.Text,
                Stock= Convert.ToInt32(txtStock.Text),
                StockMin= Convert.ToInt16(txtStockMin),
                UnitPrice= Convert.ToDecimal(txtUnitPrice.Text)
            };
            _productService.Add(product);
            _lg.AddLog($"{txtProductName.Text} ürünü eklendi!!!");
        }
    }
}
