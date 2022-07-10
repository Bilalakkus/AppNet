namespace AppNet.WinFormUI
{
    partial class FrmCustomerSave
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
            this.lblTcVergino = new System.Windows.Forms.Label();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.txtTcVergiNo = new System.Windows.Forms.TextBox();
            this.radioGercek = new System.Windows.Forms.RadioButton();
            this.radioTuzel = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTcVergino
            // 
            this.lblTcVergino.AutoSize = true;
            this.lblTcVergino.Location = new System.Drawing.Point(9, 61);
            this.lblTcVergino.Name = "lblTcVergino";
            this.lblTcVergino.Size = new System.Drawing.Size(112, 21);
            this.lblTcVergino.TabIndex = 0;
            this.lblTcVergino.Text = "TC. Kimlik No";
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Location = new System.Drawing.Point(357, 321);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(83, 46);
            this.btnCustomerSave.TabIndex = 8;
            this.btnCustomerSave.Text = "Kaydet";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // txtTcVergiNo
            // 
            this.txtTcVergiNo.Location = new System.Drawing.Point(134, 61);
            this.txtTcVergiNo.Name = "txtTcVergiNo";
            this.txtTcVergiNo.Size = new System.Drawing.Size(453, 29);
            this.txtTcVergiNo.TabIndex = 3;
            // 
            // radioGercek
            // 
            this.radioGercek.AutoSize = true;
            this.radioGercek.Location = new System.Drawing.Point(135, 14);
            this.radioGercek.Name = "radioGercek";
            this.radioGercek.Size = new System.Drawing.Size(111, 25);
            this.radioGercek.TabIndex = 1;
            this.radioGercek.TabStop = true;
            this.radioGercek.Text = "Gerçek Kişi";
            this.radioGercek.UseVisualStyleBackColor = true;
            this.radioGercek.CheckedChanged += new System.EventHandler(this.radioGercek_CheckedChanged);
            // 
            // radioTuzel
            // 
            this.radioTuzel.AutoSize = true;
            this.radioTuzel.Location = new System.Drawing.Point(301, 14);
            this.radioTuzel.Name = "radioTuzel";
            this.radioTuzel.Size = new System.Drawing.Size(68, 25);
            this.radioTuzel.TabIndex = 2;
            this.radioTuzel.TabStop = true;
            this.radioTuzel.Text = "Tüzel";
            this.radioTuzel.UseVisualStyleBackColor = true;
            this.radioTuzel.CheckedChanged += new System.EventHandler(this.radioTuzel_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(453, 29);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adı";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(134, 135);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(453, 29);
            this.txtLastName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(134, 172);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(453, 29);
            this.txtPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(134, 208);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(453, 99);
            this.txtAdress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adres";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(446, 321);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(141, 46);
            this.btnClearForm.TabIndex = 9;
            this.btnClearForm.Text = "Formu Temizle";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(136, 329);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(215, 29);
            this.txtCustomerId.TabIndex = 14;
            this.txtCustomerId.Visible = false;
            // 
            // FrmCustomerSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(602, 392);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioTuzel);
            this.Controls.Add(this.radioGercek);
            this.Controls.Add(this.txtTcVergiNo);
            this.Controls.Add(this.btnCustomerSave);
            this.Controls.Add(this.lblTcVergino);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomerSave";
            this.Text = "Müşteri Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTcVergino;
        private Button btnCustomerSave;
        private TextBox txtTcVergiNo;
        private RadioButton radioGercek;
        private RadioButton radioTuzel;
        private TextBox txtName;
        private Label label1;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAdress;
        private Label label4;
        private Button btnClearForm;
        private TextBox txtCustomerId;
    }
}