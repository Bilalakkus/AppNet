using AppNet.Bussines.Abstract;
using AppNet.Domain.ViewModels;
using AppNet.Infrastructer.Logging;
using AppNet.Infrastructer.Notification;
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
    public partial class FrmCategoryList : Form
    {
        private readonly IServiceProvider _sp;
        private readonly ICategoriService _categoriService;
        private readonly Logger _lg;
        public FrmCategoryList(IServiceProvider sp, ICategoriService categoriService, Logger lg)
        {
            this._sp = sp;
            this._categoriService = categoriService;
            this._lg = lg;

            InitializeComponent();

        }

        private async void FrmCategoryList_Load(object sender, EventArgs e)
        {
            // LoadGridData();
            var list = (await _categoriService.GetAll()).OrderBy(c => c.CategoryName).ToList();
            gridCategories.DataSource = list;
        }
        public async void LoadGridData()
        {
            var category = (await _categoriService.GetAll()).ToList();
            var data = from c in category
                       orderby c.CategoryName ascending
                       select new CategoriViewModel
                       {
                           CategoriId = c.CategoryId,
                           CategoriName = c.CategoryName

                       };
            foreach (var item in data)
            {
                AddRowToGrid(item);
            }
        }
        private void AddRowToGrid(CategoriViewModel model)
        {
            DataGridViewRow row = (DataGridViewRow)gridCategories.Rows[0].Clone();
            row.Cells[0].Value = model.CategoriId;
            row.Cells[1].Value = model.CategoriName;
            gridCategories.Rows.Add(row);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryId = Convert.ToInt32(gridCategories.CurrentRow.Cells[0].Value);
            var categoryName = gridCategories.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show($"{categoryName} kategorisini silmek istediğinizden emin misiniz?",
                 "Silme Onayı!",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _categoriService.Remove(categoryId);
                _lg.AddLog($"{categoryName} kategorisi silindi.");
                SentTelegram sent = new SentTelegram();
                sent.TelegramMesjGonder($"{categoryName} kategorisi silindi.");
                LoadGridData();
            }
        }
        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categoryId = Convert.ToInt32(gridCategories.CurrentRow.Cells[0].Value);
            var categoryName = gridCategories.CurrentRow.Cells[1].Value.ToString();
            var frmCategori = _sp.GetService(typeof(FrmCategorySave)) as FrmCategorySave;
            frmCategori.txtCategoryId.Text = categoryId.ToString();
            frmCategori.txtCategoriName.Text = categoryName;
            frmCategori.btnCategorySave.Text = "Güncelle";
            frmCategori.Show();
        }
    }
}
