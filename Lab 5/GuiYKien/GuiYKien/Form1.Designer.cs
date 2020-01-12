namespace GuiYKien
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
			this.txtTen = new System.Windows.Forms.TextBox();
			this.chk_HaiLong = new System.Windows.Forms.CheckBox();
			this.btnGui = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên của bạn";
			// 
			// txtTen
			// 
			this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.txtTen.ForeColor = System.Drawing.Color.Black;
			this.txtTen.Location = new System.Drawing.Point(15, 39);
			this.txtTen.MaxLength = 100;
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(234, 26);
			this.txtTen.TabIndex = 1;
			// 
			// chk_HaiLong
			// 
			this.chk_HaiLong.AutoSize = true;
			this.chk_HaiLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.chk_HaiLong.ForeColor = System.Drawing.Color.Red;
			this.chk_HaiLong.Location = new System.Drawing.Point(15, 74);
			this.chk_HaiLong.Name = "chk_HaiLong";
			this.chk_HaiLong.Size = new System.Drawing.Size(333, 24);
			this.chk_HaiLong.TabIndex = 2;
			this.chk_HaiLong.Text = "Bạn có hài lòng với dịch vụ của chúng tôi";
			this.chk_HaiLong.ThreeState = true;
			this.chk_HaiLong.UseVisualStyleBackColor = true;
			// 
			// btnGui
			// 
			this.btnGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnGui.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnGui.FlatAppearance.BorderSize = 2;
			this.btnGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btnGui.ForeColor = System.Drawing.Color.Red;
			this.btnGui.Location = new System.Drawing.Point(16, 119);
			this.btnGui.Name = "btnGui";
			this.btnGui.Size = new System.Drawing.Size(111, 32);
			this.btnGui.TabIndex = 3;
			this.btnGui.Text = "Gửi ý kiến";
			this.btnGui.UseVisualStyleBackColor = false;
			this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(361, 172);
			this.Controls.Add(this.btnGui);
			this.Controls.Add(this.chk_HaiLong);
			this.Controls.Add(this.txtTen);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Gửi ý kiến";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.CheckBox chk_HaiLong;
		private System.Windows.Forms.Button btnGui;
	}
}

