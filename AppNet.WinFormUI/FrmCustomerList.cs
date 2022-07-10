using AppNet.Bussines;
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
    public partial class FrmCustomerList : Form
    {
        private readonly IServiceProvider _sp;
        private readonly ICustomerService _customerService;
        public FrmCustomerList(IServiceProvider sp, ICustomerService customerService)
        {
            this._sp = sp;
            this._customerService = customerService;
            InitializeComponent();
        }
        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private async void LoadCustomer()
        {
            var list = (await _customerService.GetAll()).OrderBy(c => c.Name).ToList();
            gridCustomerList.DataSource = list;
        }

        private async void btnCustomerFilter_Click(object sender, EventArgs e)
        {
            if (cmbCustomerType.SelectedIndex==1)
            {
                
            }
            if (txtTcVergiNo.Text.Length>=10)
            {
                
            }
            if (txtName.Text.Length>=3)
            {
                    var list = (await _customerService.GetAll()).OrderBy(c => c.Name == txtName.Text.Trim()).ToList();
                    gridCustomerList.DataSource = list;
            }
        }
    }
}
