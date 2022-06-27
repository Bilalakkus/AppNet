using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Notification;
using AppNet.Infrastructer.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class FrmLogin : Form
    {
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
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var services=new ServiceCollection();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var emp = _sp.GetRequiredService<IEmployeeService>();
                var log = _sp.GetRequiredService<Logger>;
            }

            //var list = (emp.GetAll());
            //var tempUser = list.FirstOrDefault(e => e.User == txtUser.Text && e.Password == txtPasword.Text);
            //if (tempUser == null)
            //{
            //    lblWarning.Text = "Kullanýcý adý veya þifre hatalý!";
            //   //log.("Hatalý kullanýcý giriþi denemesi.");
            //}
            //else
            //{
            //    var mdiForm = _sp.GetRequiredService<MDIDashboard>();
            //   // _lg.AddLog($"{txtUser.Text} kullanýcýsý sisneme giriþ yaptý.");
            //    mdiForm.ShowDialog();
            //}
        }
    }
}