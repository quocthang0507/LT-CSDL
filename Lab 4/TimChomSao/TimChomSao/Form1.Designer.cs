
namespace TimChomSao
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
			this.label3 = new System.Windows.Forms.Label();
			this.tbxNgaySinh = new System.Windows.Forms.TextBox();
			this.tbxThangSinh = new System.Windows.Forms.TextBox();
			this.btnLayChomSao = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(394, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bạn thuộc chòm sao gì?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(71, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ngày sinh";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(65, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tháng sinh";
			// 
			// tbxNgaySinh
			// 
			this.tbxNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.tbxNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tbxNgaySinh.Location = new System.Drawing.Point(161, 48);
			this.tbxNgaySinh.MaxLength = 2;
			this.tbxNgaySinh.Name = "tbxNgaySinh";
			this.tbxNgaySinh.Size = new System.Drawing.Size(140, 24);
			this.tbxNgaySinh.TabIndex = 1;
			// 
			// tbxThangSinh
			// 
			this.tbxThangSinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxThangSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.tbxThangSinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.tbxThangSinh.Location = new System.Drawing.Point(161, 90);
			this.tbxThangSinh.MaxLength = 2;
			this.tbxThangSinh.Name = "tbxThangSinh";
			this.tbxThangSinh.Size = new System.Drawing.Size(140, 24);
			this.tbxThangSinh.TabIndex = 2;
			// 
			// btnLayChomSao
			// 
			this.btnLayChomSao.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLayChomSao.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnLayChomSao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnLayChomSao.FlatAppearance.BorderSize = 2;
			this.btnLayChomSao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLayChomSao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.btnLayChomSao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnLayChomSao.Location = new System.Drawing.Point(19, 133);
			this.btnLayChomSao.Name = "btnLayChomSao";
			this.btnLayChomSao.Size = new System.Drawing.Size(122, 30);
			this.btnLayChomSao.TabIndex = 3;
			this.btnLayChomSao.Text = "Lấy chòm sao";
			this.btnLayChomSao.UseVisualStyleBackColor = true;
			this.btnLayChomSao.Click += new System.EventHandler(this.btnLayChomSao_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnXoa.FlatAppearance.BorderSize = 2;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnXoa.Location = new System.Drawing.Point(153, 133);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(94, 30);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnThoat.FlatAppearance.BorderSize = 2;
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnThoat.Location = new System.Drawing.Point(266, 133);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(94, 30);
			this.btnThoat.TabIndex = 5;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnLayChomSao;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.CancelButton = this.btnXoa;
			this.ClientSize = new System.Drawing.Size(394, 176);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnLayChomSao);
			this.Controls.Add(this.tbxThangSinh);
			this.Controls.Add(this.tbxNgaySinh);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Opacity = 0.95D;
			this.Text = "Lấy chòm sao - La Quốc Thắng";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxNgaySinh;
		private System.Windows.Forms.TextBox tbxThangSinh;
		private System.Windows.Forms.Button btnLayChomSao;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
	}
}

