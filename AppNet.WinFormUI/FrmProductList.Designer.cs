namespace AppNet.WinFormUI
{
    partial class FrmProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategorySearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductNameSerch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridProduct = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPtoductId = new System.Windows.Forms.TextBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategorySearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtProductNameSerch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Kriterleri";
            // 
            // cmbCategorySearch
            // 
            this.cmbCategorySearch.FormattingEnabled = true;
            this.cmbCategorySearch.Location = new System.Drawing.Point(83, 41);
            this.cmbCategorySearch.Name = "cmbCategorySearch";
            this.cmbCategorySearch.Size = new System.Drawing.Size(215, 29);
            this.cmbCategorySearch.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(574, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 41);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtProductNameSerch
            // 
            this.txtProductNameSerch.Location = new System.Drawing.Point(389, 41);
            this.txtProductNameSerch.Name = "txtProductNameSerch";
            this.txtProductNameSerch.Size = new System.Drawing.Size(231, 29);
            this.txtProductNameSerch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            // 
            // dtGridProduct
            // 
            this.dtGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProduct.Location = new System.Drawing.Point(6, 157);
            this.dtGridProduct.Name = "dtGridProduct";
            this.dtGridProduct.RowTemplate.Height = 25;
            this.dtGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridProduct.Size = new System.Drawing.Size(626, 460);
            this.dtGridProduct.TabIndex = 1;
            this.dtGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridProduct_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPtoductId);
            this.groupBox2.Controls.Add(this.btnProductDelete);
            this.groupBox2.Controls.Add(this.pictureProduct);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtStockMin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProductName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(634, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 611);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Detay";
            // 
            // txtPtoductId
            // 
            this.txtPtoductId.Enabled = false;
            this.txtPtoductId.Location = new System.Drawing.Point(164, 76);
            this.txtPtoductId.Name = "txtPtoductId";
            this.txtPtoductId.Size = new System.Drawing.Size(312, 29);
            this.txtPtoductId.TabIndex = 36;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.White;
            this.btnProductDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductDelete.BackgroundImage")));
            this.btnProductDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductDelete.Location = new System.Drawing.Point(430, 273);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(46, 39);
            this.btnProductDelete.TabIndex = 35;
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // pictureProduct
            // 
            this.pictureProduct.Location = new System.Drawing.Point(164, 321);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(196, 230);
            this.pictureProduct.TabIndex = 34;
            this.pictureProduct.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Location = new System.Drawing.Point(384, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 39);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stok";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(164, 234);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(312, 29);
            this.txtStock.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Stok Min Miktar";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Enabled = false;
            this.txtStockMin.Location = new System.Drawing.Point(164, 197);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(312, 29);
            this.txtStockMin.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Birim Fiyatı";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(164, 157);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(312, 29);
            this.txtUnitPrice.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(164, 118);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(312, 29);
            this.txtProductName.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ürün Id";
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1143, 813);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtGridProduct);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProductList";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtProductNameSerch;
        private Label label2;
        private Button btnSearch;
        private DataGridView dtGridProduct;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtStock;
        private Label label6;
        private TextBox txtStockMin;
        private Label label7;
        private TextBox txtUnitPrice;
        private Label label8;
        private TextBox txtProductName;
        private Label label9;
        private Button btnUpdate;
        private ComboBox cmbCategorySearch;
        private PictureBox pictureProduct;
        private Button btnProductDelete;
        private TextBox txtPtoductId;
    }
}