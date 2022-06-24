using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Notification;
using AppNet.Infrastructer.Persistence;
using AppNet.Infrastructer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class FrmDateBaseInformation : Form
    {
        private readonly IDatabaseService _databaseService;
        private readonly IServiceProvider _sp;
        private readonly AppNetDbContext _db;
        private readonly IEmployeeService _employeeService;
        public FrmDateBaseInformation(IDatabaseService databaseService, AppNetDbContext db, IServiceProvider sp, IEmployeeService emp)
        {
            InitializeComponent();
            this._databaseService = databaseService;
            this._db = db;
            this._sp = sp;
            this._employeeService = emp;
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
            _databaseService.Add(newdataBase);
            MessageBox.Show("Database Oluşturuldu!");
            SentTelegram sent = new SentTelegram();
            sent.TelegramMesjGonder("Veritabanı Oluşturuldu");
            var frm = _sp.GetRequiredService<FrmLogin>();
            frm.ShowDialog();
            this.Close();

            //veritabanı oluştuktan sonra admin kullanıcısını oluştur
            Employee employee = new Employee
            {
                Name = "Yönetici",
                LastName="Yetkili",
                Password="a1234*",
                User="admin"            
            };
            _employeeService.Add(employee);
        }
    }
}
