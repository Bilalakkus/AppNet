using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Notification;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeService service = new EmployeeService(Repository);

            FrmEmployee frmEmployee = new FrmEmployee(service);
            frmEmployee.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SentTelegram sent = new SentTelegram();
            sent.TelegramMesjGonder("Gülsüm telefonumu ver");
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmCategorySave frmCategorySave = new FrmCategorySave();
            frmCategorySave.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MDIDashboard mDIDashboard = new MDIDashboard();
            mDIDashboard.Show();
        }
    }
}