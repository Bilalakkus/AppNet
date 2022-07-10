using AppNet.Bussines;
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
    public partial class FrmOrder : Form
    {
        private IServiceProvider _sp;
        public FrmOrder(IServiceProvider sp)
        {
            this._sp = sp;
            InitializeComponent();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            txtCount.Text = (Convert.ToInt16(txtCount.Text.Trim()) + 1).ToString();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (txtCount.Text != "1")
            {
                txtCount.Text = (Convert.ToInt16(txtCount.Text.Trim()) - 1).ToString();
            }
        }
        private async void FrmOrder_Load(object sender, EventArgs e)
        {
            var customer = _sp.GetRequiredService<ICustomerService>();
            var list = (await customer.GetAll()).ToList();
            cmbCustomers.DataSource = list;
            cmbCustomers.DisplayMember = "Name";
            cmbCustomers.ValueMember = "CustomerId";
            CategoriLoad();
            var product = _sp.GetRequiredService<IProductService>();
            var productList = (await product.GetAll()).OrderBy(p => p.ProductName).ToList();
            gridProduct.DataSource = productList;

        }
        private async void CategoriLoad()
        {
            var Categories = _sp.GetRequiredService<ICategoriService>();
            var categorilist = (await Categories.GetAll()).ToList();

            int top = 121;
            int left = 56;

            int i = 0;
            int x = 1;
            int y = 120;
            foreach (var categori in categorilist)
            {


                if (i <= 3)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(125, 56);
                    button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    button.FlatAppearance.BorderSize = 5;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.Location = new System.Drawing.Point(i == 0 ? x : i * 125, y);
                    button.Name = categori.CategoryId.ToString();
                    //button.Size = new System.Drawing.Size(y, i*x);
                    button.TabIndex = 0;
                    button.Text = categori.CategoryName.ToString(); ;
                    button.UseVisualStyleBackColor = false;
                    this.Controls.Add(button);
                    //top += button.Height + 2;
                }
                else if (i <= 7)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(121, 56);
                    button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    button.FlatAppearance.BorderSize = 5;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.Location = new System.Drawing.Point(i - 4 == 0 ? x : i * 125, y + 70);
                    button.Name = categori.CategoryId.ToString();
                    button.TabIndex = 0;
                    button.Text = categori.CategoryName.ToString(); ;
                    button.UseVisualStyleBackColor = false;
                    this.Controls.Add(button);
                    top += button.Height + 2;
                }
                else if (i <= 11)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(121, 56);
                    button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    button.FlatAppearance.BorderSize = 5;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.Location = new System.Drawing.Point(i - 8 == 0 ? x : i * 125, y + 140);
                    button.Name = categori.CategoryId.ToString();
                    button.TabIndex = 0;
                    button.Text = categori.CategoryName.ToString(); ;
                    button.UseVisualStyleBackColor = false;
                    this.Controls.Add(button);
                    top += button.Height + 2;
                }
                else if (i <= 15)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(121, 56);
                    button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    button.FlatAppearance.BorderSize = 5;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.Location = new System.Drawing.Point(i - 16 == 0 ? x : i * 125, y + 140);
                    button.Name = categori.CategoryId.ToString();
                    button.TabIndex = 0;
                    button.Text = categori.CategoryName.ToString(); ;
                    button.UseVisualStyleBackColor = false;
                    this.Controls.Add(button);
                    top += button.Height + 2;
                }
                else if (i <= 19)
                {
                    Button button = new Button();
                    button.Size = new System.Drawing.Size(121, 56);
                    button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    button.FlatAppearance.BorderSize = 5;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    button.Location = new System.Drawing.Point(i - 20 == 0 ? x : i * 125, y + 140);
                    button.Name = categori.CategoryId.ToString();
                    button.TabIndex = 0;
                    button.Text = categori.CategoryName.ToString(); ;
                    button.UseVisualStyleBackColor = false;
                    this.Controls.Add(button);
                    top += button.Height + 2;
                }
                i++;
            }
        }
    }
}
