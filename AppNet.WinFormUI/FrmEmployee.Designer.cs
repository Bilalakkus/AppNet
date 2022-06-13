namespace AppNet.WinFormUI
{
    partial class FrmEmployee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewEmployee = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtWDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabEmployeeList = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.gridEmployee = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabNewEmployee.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabNewEmployee);
            this.tabControl1.Controls.Add(this.tabEmployeeList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 604);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabNewEmployee
            // 
            this.tabNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabNewEmployee.Controls.Add(this.panel3);
            this.tabNewEmployee.Controls.Add(this.panel2);
            this.tabNewEmployee.Controls.Add(this.panel1);
            this.tabNewEmployee.Controls.Add(this.btnSave);
            this.tabNewEmployee.ForeColor = System.Drawing.Color.Teal;
            this.tabNewEmployee.Location = new System.Drawing.Point(4, 39);
            this.tabNewEmployee.Name = "tabNewEmployee";
            this.tabNewEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewEmployee.Size = new System.Drawing.Size(970, 561);
            this.tabNewEmployee.TabIndex = 0;
            this.tabNewEmployee.Text = "Personel Ekle";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtTc);
            this.panel3.Controls.Add(this.txtDateOfBirth);
            this.panel3.Controls.Add(this.txtLastName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.txtAdress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(15, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 282);
            this.panel3.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "T.C. Kimlik No";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(209, 3);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(625, 29);
            this.txtTc.TabIndex = 0;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(210, 149);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(624, 29);
            this.txtDateOfBirth.TabIndex = 3;
            this.txtDateOfBirth.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(209, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(625, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Adı";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(625, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(209, 234);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdress.Size = new System.Drawing.Size(625, 41);
            this.txtAdress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Soyadı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Tarihi";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(209, 187);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(625, 29);
            this.txtPhone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtWDate);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(15, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 115);
            this.panel2.TabIndex = 21;
            // 
            // txtWDate
            // 
            this.txtWDate.Location = new System.Drawing.Point(210, 22);
            this.txtWDate.Name = "txtWDate";
            this.txtWDate.Size = new System.Drawing.Size(624, 29);
            this.txtWDate.TabIndex = 6;
            this.txtWDate.Value = new System.DateTime(2022, 12, 6, 0, 0, 0, 0);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(210, 67);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(625, 29);
            this.txtSalary.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Maaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "İşe Başlama Tarihi";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPasword);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(15, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 114);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(210, 68);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.PasswordChar = '*';
            this.txtPasword.Size = new System.Drawing.Size(625, 29);
            this.txtPasword.TabIndex = 9;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(210, 14);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(625, 29);
            this.txtuser.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Şifre";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(776, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tabEmployeeList
            // 
            this.tabEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabEmployeeList.Controls.Add(this.textBox4);
            this.tabEmployeeList.Controls.Add(this.label14);
            this.tabEmployeeList.Controls.Add(this.textBox3);
            this.tabEmployeeList.Controls.Add(this.label13);
            this.tabEmployeeList.Controls.Add(this.textBox2);
            this.tabEmployeeList.Controls.Add(this.label12);
            this.tabEmployeeList.Controls.Add(this.btnEmployeeSearch);
            this.tabEmployeeList.Controls.Add(this.gridEmployee);
            this.tabEmployeeList.ForeColor = System.Drawing.Color.Teal;
            this.tabEmployeeList.Location = new System.Drawing.Point(4, 39);
            this.tabEmployeeList.Name = "tabEmployeeList";
            this.tabEmployeeList.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeList.Size = new System.Drawing.Size(970, 561);
            this.tabEmployeeList.TabIndex = 1;
            this.tabEmployeeList.Text = "Personeller";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(688, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 29);
            this.textBox4.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(609, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 21);
            this.label14.TabIndex = 6;
            this.label14.Text = "Soyadı";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(389, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 29);
            this.textBox3.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 29);
            this.textBox2.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "T.C. Kimlik No";
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.Location = new System.Drawing.Point(887, 12);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(75, 34);
            this.btnEmployeeSearch.TabIndex = 1;
            this.btnEmployeeSearch.Text = "Bul";
            this.btnEmployeeSearch.UseVisualStyleBackColor = true;
            // 
            // gridEmployee
            // 
            this.gridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployee.Location = new System.Drawing.Point(8, 55);
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.RowTemplate.Height = 25;
            this.gridEmployee.Size = new System.Drawing.Size(954, 500);
            this.gridEmployee.TabIndex = 0;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 638);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEmployee";
            this.Text = "Çalışanlar";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNewEmployee.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabEmployeeList.ResumeLayout(false);
            this.tabEmployeeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabNewEmployee;
        private TabPage tabEmployeeList;
        public TabControl tabControl1;
        private TextBox txtName;
        private Label label2;
        private Button btnSave;
        private TextBox txtuser;
        private Label label7;
        private Label label6;
        private TextBox txtPhone;
        private Label label5;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private Panel panel2;
        private TextBox txtSalary;
        private Label label10;
        private Panel panel1;
        private TextBox txtPasword;
        private Label label8;
        private TextBox txtAdress;
        private Label label9;
        private Panel panel3;
        private DateTimePicker txtDateOfBirth;
        private DateTimePicker txtWDate;
        private Label label11;
        private TextBox txtTc;
        private DataGridView gridEmployee;
        private TextBox textBox4;
        private Label label14;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox2;
        private Label label12;
        private Button btnEmployeeSearch;
    }
}