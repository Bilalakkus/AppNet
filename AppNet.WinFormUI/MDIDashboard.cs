﻿using AppNet.Bussines.Abstract;
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
    public partial class MDIDashboard : Form
    {
        private readonly IServiceProvider _sp;
        //private readonly ICategoriService _CategoriService;
        public MDIDashboard(IServiceProvider sp/*, ICategoriService categoriService*/)
        {
            InitializeComponent();
            this._sp = sp;
            //this._CategoriService = categoriService;
        }
        private int childFormNumber = 0;

        
        private void ShowNewForm(object sender, EventArgs e)
        {
            var frmProduct=_sp.GetRequiredService<FrmProductSave>();
            frmProduct.ShowDialog();

            //FrmProductSave productSave = new FrmProductSave();
            //productSave.MdiParent = this;
            ////childForm.Text = "Window " + childFormNumber++;
            //productSave.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var employee = sp.GetRequiredService<IEmployeeService>();
                FrmEmployee frmEmployee = new FrmEmployee(employee);
                frmEmployee.MdiParent = this;
                frmEmployee.ShowDialog();
            }
            //childForm.Text = "Window " + childFormNumber++;
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FrmEmployee =_sp.GetRequiredService<FrmEmployee>();
            FrmEmployee.ShowDialog();
            FrmEmployee.tabControl1.SelectTab(1);

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
            var frmEmployeeList = _sp.GetRequiredService<FrmEmployee>();
            frmEmployeeList.ShowDialog();
            frmEmployeeList.tabControl1.SelectTab(2);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = _sp.GetRequiredService<FrmCategorySave>();
            frm.ShowDialog();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCategoriList=_sp.GetRequiredService<FrmCategoryList>();
            frmCategoriList.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          var frmCustomerSave=_sp.GetRequiredService<FrmCustomerSave>();
            frmCustomerSave.ShowDialog();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList=_sp.GetRequiredService<FrmCustomerList>();
            frmCustomerList.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)   
            Application.Exit();
        }

        private void tedarikçiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSuplierSave=_sp.GetRequiredService<FrmSupplierSave>();
            frmSuplierSave.ShowDialog();
        }

        private void tedarikcilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var frmSuplier
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProductList = _sp.GetRequiredService<FrmProductList>();
                frmProductList.ShowDialog();

        }
    }
}
