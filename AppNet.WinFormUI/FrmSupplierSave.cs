using AppNet.Bussines.Abstract;
using AppNet.Bussines.Validation;
using AppNet.Domain;
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
    public partial class FrmSupplierSave : Form
    {
        private readonly IServiceProvider _sp;
        private readonly ISuplierService _supperlierService;
        public FrmSupplierSave(IServiceProvider sp, ISuplierService suplierService)
        {
            this._sp = sp;
            this._supperlierService = suplierService;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            txtSuplierName.Text.NullOrEmpty(nameof(txtSuplierName.Text));
            try
            {
                Supplier supplier = new Supplier
                {
                    SupplierName = txtSuplierName.Text,
                    Phone = txtPhone.Text
                };
                _supperlierService.Add(supplier);
                MessageBox.Show($"{txtSuplierName.Text} tedarikçisi eklendi!!!");
                Loggers.LoggerWrite($"{txtSuplierName.Text} tedarikçisi eklendi!!!", 1);
                txtSuplierName.Text = "";
                txtPhone.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata!");
                Loggers.LoggerWrite("Customer kayıt işleminde hata oluştu(Hata:" + ex.Message + ")", 1);
            }
        }
    }
}
