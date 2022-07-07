using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Notification;
using AppNet.Infrastructer.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class FrmLogin : Form
    {
        //public delegate void Islemci(int sayi1, int sayi2);
        private readonly IServiceProvider _sp;
        public FrmLogin(IServiceProvider sp)
        {
            InitializeComponent();
            this._sp = sp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var dashBoard=sp.GetRequiredService<FrmEmployee>();
            //var form = sp.GetRequiredService<FrmEmployee>();
            //form.Show();
            //var loginFrm = sp.GetRequiredService<FrmLogin>();
            //Application.Run(loginFrm);
        }
        private async void btnGiris_Click(object sender, EventArgs e)
        {
                //var log = _sp.GetRequiredService<FileLogger>;
                var safe=_sp.GetRequiredService<IOrderService>();
                var emp = _sp.GetRequiredService<IEmployeeService>();
            
            var list = (await emp.GetAll());
            var tempUser = list.SingleOrDefault(e => e.User == txtUser.Text && e.Password == txtPasword.Text);
            if (tempUser == null)
            {
                lblWarning.Text = "Kullanýcý adý veya þifre hatalý!";
                //log.();
                LoggerWrite(AfterGetLogDelegate,"Hatalý kullanýcý giriþi denemesi.", 1);
                //_afterGetLogDelegate();
            }
            else
            {
                //Session.Add("Deger", TextBox1.Text);
                var mdiForm = _sp.GetRequiredService<MDIDashboard>();
                // _lg.AddLog($"{txtUser.Text} kullanýcýsý sisneme giriþ yaptý.");
                mdiForm.ShowDialog();
                this.Close();
            }
        }

        private static void LoggerWrite(AfterGetLogDelegate afterGetLog,string moment,int id)
        {
            afterGetLog.Invoke(moment, id);
        }
    }
}