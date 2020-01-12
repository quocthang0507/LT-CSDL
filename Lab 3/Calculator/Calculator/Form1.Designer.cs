namespace Calculator
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
			this.lblTieuDe = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSo1 = new System.Windows.Forms.TextBox();
			this.txtKetQua = new System.Windows.Forms.TextBox();
			this.txtSo2 = new System.Windows.Forms.TextBox();
			this.btnCong = new System.Windows.Forms.Button();
			this.btnTru = new System.Windows.Forms.Button();
			this.btnChia = new System.Windows.Forms.Button();
			this.btnNhan = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTieuDe
			// 
			this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
			this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
			this.lblTieuDe.Name = "lblTieuDe";
			this.lblTieuDe.Size = new System.Drawing.Size(359, 41);
			this.lblTieuDe.TabIndex = 0;
			this.lblTieuDe.Text = "MÁY TÍNH CẦM TAY";
			this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(33, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập số 1";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(33, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nhập số 2";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(33, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kết quả";
			// 
			// txtSo1
			// 
			this.txtSo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.txtSo1.Location = new System.Drawing.Point(105, 44);
			this.txtSo1.MaxLength = 100;
			this.txtSo1.Name = "txtSo1";
			this.txtSo1.Size = new System.Drawing.Size(225, 21);
			this.txtSo1.TabIndex = 1;
			// 
			// txtKetQua
			// 
			this.txtKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtKetQua.Enabled = false;
			this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.txtKetQua.Location = new System.Drawing.Point(105, 108);
			this.txtKetQua.MaxLength = 150;
			this.txtKetQua.Name = "txtKetQua";
			this.txtKetQua.ReadOnly = true;
			this.txtKetQua.Size = new System.Drawing.Size(225, 21);
			this.txtKetQua.TabIndex = 8;
			// 
			// txtSo2
			// 
			this.txtSo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.txtSo2.Location = new System.Drawing.Point(105, 74);
			this.txtSo2.MaxLength = 100;
			this.txtSo2.Name = "txtSo2";
			this.txtSo2.Size = new System.Drawing.Size(225, 21);
			this.txtSo2.TabIndex = 2;
			// 
			// btnCong
			// 
			this.btnCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnCong.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnCong.FlatAppearance.BorderSize = 2;
			this.btnCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.btnCong.ForeColor = System.Drawing.Color.Red;
			this.btnCong.Location = new System.Drawing.Point(58, 158);
			this.btnCong.Name = "btnCong";
			this.btnCong.Size = new System.Drawing.Size(41, 31);
			this.btnCong.TabIndex = 3;
			this.btnCong.Text = "+";
			this.btnCong.UseVisualStyleBackColor = false;
			this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
			// 
			// btnTru
			// 
			this.btnTru.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnTru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnTru.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnTru.FlatAppearance.BorderSize = 2;
			this.btnTru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.btnTru.ForeColor = System.Drawing.Color.Red;
			this.btnTru.Location = new System.Drawing.Point(105, 158);
			this.btnTru.Name = "btnTru";
			this.btnTru.Size = new System.Drawing.Size(41, 31);
			this.btnTru.TabIndex = 4;
			this.btnTru.Text = "-";
			this.btnTru.UseVisualStyleBackColor = false;
			this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
			// 
			// btnChia
			// 
			this.btnChia.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnChia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnChia.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnChia.FlatAppearance.BorderSize = 2;
			this.btnChia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.btnChia.ForeColor = System.Drawing.Color.Red;
			this.btnChia.Location = new System.Drawing.Point(201, 158);
			this.btnChia.Name = "btnChia";
			this.btnChia.Size = new System.Drawing.Size(41, 31);
			this.btnChia.TabIndex = 6;
			this.btnChia.Text = "/";
			this.btnChia.UseVisualStyleBackColor = false;
			this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
			// 
			// btnNhan
			// 
			this.btnNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnNhan.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnNhan.FlatAppearance.BorderSize = 2;
			this.btnNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.btnNhan.ForeColor = System.Drawing.Color.Red;
			this.btnNhan.Location = new System.Drawing.Point(152, 158);
			this.btnNhan.Name = "btnNhan";
			this.btnNhan.Size = new System.Drawing.Size(41, 31);
			this.btnNhan.TabIndex = 5;
			this.btnNhan.Text = "*";
			this.btnNhan.UseVisualStyleBackColor = false;
			this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnXoa.FlatAppearance.BorderSize = 2;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
			this.btnXoa.ForeColor = System.Drawing.Color.Red;
			this.btnXoa.Location = new System.Drawing.Point(252, 158);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(54, 31);
			this.btnXoa.TabIndex = 7;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.CancelButton = this.btnXoa;
			this.ClientSize = new System.Drawing.Size(359, 217);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnNhan);
			this.Controls.Add(this.btnChia);
			this.Controls.Add(this.btnTru);
			this.Controls.Add(this.btnCong);
			this.Controls.Add(this.txtSo2);
			this.Controls.Add(this.txtKetQua);
			this.Controls.Add(this.txtSo1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTieuDe);
			this.Name = "Form1";
			this.Text = "Máy tính cầm tay";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTieuDe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSo1;
		private System.Windows.Forms.TextBox txtKetQua;
		private System.Windows.Forms.TextBox txtSo2;
		private System.Windows.Forms.Button btnCong;
		private System.Windows.Forms.Button btnTru;
		private System.Windows.Forms.Button btnChia;
		private System.Windows.Forms.Button btnNhan;
		private System.Windows.Forms.Button btnXoa;
	}
}

