using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Notification;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class FrmLogin : Form
    {
        private readonly IServiceProvider _sp;
        private readonly IEmployeeService _emltyeeService;
        public FrmLogin(IServiceProvider sp, IEmployeeService employeeService)
        {
            InitializeComponent();
            this._sp = sp;
            this._emltyeeService = employeeService;
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
            //var list = (_employeeService.GetAll().ToList());
            //var tempUser = list.FirstOrDefault(e => e.User == txtUser.Text && e.Password == txtPasword.Text);
            //if (tempUser == null)
            //{
            //    lblWarning.Text = "Kullan�c� ad� veya �ifre hatal�!";
            //    _lg.AddLog("Hatal� kullan�c� giri�i denemesi.");
            //}
            //else
            //{
            //    var mdiForm = sp.GetRequiredService<MDIDashboard>();
            //    _lg.AddLog($"{txtUser.Text} kullan�c�s� sisneme giri� yapt�.");
            //    mdiForm.ShowDialog();
            //}
        }
    }
}