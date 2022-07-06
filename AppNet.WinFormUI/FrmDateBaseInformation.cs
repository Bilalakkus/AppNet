using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Notification;
using AppNet.Infrastructer.Persistence;
using AppNet.Infrastructer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppNet.WinFormUI
{
    public partial class FrmDateBaseInformation : Form
    {
        private readonly IServiceProvider _sp;
        private readonly AppNetDbContext _db;

        public FrmDateBaseInformation(AppNetDbContext db, IServiceProvider sp)
        {
            InitializeComponent();
            this._sp = sp;
            this._db = db;

        }
        private void FrmDateBaseInformation_Load(object sender, EventArgs e)
        {
            var settings = DatabaseInformation.Load();
            if (settings != null)
            {
                txtServer.Text = settings.Server;
                txtDB.Text = settings.DataBase;
                txtUser.Text = settings.Username;
                txtPassword.Text = settings.Password;
            }
            else
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DatabaseInformation dbsettings = new DatabaseInformation
            {
                Server = txtServer.Text,
                DataBase = txtDB.Text,
                Username = txtUser.Text,
                Password = txtPassword.Text,
            };
            dbsettings.Save();
            _db.Database.EnsureCreated();
            _db.Database.Migrate();
            DataBase newdataBase = new DataBase()
            {
                Server = txtServer.Text,
                Name = txtDB.Text,
                Username = txtUser.Text,
                Pasword = txtPassword.Text
            };
            //_databaseService.Add(newdataBase);
            MessageBox.Show("Database Oluşturuldu!");
            SentTelegram sent = new SentTelegram();
            sent.TelegramMesjGonder("Veritabanı Oluşturuldu");
            //veritabanı oluştuktan sonra admin kullanıcısını oluştur
            Employee employee = new Employee
            {
                Name = "Yönetici",
                LastName = "Yetkili",
                Password = "a1234*",
                User = "admin",
                AddingId =1,
                DateOfBirth=DateTime.Now,
                IsItPassive=true,
                Salary=0,
                Tc="11111111111",
                WDate=DateTime.Now,
                CreateDate=DateTime.Now,
            };
            var emp = _sp.GetRequiredService<IEmployeeService>();
            emp.Add(employee);
            var log = _sp.GetRequiredService<Logger>();
            log.AddLog("Veri tabanı oluşturuldu.");
            var frm = _sp.GetRequiredService<FrmLogin>();
            frm.ShowDialog();
            this.Close();
        }
    }
}
