using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBinding
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		void DataBinding()
		{
			cbx_SinhVien.DataBindings.Add("DataSource", cbx_Lop.DataSource, "DanhSachSinhVien");
		}

		List<Lop> DanhSachLop;

		private void Form1_Load(object sender, EventArgs e)
		{

			DanhSachLop = new List<Lop>();
			DanhSachLop.Add(new Lop()
			{
				tenLop = "CTK40",
				//DanhSachSinhVien = new List<string>() { "Trung", "Toàn", "Thắng", "Quốc", "Hiệp" }
				DanhSachSinhVien=new List<string>() { "A","B","C"}.
			});
			DanhSachLop[0].
			DanhSachLop.Add(new Lop()
			{
				tenLop = "CTK41",
				DanhSachSinhVien = new List<string>() { "Hưng", "Hùng", "Hoàng", "Hành", "Hà" }
			});
			DanhSachLop.Add(new Lop()
			{
				tenLop = "CTK42",
				DanhSachSinhVien = new List<string>() { "Linh", "Long", "Lâm", "Lân", "Lãm" }
			});
			DanhSachLop.Add(new Lop()
			{
				tenLop = "CTK43",
				DanhSachSinhVien = new List<string>() { "Tài", "Tính", "Thi", "Trinh", "Trang" }
			});
			DanhSachLop.Add(new Lop()
			{
				tenLop = "CTK44",
				DanhSachSinhVien = new List<string>() { "Chương", "Chi", "Chinh", "Chang", "Chung" }
			});
			cbx_Lop.DataSource = DanhSachLop;
			cbx_Lop.DisplayMember = "tenLop";
			DataBinding();
		}
	}

	public class Lop
	{
		public string tenLop { get; set; }
		public List<string> DanhSachSinhVien { get; set; }
	}
}
