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
            this.btnListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTcVergino
            // 
            this.lblTcVergino.AutoSize = true;
            this.lblTcVergino.Location = new System.Drawing.Point(107, 131);
            this.lblTcVergino.Name = "lblTcVergino";
            this.lblTcVergino.Size = new System.Drawing.Size(112, 21);
            this.lblTcVergino.TabIndex = 0;
            this.lblTcVergino.Text = "TC. Kimlik No";
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Location = new System.Drawing.Point(354, 459);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(83, 46);
            this.btnCustomerSave.TabIndex = 1;
            this.btnCustomerSave.Text = "Kaydet";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // txtTcVergiNo
            // 
            this.txtTcVergiNo.Location = new System.Drawing.Point(232, 131);
            this.txtTcVergiNo.Name = "txtTcVergiNo";
            this.txtTcVergiNo.Size = new System.Drawing.Size(453, 29);
            this.txtTcVergiNo.TabIndex = 2;
            // 
            // radioGercek
            // 
            this.radioGercek.AutoSize = true;
            this.radioGercek.Location = new System.Drawing.Point(233, 84);
            this.radioGercek.Name = "radioGercek";
            this.radioGercek.Size = new System.Drawing.Size(111, 25);
            this.radioGercek.TabIndex = 3;
            this.radioGercek.TabStop = true;
            this.radioGercek.Text = "Gerçek Kişi";
            this.radioGercek.UseVisualStyleBackColor = true;
            // 
            // radioTuzel
            // 
            this.radioTuzel.AutoSize = true;
            this.radioTuzel.Location = new System.Drawing.Point(399, 84);
            this.radioTuzel.Name = "radioTuzel";
            this.radioTuzel.Size = new System.Drawing.Size(68, 25);
            this.radioTuzel.TabIndex = 4;
            this.radioTuzel.TabStop = true;
            this.radioTuzel.Text = "Tüzel";
            this.radioTuzel.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 180);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(453, 29);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adı";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(232, 228);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(453, 29);
            this.txtLastName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(232, 278);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(453, 29);
            this.txtPhone.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(232, 331);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(453, 99);
            this.txtAdress.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adres";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(544, 459);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(141, 46);
            this.btnClearForm.TabIndex = 13;
            this.btnClearForm.Text = "Formu Temizle";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(444, 459);
            this.btnListe.Margin = new System.Windows.Forms.Padding(4);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(93, 46);
            this.btnListe.TabIndex = 17;
            this.btnListe.Text = "Liste";
            this.btnListe.UseVisualStyleBackColor = true;
            // 
            // FrmCustomerSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(760, 630);
            this.Controls.Add(this.btnListe);
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
        private Button btnListe;
    }
}