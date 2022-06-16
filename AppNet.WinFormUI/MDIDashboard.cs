using AppNet.Bussines.Abstract;
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
        private int childFormNumber = 0;

        public MDIDashboard()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmProductSave productSave = new FrmProductSave();
            productSave.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            productSave.Show();
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
            var services = new ServiceCollection();
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                var employee = sp.GetRequiredService<IEmployeeService>();
                FrmEmployee frmEmployee = new FrmEmployee(employee);
                frmEmployee.MdiParent = this;
                frmEmployee.ShowDialog();
            }
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
            FrmCategorySave categorySave = new FrmCategorySave();
            categorySave.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            categorySave.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoryList categoryList = new FrmCategoryList();
            categoryList.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            categoryList.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerSave customerSave = new FrmCustomerSave();
            customerSave.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            customerSave.Show();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerList customerList = new FrmCustomerList();
            customerList.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            customerList.Show();
        }


    }
}
