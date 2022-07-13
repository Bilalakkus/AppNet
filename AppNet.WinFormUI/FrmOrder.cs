using AppNet.Bussines;
using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            gridOrderInisilise();
        }
        //private async List<BaseEntity> ProductLoad()
        //{
        //    var product = _sp.GetRequiredService<IProductService>();
        //    var productList = (await product.GetAll()).OrderBy(p => p.ProductName).ToList();
        //    return List<productList>;
        //}
        private async void CategoriLoad()
        {
            var Categories = _sp.GetRequiredService<ICategoriService>();
            var categorilist = (await Categories.GetAll()).ToList();
            cmbTahsilatTur.SelectedIndex = 0;

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
                    button.Click += new EventHandler(btnCategor_Click);
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
                    button.Click += new EventHandler(btnCategor_Click); ;
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
                    button.Click += new EventHandler(btnCategor_Click);
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
                    button.Click += new EventHandler(btnCategor_Click);
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
                    button.Click += new EventHandler(btnCategor_Click);
                    button.Name = categori.CategoryId.ToString();
                    button.TabIndex = 0;
                    button.Text = categori.CategoryName.ToString(); ;
                    button.UseVisualStyleBackColor = false;
                    this.Controls.Add(button);
                    top += button.Height + 2;
                }
                i++;
            }

        }//kategorileri veritabanından al dinamik kategori buton oluştur
        public async void btnCategor_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblCategory.Text = btn.Text;
            var product = _sp.GetRequiredService<IProductService>();
            var productList = (await product.GetAll()).Where(c => c.CategoryId == Convert.ToInt32(btn.Name)).ToList();
            //var list= productList.SingleOrDefault(p=>p.CategoryId== Convert.ToInt32(btn.Name));
            gridProduct.DataSource = productList;

            //foreach (DataGridViewRow row in gridProduct.Rows)
            //{
            //    Image img = Image.FromFile(row.Cells["ImgPath"].Value.ToString());
            //    DataGridViewImageCell cell = row.Cells["ImgPath"] as DataGridViewImageCell;
            //    cell.Value = img;
            //}


        }

        private void gridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var productId = Convert.ToInt32(gridProduct.CurrentRow.Cells[0].Value);
            var productName = gridProduct.CurrentRow.Cells[1].Value;
            decimal unitPrise = Convert.ToDecimal(gridProduct.CurrentRow.Cells[3].Value);
            decimal total = unitPrise * Convert.ToInt16(txtCount.Text);

            //gridOrder.Columns.Add("Product", "salary");
            gridOrder.Rows.Add(productId, productName, unitPrise, txtCount.Text, total);
            lblGTop.Text = Convert.ToDecimal(lblGTop.Text) + total + "";
        }
        private void gridOrderInisilise()
        {
            gridOrder.ReadOnly = true;
            gridOrder.AllowUserToDeleteRows = false;
            gridOrder.ColumnCount = 5;
            gridOrder.Columns[0].Name = "Id";
            gridOrder.Columns[1].Name = "Ürün";
            gridOrder.Columns[2].Name = "B.Fiyatı";
            gridOrder.Columns[3].Name = "Miktar";
            gridOrder.Columns[4].Name = "Tutar";
        }

        private void AllCencel_Click(object sender, EventArgs e)
        {
            if (gridOrder.SelectedRows.Count > 0)
            {
                lblGTop.Text = Convert.ToDecimal(lblGTop.Text) - Convert.ToDecimal(gridOrder.CurrentRow.Cells[4].Value) + "";
                gridOrder.Rows.RemoveAt(gridOrder.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen Silinecek Ürünü Seçin!");
            }
        }
        private void btnRowCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Siparişi iptal etmek istiyor musunuz!!!", "Dikkat!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                gridOrder.Rows.Clear();
                lblGTop.Text = "0";
            };
        }

        private async void btnOrderSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridOrder.RowCount <= 0)
                {
                    MessageBox.Show("Kaydedilecek ürün yok");
                    return;
                }
                Order newOrder = new Order
                {
                    CustomerId = Convert.ToInt32(cmbCustomers.SelectedValue),
                    Total = Convert.ToDecimal(lblGTop.Text),
                };
                var order = _sp.GetRequiredService<IOrderService>();
                var result = order.Add(newOrder);
                foreach (DataGridViewRow row in gridOrder.Rows)
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderId = result.OrderId,
                        ProductId = Convert.ToInt32(row.Cells[0].Value),
                        Toquantity = Convert.ToInt32(row.Cells[3].Value),
                        Total = Convert.ToDecimal(row.Cells[4].Value)
                        
                    };
                    OrderToProductAdd(orderDetail);
                }
                var safe = _sp.GetRequiredService<ISafeService>();
                Safe newSafe=new Safe 
                { 
                    Total=Convert.ToDecimal(lblGTop.Text),
                    AddingId=1,
                    Type=(int)SafeType.input,
                    Explanation="Sipariş",
                    CustomerId= Convert.ToInt32(cmbCustomers.SelectedValue),
                    TahsilatTuru=Convert.ToInt16(cmbTahsilatTur.SelectedValue)
                };
                safe.Add(newSafe);
                gridOrder.Rows.Clear();
                lblGTop.Text = "0";
                MessageBox.Show("Sipariş Kaydedildi","Kayıt Başarılı.");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void OrderToProductAdd(OrderDetail newOrderDetail)
        {
            var orderDetail = _sp.GetRequiredService<IOrderDetailService>();
            orderDetail.Add(newOrderDetail);
        }
    }
}
