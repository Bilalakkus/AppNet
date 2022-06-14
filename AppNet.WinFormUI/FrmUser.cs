using AppNet.Infrastructer.Notification;

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
            FrmEmployee frmEmployee = new FrmEmployee();
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