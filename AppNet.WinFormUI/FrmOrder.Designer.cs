﻿namespace AppNet.WinFormUI
{
    partial class FrmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrderSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AllCencel = new System.Windows.Forms.Button();
            this.btnRowCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCustomers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(191, 8);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(934, 53);
            this.cmbCustomers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri";
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.BackColor = System.Drawing.Color.White;
            this.btnOrderSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrderSave.BackgroundImage")));
            this.btnOrderSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrderSave.Location = new System.Drawing.Point(977, 731);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(154, 140);
            this.btnOrderSave.TabIndex = 13;
            this.btnOrderSave.Tag = "Sipariş oluştur";
            this.btnOrderSave.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCategory);
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.gridProduct);
            this.groupBox2.Location = new System.Drawing.Point(536, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 356);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(6, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(441, 21);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(475, 17);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(28, 30);
            this.button22.TabIndex = 2;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(561, 17);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(28, 30);
            this.button21.TabIndex = 2;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(502, 18);
            this.txtCount.Name = "txtCount";
            this.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCount.Size = new System.Drawing.Size(60, 29);
            this.txtCount.TabIndex = 1;
            this.txtCount.Text = "1";
            // 
            // gridProduct
            // 
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Location = new System.Drawing.Point(6, 53);
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.RowTemplate.Height = 25;
            this.gridProduct.Size = new System.Drawing.Size(581, 289);
            this.gridProduct.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AllCencel);
            this.groupBox3.Controls.Add(this.btnRowCancel);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(14, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1117, 311);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sipariş";
            // 
            // AllCencel
            // 
            this.AllCencel.BackColor = System.Drawing.Color.Red;
            this.AllCencel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllCencel.BackgroundImage")));
            this.AllCencel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AllCencel.Location = new System.Drawing.Point(89, 259);
            this.AllCencel.Name = "AllCencel";
            this.AllCencel.Size = new System.Drawing.Size(75, 46);
            this.AllCencel.TabIndex = 15;
            this.AllCencel.Tag = "Siparişi iptal et";
            this.AllCencel.UseVisualStyleBackColor = false;
            // 
            // btnRowCancel
            // 
            this.btnRowCancel.BackColor = System.Drawing.Color.White;
            this.btnRowCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRowCancel.BackgroundImage")));
            this.btnRowCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRowCancel.Location = new System.Drawing.Point(13, 259);
            this.btnRowCancel.Name = "btnRowCancel";
            this.btnRowCancel.Size = new System.Drawing.Size(75, 46);
            this.btnRowCancel.TabIndex = 14;
            this.btnRowCancel.Tag = "Seçili satırı sil";
            this.btnRowCancel.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 223);
            this.dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kategori Listesi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1143, 873);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOrderSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCustomers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrder";
            this.Text = "Sipariş Formu";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbCustomers;
        private Label label1;
        private Button btnOrderSave;
        private GroupBox groupBox2;
        private DataGridView gridProduct;
        private TextBox txtCount;
        private GroupBox groupBox3;
        private Button button22;
        private Button button21;
        private Button AllCencel;
        private Button btnRowCancel;
        private DataGridView dataGridView1;
        private Label label2;
        private Label lblCategory;
    }
}