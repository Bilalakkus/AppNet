using AppNet.Bussines;
using AppNet.Bussines.Utilities;
using AppNet.Bussines.Validation;
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
    public partial class FrmCustomerSave : Form
    {
        private readonly ICustomerService _CustomerService;
        private readonly Logger _Lg;
        public FrmCustomerSave(ICustomerService customerService, Logger lg)
        {
            InitializeComponent();
            this._CustomerService = customerService;
            this._Lg = lg;
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtTcVergiNo.Text.TcVerify())
                {
                    MessageBox.Show("T.C. Kimlik Numarsı Hatalı");
                    _Lg.AddLog($"{txtTcVergiNo.Text} Hatalı TC eklenmeye çalışıldı.");
                    return;
                }
                txtName.Text.NullOrEmpty(nameof(txtName.Text));
                txtLastName.Text.NullOrEmpty(nameof(txtLastName.Text));
                Customer customer = new Customer
                {
                    Name = txtName.Text,
                    //TC=txtTcVergiNo.Text,
                    Address = txtAdress.Text,
                    Phone = txtPhone.Text,
                    
                    
                };
                _CustomerService.Add(customer);
                _Lg.AddLog($"{txtName.Text} {txtLastName} müşteri eklendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("T.C. Kimlik Numarsı Hatalı");
            }
        }
    }
}
