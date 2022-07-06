namespace AppNet.WinFormUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRowCancel = new System.Windows.Forms.Button();
            this.AllCencel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 356);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriler(Burası Dinamik vt den listelenecek)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button22);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(548, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 356);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giyim";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(140, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mobilya";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(267, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Beyaz Eşya";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(394, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Elektronik";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(566, 289);
            this.dataGridView2.TabIndex = 0;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(429, 18);
            this.txtCount.Name = "txtCount";
            this.txtCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCount.Size = new System.Drawing.Size(60, 29);
            this.txtCount.TabIndex = 1;
            this.txtCount.Text = "1";
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
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(488, 17);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(28, 30);
            this.button21.TabIndex = 2;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(402, 17);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(28, 30);
            this.button22.TabIndex = 2;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(394, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 56);
            this.button5.TabIndex = 7;
            this.button5.Text = "Elektronik";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.FlatAppearance.BorderSize = 5;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(267, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 56);
            this.button6.TabIndex = 6;
            this.button6.Text = "Beyaz Eşya";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button7.FlatAppearance.BorderSize = 5;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(140, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 56);
            this.button7.TabIndex = 5;
            this.button7.Text = "Mobilya";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button8.FlatAppearance.BorderSize = 5;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(13, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 56);
            this.button8.TabIndex = 4;
            this.button8.Text = "Giyim";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button9.FlatAppearance.BorderSize = 5;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(394, 162);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 56);
            this.button9.TabIndex = 11;
            this.button9.Text = "Elektronik";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button10.FlatAppearance.BorderSize = 5;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(267, 162);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(121, 56);
            this.button10.TabIndex = 10;
            this.button10.Text = "Beyaz Eşya";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button11.FlatAppearance.BorderSize = 5;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(140, 162);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(121, 56);
            this.button11.TabIndex = 9;
            this.button11.Text = "Mobilya";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button12.FlatAppearance.BorderSize = 5;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(13, 162);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(121, 56);
            this.button12.TabIndex = 8;
            this.button12.Text = "Giyim";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button13.FlatAppearance.BorderSize = 5;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(394, 224);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(121, 56);
            this.button13.TabIndex = 15;
            this.button13.Text = "Elektronik";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button14.FlatAppearance.BorderSize = 5;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(267, 224);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(121, 56);
            this.button14.TabIndex = 14;
            this.button14.Text = "Beyaz Eşya";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button15.FlatAppearance.BorderSize = 5;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(140, 224);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(121, 56);
            this.button15.TabIndex = 13;
            this.button15.Text = "Mobilya";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button16.FlatAppearance.BorderSize = 5;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(13, 224);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(121, 56);
            this.button16.TabIndex = 12;
            this.button16.Text = "Giyim";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button17.FlatAppearance.BorderSize = 5;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(394, 285);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(121, 56);
            this.button17.TabIndex = 19;
            this.button17.Text = "Elektronik";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button18.FlatAppearance.BorderSize = 5;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(267, 285);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(121, 56);
            this.button18.TabIndex = 18;
            this.button18.Text = "Beyaz Eşya";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button19.FlatAppearance.BorderSize = 5;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(140, 285);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(121, 56);
            this.button19.TabIndex = 17;
            this.button19.Text = "Mobilya";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button20.FlatAppearance.BorderSize = 5;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(13, 285);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(121, 56);
            this.button20.TabIndex = 16;
            this.button20.Text = "Giyim";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1143, 873);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrderSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCustomers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrder";
            this.Text = "Sipariş Formu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbCustomers;
        private Label label1;
        private Button btnOrderSave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView2;
        private TextBox txtCount;
        private GroupBox groupBox3;
        private Button button22;
        private Button button21;
        private Button AllCencel;
        private Button btnRowCancel;
        private DataGridView dataGridView1;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}