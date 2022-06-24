using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Notification;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class FrmLogin : Form
    {
        private readonly IProductService _ProductService;
        private readonly IServiceProvider sp;
        public FrmLogin(ProductService ProductService, IServiceProvider sp)
        {
            this._ProductService = ProductService;
            this.sp = sp;
        }
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //var dashBoard=sp.GetRequiredService<FrmEmployee>();
            var form = sp.GetRequiredService<FrmEmployee>();
            form.Show();
            //var loginFrm = sp.GetRequiredService<FrmLogin>();
            //Application.Run(loginFrm);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SentTelegram sent = new SentTelegram();
            sent.TelegramMesjGonder("telegram test mesaj");
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