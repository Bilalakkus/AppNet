using AppNet.Bussines.Abstract;
using AppNet.Bussines.Concrete;
using AppNet.Bussines.Utilities;
using AppNet.Bussines.Validation;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Persistence.Contexts;
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
    public partial class FrmEmployee : Form
    {
        private readonly IEmployeeService _employeeService;
        public FrmEmployee(IEmployeeService employeeService)
        {
            InitializeComponent();

            this._employeeService = employeeService;
        }
        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtTc.Text.TcVerify())
                {
                    MessageBox.Show("T.C. Kimlik Numarsı Hatalı");
                    return;
                }
                txtName.Text.NullOrEmpty(nameof(txtName.Text));
                txtLastName.Text.NullOrEmpty(nameof(txtLastName.Text));


                if (btnSave.Text == "Kaydet")
                {
                    Employee employee = new Employee
                    {
                        Name = txtName.Text.Trim(),
                        AddingId = 1,
                        CreateDate = DateTime.Now,
                        DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                        LastName = txtLastName.Text.Trim(),
                        Password = txtPasword.Text.Trim(),
                        Salary = Convert.ToDecimal(txtSalary.Text.Trim()),
                        User = txtuser.Text.Trim(),
                        WDate = Convert.ToDateTime(txtWDate.Text),
                        Tc = txtTc.Text.Trim()
                    };
                    var result = _employeeService.Add(employee);
                    MessageBox.Show($"{txtName.Text} {txtLastName.Text} eklendi!!!");
                    ClearForm();
                }
                else
                {
                    Employee employeeUpdate = new Employee
                    {
                        EmployeeId = Convert.ToInt32(txtId.Text),
                        Name = txtName.Text.Trim(),
                        AddingId = 1,
                        CreateDate = DateTime.Now,
                        DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                        LastName = txtLastName.Text.Trim(),
                        Password = txtPasword.Text.Trim(),
                        Salary = Convert.ToDecimal(txtSalary.Text.Trim()),
                        User = txtuser.Text.Trim(),
                        WDate = Convert.ToDateTime(txtWDate.Text),
                        Tc = txtTc.Text.Trim()
                    };
                    var resaltUpdate = _employeeService.Update(employeeUpdate);
                }

                EmptyForm();
                MessageBox.Show("İşlem başarılı...");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void EmptyForm()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtAdress.Text = "";
            txtDateOfBirth.Text = "";
            txtLastName.Text = "";
            txtPasword.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            txtTc.Text = "";
            txtuser.Text = "";
            txtWDate.Text = "";
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private async void LoadEmployee()
        {
            var list = (await _employeeService.GetAll()).OrderBy(e => e.Name).ToList();
            gridEmployee.DataSource = list;
        }
        private void gridAddEmployee(Employee model)
        {
            DataGridView DataGridView = new DataGridView();// gridEmployee.Rows[0].Clone();
            DataGridView.Columns[0].Name = "Id";// model.EmployeeId;
            DataGridView.Columns[1].Name = "Name";// model.Name + " " + model.LastName;
            DataGridView.Columns[2].Name = "Tc";// model.Tc;
            DataGridView.Columns[3].Name = "Doğum Tarihi";// model.DateOfBirth;
            DataGridView.Columns[4].Name = "İşe Başlama Tarihi";// model.WDate;
            DataGridView.Columns[5].Name = "Maaş";// model.Salary;

            string[] row = new string[] { model.EmployeeId.ToString(), model.Name, model.Tc, model.DateOfBirth.ToString(), model.WDate.ToString(), model.Salary.ToString() };
            gridEmployee.Rows.Add(row);
        }
        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {

        }
        private void GuncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtId.Text = gridEmployee.CurrentRow.Cells[0].Value.ToString();
            txtTc.Text = gridEmployee.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = gridEmployee.CurrentRow.Cells[2].Value.ToString();
            txtLastName.Text = gridEmployee.CurrentRow.Cells[3].Value.ToString();
            txtDateOfBirth.Text = gridEmployee.CurrentRow.Cells[4].Value.ToString();
            txtWDate.Text = gridEmployee.CurrentRow.Cells[5].Value.ToString();
            txtSalary.Text = gridEmployee.CurrentRow.Cells[6].Value.ToString();
            btnSave.Text = "Güncelle";

            tabControl1.Show();
            tabControl1.SelectedTab = tabNewEmployee;
        }
        private void SilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var employeeId = Convert.ToInt32(gridEmployee.CurrentRow.Cells[0].Value);
            var name = gridEmployee.CurrentRow.Cells[1].Value.ToString() + " " + gridEmployee.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show($"{Name} adlı personeli silmek istediğinizden emin misiniz?",
                 "Silme Onayı!",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (_employeeService.Remove(employeeId)) MessageBox.Show($"{name} silindi...");
                else MessageBox.Show("Sorun oluştu!");
            }
        }
        private async void btnEmployeeSearch_Click_1(object sender, EventArgs e)
        {
            var list = (await _employeeService.GetAll()).ToList();
            if (txtSearchTc.Text.Trim().Length == 11)
            {
                gridEmployee.DataSource = list.SingleOrDefault(e => e.Tc == txtSearchTc.Text.Trim());
            }
            if (txtSearchName.Text.Trim().Length >=3)
            {
                if (txtSearchLastName.Text.Trim().Length >= 2)
                {
                    gridEmployee.DataSource = list.FirstOrDefault(e => e.Name == txtSearchName.Text.Trim() && e.LastName == txtSearchLastName.Text.Trim());
                }
                else gridEmployee.DataSource = list.FirstOrDefault(e => e.Name == txtSearchName.Text.Trim());
            }
            else if(txtSearchLastName.Text.Trim().Length >=2) gridEmployee.DataSource = list.FirstOrDefault(e => e.LastName == txtSearchLastName.Text.Trim());
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtAdress.Text = "";
            txtSearchTc.Text = "";
            txtTc.Text = "";
            txtuser.Text = "";
            txtWDate.Text = "";
            txtDateOfBirth.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPasword.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
            txtSearchLastName.Text = "";
            txtSearchName.Text = "";
        }
    }
}
