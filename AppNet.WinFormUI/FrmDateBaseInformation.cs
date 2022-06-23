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
        private readonly IServiceProvider sp;
        private readonly AppNetDbContext db;
        public FrmDateBaseInformation(AppNetDbContext db, IServiceProvider sp)
        {
            InitializeComponent();
            this.db = db;
            this.sp = sp;

        }
        private void FrmDateBaseInformation_Load(object sender, EventArgs e)
        {

            var settings = DatabaseInformation.Load();
            if (settings != null)
            {
                txtServer.Text = settings.Server;
                txtDB.Text = settings.Db;
                txtUser.Text = settings.User;
                txtPassword.Text = settings.Pass;
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
                Db = txtDB.Text,
                User = txtUser.Text,
                Pass = txtPassword.Text,
            };
            dbsettings.Save();
            db.Database.EnsureCreated();
            db.Database.Migrate();
            //databaseService.Add(txtAddDatabaseName.Text, txtAddDataBaseUser.Text, txtAddPassword.Text);

            MessageBox.Show("Database Oluşturuldu!");
            SentTelegram sent = new SentTelegram();
            sent.TelegramMesjGonder("Veritabanı Oluşturuldu");
            var frm = sp.GetRequiredService<FrmLogin>();
            frm.ShowDialog();
            this.Close();
        }
    }
}
