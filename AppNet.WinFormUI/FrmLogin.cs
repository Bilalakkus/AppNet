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
        private readonly IServiceProvider sp;
        private readonly ICategoriService _CategoriService;
        private readonly IEmployeeService _EmployeeService;
        //private readonly IRepository<Employee> _Repository;
        public FrmLogin(IServiceProvider sp, ICategoriService categoriService, IEmployeeService employeeService)
        {
            InitializeComponent();
            this.sp = sp;
            this._CategoriService = categoriService;
            this._EmployeeService = employeeService;
            //this._Repository = repository;
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
            var frmCategoriSave = sp.GetRequiredService<FrmCategorySave>();
            frmCategoriSave.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //var list = (_EmployeeService.GetAll().ToList());
            //var tempUser = list.FirstOrDefault(e => e.User == txtUser.Text && e.Password == txtPasword.Text);
            //if (tempUser == null)
            //{
            //    lblWarning.Text = "Kullanýcý adý veya þifre hatalý!";
            //}
            //else
            //{
            //    var mdiForm = sp.GetRequiredService<MDIDashboard>();
            //    mdiForm.ShowDialog();
            //}
        }
    }
}