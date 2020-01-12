using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimChomSao
{
	public partial class Form1 : Form
	{
		int ngay, thang;
		string t;
		PictureBox pbxHinhAnh;
		Label lblThongTin;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			tbxNgaySinh.Clear();
			tbxThangSinh.Clear();
			pbxHinhAnh.Dispose();
			lblThongTin.Dispose();
			tbxNgaySinh.Focus();
			this.Size = new Size(410, 215);
		}

		void AddControl()
		{
			if (!this.Controls.Contains(pbxHinhAnh) && !this.Controls.Contains(lblThongTin))
			{
				this.Size = new Size(410, 374);
				pbxHinhAnh = new PictureBox() { Anchor = AnchorStyles.Top, Location = new Point(19, 173), Size = new Size(150, 150), SizeMode = PictureBoxSizeMode.StretchImage };
				lblThongTin = new Label() { Anchor = AnchorStyles.Top, Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(163))), ForeColor = Color.Red, Location = new Point(169, 212), Size = new Size(213, 77), TextAlign = ContentAlignment.MiddleCenter };
				this.Controls.Add(pbxHinhAnh);
				this.Controls.Add(lblThongTin);
			}
		}

		void ShowInfo(int index)
		{
			pbxHinhAnh.Image = TimChomSao.Properties.Resources.ResourceManager.GetObject("i" + index) as Image;
			pbxHinhAnh.Cursor = Cursors.Hand;
			t = TimChomSao.Properties.Resources.ResourceManager.GetString("t" + index);
			pbxHinhAnh.Click += pbxHinhAnh_Click;
			lblThongTin.Text = TimChomSao.Properties.Resources.ResourceManager.GetString("s" + index);
		}

		private void pbxHinhAnh_Click(object sender, EventArgs e)
		{
			MessageBox.Show(t, "Thông tin thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		bool CheckValidDate()
		{
			bool valid = false;
			if (ngay < 1 || ngay > 31)
				tbxNgaySinh.Focus();
			else if (thang < 1 || thang > 12)
				tbxThangSinh.Focus();
			else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
			{
				if (ngay == 31)
					tbxNgaySinh.Focus();
				else valid = true;
			}
			else if (thang == 2 && ngay > 29)
				tbxNgaySinh.Focus();
			else valid = true;
			return valid;
		}

		enum Month
		{
			January = 1,
			February = 2,
			March = 3,
			April = 4,
			May = 5,
			June = 6,
			July = 7,
			August = 8,
			September = 9,
			October = 10,
			November = 11,
			December = 12
		}

		private void btnLayChomSao_Click(object sender, EventArgs e)
		{
			if (int.TryParse(tbxNgaySinh.Text, out ngay) && int.TryParse(tbxThangSinh.Text, out thang))
			{
				if (CheckValidDate())
				{
					AddControl();
					switch ((Month)thang)
					{
						case Month.January:
							if (ngay >= 20)
								ShowInfo(1);
							else
								ShowInfo(12);
							break;
						case Month.February:
							if (ngay >= 19)
								ShowInfo(2);
							else
								ShowInfo(1);
							break;
						case Month.March:
							if (ngay >= 21)
								ShowInfo(3);
							else
								ShowInfo(2);
							break;
						case Month.April:
							if (ngay >= 20)
								ShowInfo(4);
							else
								ShowInfo(3);
							break;
						case Month.May:
							if (ngay >= 21)
								ShowInfo(5);
							else
								ShowInfo(4);
							break;
						case Month.June:
							if (ngay >= 22)
								ShowInfo(6);
							else
								ShowInfo(5);
							break;
						case Month.July:
							if (ngay >= 23)
								ShowInfo(7);
							else
								ShowInfo(6);
							break;
						case Month.August:
							if (ngay >= 23)
								ShowInfo(8);
							else
								ShowInfo(7);
							break;
						case Month.September:
							if (ngay >= 23)
								ShowInfo(9);
							else
								ShowInfo(8);
							break;
						case Month.October:
							if (ngay >= 23)
								ShowInfo(10);
							else
								ShowInfo(9);
							break;
						case Month.November:
							if (ngay >= 23)
								ShowInfo(11);
							else
								ShowInfo(10);
							break;
						case Month.December:
							if (ngay >= 22)
								ShowInfo(12);
							else
								ShowInfo(11);
							break;
						default:
							break;
					}
				}
			}
			else if (!int.TryParse(tbxNgaySinh.Text, out ngay))
				tbxNgaySinh.Focus();
			else tbxThangSinh.Focus();
		}
	}
}
