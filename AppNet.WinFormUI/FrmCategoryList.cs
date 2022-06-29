using AppNet.Bussines.Abstract;
using AppNet.Domain.ViewModels;
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
        private readonly ICategoriService _categoriService;
        public FrmCategoryList(ICategoriService categoriService)
        {
            InitializeComponent();
            this._categoriService = categoriService;
        }

        private async void FrmCategoryList_Load(object sender, EventArgs e)
        {
            // LoadGridData();
            var list = (await _categoriService.GetAll()).OrderBy(c=>c.CategoryName).ToList();

            gridCategories.DataSource = list;
                
        }
        private async void LoadGridData()
        {
            var category = (await _categoriService.GetAll()).ToList();
            var data = from c in category
                       orderby c.CategoryName ascending
                       select new CategoriViewModel
                       {
                           CategoriId =c.CategoryId,
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
    }
}
