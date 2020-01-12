namespace DataBinding
{
    partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbx_Lop = new System.Windows.Forms.ComboBox();
			this.cbx_SinhVien = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Danh sách lớp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(187, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Danh sách sinh viên";
			// 
			// cbx_Lop
			// 
			this.cbx_Lop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbx_Lop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbx_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_Lop.FormattingEnabled = true;
			this.cbx_Lop.Location = new System.Drawing.Point(32, 90);
			this.cbx_Lop.Name = "cbx_Lop";
			this.cbx_Lop.Size = new System.Drawing.Size(121, 28);
			this.cbx_Lop.TabIndex = 1;
			// 
			// cbx_SinhVien
			// 
			this.cbx_SinhVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbx_SinhVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbx_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_SinhVien.FormattingEnabled = true;
			this.cbx_SinhVien.Location = new System.Drawing.Point(191, 90);
			this.cbx_SinhVien.Name = "cbx_SinhVien";
			this.cbx_SinhVien.Size = new System.Drawing.Size(164, 28);
			this.cbx_SinhVien.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aqua;
			this.ClientSize = new System.Drawing.Size(396, 172);
			this.Controls.Add(this.cbx_SinhVien);
			this.Controls.Add(this.cbx_Lop);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Data Binding";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Lop;
        private System.Windows.Forms.ComboBox cbx_SinhVien;
    }
}

