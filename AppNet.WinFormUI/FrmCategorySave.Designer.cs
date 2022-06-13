namespace AppNet.WinFormUI
{
    partial class FrmCategorySave
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
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(572, 146);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(75, 34);
            this.btnCategorySave.TabIndex = 0;
            this.btnCategorySave.Text = "Kaydet";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriName
            // 
            this.txtKategoriName.Location = new System.Drawing.Point(182, 100);
            this.txtKategoriName.Name = "txtKategoriName";
            this.txtKategoriName.Size = new System.Drawing.Size(465, 29);
            this.txtKategoriName.TabIndex = 2;
            // 
            // FrmCategorySave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 257);
            this.Controls.Add(this.txtKategoriName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategorySave);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCategorySave";
            this.Text = "Kategori Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCategorySave;
        private Label label1;
        private TextBox txtKategoriName;
    }
}