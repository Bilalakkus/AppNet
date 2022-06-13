namespace AppNet.WinFormUI
{
    partial class FrmCustomerList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTcVergiNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTcVergiNo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCustomerFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCustomerList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtLastName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtTcVergiNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTcVergiNo);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnCustomerFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 648);
            this.panel1.TabIndex = 0;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(127, 264);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(234, 29);
            this.TxtLastName.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 213);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 29);
            this.txtName.TabIndex = 9;
            // 
            // txtTcVergiNo
            // 
            this.txtTcVergiNo.Location = new System.Drawing.Point(127, 162);
            this.txtTcVergiNo.Name = "txtTcVergiNo";
            this.txtTcVergiNo.Size = new System.Drawing.Size(234, 29);
            this.txtTcVergiNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adı";
            // 
            // lblTcVergiNo
            // 
            this.lblTcVergiNo.AutoSize = true;
            this.lblTcVergiNo.Location = new System.Drawing.Point(9, 162);
            this.lblTcVergiNo.Name = "lblTcVergiNo";
            this.lblTcVergiNo.Size = new System.Drawing.Size(112, 21);
            this.lblTcVergiNo.TabIndex = 3;
            this.lblTcVergiNo.Text = "TC. Kimlik No";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 29);
            this.comboBox1.TabIndex = 2;
            // 
            // btnCustomerFilter
            // 
            this.btnCustomerFilter.Location = new System.Drawing.Point(286, 317);
            this.btnCustomerFilter.Name = "btnCustomerFilter";
            this.btnCustomerFilter.Size = new System.Drawing.Size(75, 34);
            this.btnCustomerFilter.TabIndex = 1;
            this.btnCustomerFilter.Text = "Bul";
            this.btnCustomerFilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Türü";
            // 
            // gridCustomerList
            // 
            this.gridCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomerList.Location = new System.Drawing.Point(393, 12);
            this.gridCustomerList.Name = "gridCustomerList";
            this.gridCustomerList.RowTemplate.Height = 25;
            this.gridCustomerList.Size = new System.Drawing.Size(677, 647);
            this.gridCustomerList.TabIndex = 1;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1073, 764);
            this.Controls.Add(this.gridCustomerList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomerList";
            this.Text = "Müşteriler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox TxtLastName;
        private TextBox txtName;
        private TextBox txtTcVergiNo;
        private Label label4;
        private Label label3;
        private Label lblTcVergiNo;
        private ComboBox comboBox1;
        private Button btnCustomerFilter;
        private Label label1;
        private DataGridView gridCustomerList;
    }
}