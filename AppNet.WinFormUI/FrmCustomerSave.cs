using AppNet.Bussines;
using AppNet.Bussines.Utilities;
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
    public partial class FrmCustomerSave : Form
    {
        private readonly ICustomerService _CustomerService;
        //private readonly FileLogger _Lg;
        public FrmCustomerSave(ICustomerService customerService)
        {
            InitializeComponent();
            this._CustomerService = customerService;
            //this._Lg = lg;
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtTcVergiNo.Text.TcVerify())
                {
                    MessageBox.Show("T.C. Kimlik Numarsı Hatalı");
                    //_Lg.AddLog($"{txtTcVergiNo.Text} Hatalı TC eklenmeye çalışıldı.");
                    return;
                }
                txtName.Text.NullOrEmpty(nameof(txtName.Text));
                txtLastName.Text.NullOrEmpty(nameof(txtLastName.Text));


                if (radioTuzel.Checked)
                {
                    CustomerTuzel customerTuzel = new CustomerTuzel
                    {
                        SirketName = txtName.Text,
                        Vergino = txtTcVergiNo.Text,
                        Address = txtAdress.Text,
                        Phone = txtPhone.Text
                    };
                    _CustomerService.Add(customerTuzel);
                    Loggers.LoggerWrite($"{txtLastName.Text} tüzel müşteri eklendi!!!", 1);
                    MessageBox.Show($"{txtLastName.Text} tüzel müşteri eklendi!!!");
                    ClearForm();
                }
                else
                {
                    CustomerGercek customerGercek = new CustomerGercek
                    {
                        Name = txtName.Text,
                        LastName = txtLastName.Text,
                        Tc = txtTcVergiNo.Text,
                        Address = txtAdress.Text,
                        Phone = txtPhone.Text
                    };
                    _CustomerService.Add(customerGercek);
                    Loggers.LoggerWrite($"{txtLastName.Text} {txtLastName.Text} müşteri eklendi!!!", 1);
                    MessageBox.Show($"{txtLastName.Text} {txtLastName.Text} müşteri eklendi!!!");
                    ClearForm();
                }



                //_Lg.AddLog($"{txtName.Text} {txtLastName} müşteri eklendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata!");
                Loggers.LoggerWrite("Customer kayıt işleminde hata oluştu(Hata:"+ex.Message+")", 1);
            }
        }

        private void radioGercek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGercek.Checked) lblTcVergino.Text = "T.C. Kimlik No";
            else lblTcVergino.Text = "Vergi No";
        }

        private void radioTuzel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTuzel.Checked) lblTcVergino.Text = "Vergi No";
            else lblTcVergino.Text = "T.C. Kimlik No";
        }
        private void ClearForm()
        {
            txtAdress.Text = "";
            txtCustomerId.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtTcVergiNo.Text = "";
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
