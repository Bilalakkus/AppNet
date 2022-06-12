using AppNet.Bussines.Concrete;
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
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
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

            EmployeeService employeeService = new EmployeeService();
            var result = employeeService.Add(employee);
            EmptyForm();
            MessageBox.Show($"{result.Name} {result.LastName} adlı personel eklendi.");

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

        private void LoadEmployee()
        {
            using (var context = new AppNetDbContext())
            {
                var data = from q in context.Employees
                           select new Employee
                           {
                               EmployeeId=q.EmployeeId,
                               Name = q.Name,
                               LastName = q.LastName,
                               CreateDate = q.CreateDate,
                               DateOfBirth = q.DateOfBirth,
                               Salary = q.Salary,
                               Tc = q.Tc,
                               WDate = q.WDate
                               
                           };

                foreach (var employee in data)
                {
                    gridAddEmployee(employee);
                }
            }
        }
        private void gridAddEmployee(Employee model)
        {
            DataGridViewRow row = (DataGridViewRow)gridEmployee.Rows[0].Clone();
            row.Cells[0].Value = model.EmployeeId;
            row.Cells[1].Value = model.Name+" " +model.LastName;
            row.Cells[2].Value = model.Tc;
            row.Cells[3].Value = model.DateOfBirth;
            row.Cells[4].Value = model.WDate;
            row.Cells[5].Value = model.Salary;

            gridEmployee.Rows.Add(row);
        }
    }
}
