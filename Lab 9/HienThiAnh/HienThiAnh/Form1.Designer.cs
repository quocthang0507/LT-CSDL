namespace HienThiAnh
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
			this.cbxDiaDanh = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pbxHinhAnh = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxHinhAnh)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(500, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "NƠI TÔI MUỐN ĐẾN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label2.Location = new System.Drawing.Point(18, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Chọn địa danh";
			// 
			// cbxDiaDanh
			// 
			this.cbxDiaDanh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxDiaDanh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbxDiaDanh.FormattingEnabled = true;
			this.cbxDiaDanh.Location = new System.Drawing.Point(16, 83);
			this.cbxDiaDanh.Name = "cbxDiaDanh";
			this.cbxDiaDanh.Size = new System.Drawing.Size(143, 21);
			this.cbxDiaDanh.TabIndex = 2;
			this.cbxDiaDanh.SelectedIndexChanged += new System.EventHandler(this.cbxDiaDanh_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label3.Location = new System.Drawing.Point(187, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ảnh minh hoạ";
			// 
			// pbxHinhAnh
			// 
			this.pbxHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbxHinhAnh.Location = new System.Drawing.Point(180, 83);
			this.pbxHinhAnh.Name = "pbxHinhAnh";
			this.pbxHinhAnh.Size = new System.Drawing.Size(308, 249);
			this.pbxHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxHinhAnh.TabIndex = 4;
			this.pbxHinhAnh.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.ClientSize = new System.Drawing.Size(500, 344);
			this.Controls.Add(this.pbxHinhAnh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbxDiaDanh);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Hiển thị ảnh - La Quốc Thắng";
			((System.ComponentModel.ISupportInitialize)(this.pbxHinhAnh)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDiaDanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxHinhAnh;
    }
}

