namespace Threads
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
			this.tbx_So = new System.Windows.Forms.TextBox();
			this.btn_DemNguoc = new System.Windows.Forms.Button();
			this.btn_DemXuoi = new System.Windows.Forms.Button();
			this.lbl_DemNguoc = new System.Windows.Forms.Label();
			this.lbl_DemXuoi = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(142, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập số";
			// 
			// tbx_So
			// 
			this.tbx_So.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbx_So.Location = new System.Drawing.Point(207, 27);
			this.tbx_So.Name = "tbx_So";
			this.tbx_So.Size = new System.Drawing.Size(126, 22);
			this.tbx_So.TabIndex = 1;
			// 
			// btn_DemNguoc
			// 
			this.btn_DemNguoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DemNguoc.Location = new System.Drawing.Point(54, 92);
			this.btn_DemNguoc.Name = "btn_DemNguoc";
			this.btn_DemNguoc.Size = new System.Drawing.Size(151, 37);
			this.btn_DemNguoc.TabIndex = 2;
			this.btn_DemNguoc.Text = "Luồng 1 - Đếm ngược";
			this.btn_DemNguoc.UseVisualStyleBackColor = true;
			this.btn_DemNguoc.Click += new System.EventHandler(this.btn_DemNguoc_Click);
			// 
			// btn_DemXuoi
			// 
			this.btn_DemXuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DemXuoi.Location = new System.Drawing.Point(254, 92);
			this.btn_DemXuoi.Name = "btn_DemXuoi";
			this.btn_DemXuoi.Size = new System.Drawing.Size(151, 37);
			this.btn_DemXuoi.TabIndex = 3;
			this.btn_DemXuoi.Text = "Luồng 2 - Đếm xuôi";
			this.btn_DemXuoi.UseVisualStyleBackColor = true;
			this.btn_DemXuoi.Click += new System.EventHandler(this.btn_DemXuoi_Click);
			// 
			// lbl_DemNguoc
			// 
			this.lbl_DemNguoc.AutoSize = true;
			this.lbl_DemNguoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DemNguoc.Location = new System.Drawing.Point(82, 173);
			this.lbl_DemNguoc.Name = "lbl_DemNguoc";
			this.lbl_DemNguoc.Size = new System.Drawing.Size(85, 16);
			this.lbl_DemNguoc.TabIndex = 4;
			this.lbl_DemNguoc.Text = "Đếm ngược";
			// 
			// lbl_DemXuoi
			// 
			this.lbl_DemXuoi.AutoSize = true;
			this.lbl_DemXuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DemXuoi.Location = new System.Drawing.Point(310, 173);
			this.lbl_DemXuoi.Name = "lbl_DemXuoi";
			this.lbl_DemXuoi.Size = new System.Drawing.Size(71, 16);
			this.lbl_DemXuoi.TabIndex = 5;
			this.lbl_DemXuoi.Text = "Đếm xuôi";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(458, 223);
			this.Controls.Add(this.lbl_DemXuoi);
			this.Controls.Add(this.lbl_DemNguoc);
			this.Controls.Add(this.btn_DemXuoi);
			this.Controls.Add(this.btn_DemNguoc);
			this.Controls.Add(this.tbx_So);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Chương trình chạy đa luồng";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbx_So;
		private System.Windows.Forms.Button btn_DemNguoc;
		private System.Windows.Forms.Button btn_DemXuoi;
		private System.Windows.Forms.Label lbl_DemNguoc;
		private System.Windows.Forms.Label lbl_DemXuoi;
	}
}

