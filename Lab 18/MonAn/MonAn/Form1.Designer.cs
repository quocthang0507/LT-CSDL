namespace MonAn
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.tbx_TenMonAn = new System.Windows.Forms.TextBox();
			this.btn_TimKiem = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbx_Data = new System.Windows.Forms.ComboBox();
			this.cbx_Result = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btn_TimKiem);
			this.splitContainer1.Panel1.Controls.Add(this.tbx_TenMonAn);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(558, 353);
			this.splitContainer1.SplitterDistance = 63;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.cbx_Data);
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.cbx_Result);
			this.splitContainer2.Panel2.Controls.Add(this.label3);
			this.splitContainer2.Size = new System.Drawing.Size(558, 285);
			this.splitContainer2.SplitterDistance = 274;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập tên món ăn cầm tìm:";
			// 
			// tbx_TenMonAn
			// 
			this.tbx_TenMonAn.Location = new System.Drawing.Point(196, 22);
			this.tbx_TenMonAn.Name = "tbx_TenMonAn";
			this.tbx_TenMonAn.Size = new System.Drawing.Size(173, 21);
			this.tbx_TenMonAn.TabIndex = 1;
			// 
			// btn_TimKiem
			// 
			this.btn_TimKiem.Location = new System.Drawing.Point(377, 18);
			this.btn_TimKiem.Name = "btn_TimKiem";
			this.btn_TimKiem.Size = new System.Drawing.Size(87, 27);
			this.btn_TimKiem.TabIndex = 2;
			this.btn_TimKiem.Text = "Tìm kiếm";
			this.btn_TimKiem.UseVisualStyleBackColor = true;
			this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Các món ăn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Kết quả tìm kiếm";
			// 
			// cbx_Data
			// 
			this.cbx_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.cbx_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.cbx_Data.FormattingEnabled = true;
			this.cbx_Data.Location = new System.Drawing.Point(35, 54);
			this.cbx_Data.Name = "cbx_Data";
			this.cbx_Data.Size = new System.Drawing.Size(200, 217);
			this.cbx_Data.TabIndex = 1;
			// 
			// cbx_Result
			// 
			this.cbx_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.cbx_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.cbx_Result.FormattingEnabled = true;
			this.cbx_Result.Location = new System.Drawing.Point(41, 54);
			this.cbx_Result.Name = "cbx_Result";
			this.cbx_Result.Size = new System.Drawing.Size(210, 216);
			this.cbx_Result.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 353);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.Name = "Form1";
			this.Text = "Tìm kiếm món ăn";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btn_TimKiem;
		private System.Windows.Forms.TextBox tbx_TenMonAn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ComboBox cbx_Data;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbx_Result;
		private System.Windows.Forms.Label label3;
	}
}

