using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonAn
{
	public partial class Form1 : Form
	{
		List<Food> danhSach;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadFood();
		}

		void LoadFood()
		{
			danhSach = new List<Food>();
			danhSach.Add(new Food("Bánh tráng trộn", "7000"));
			danhSach.Add(new Food("Kem trái cây", "15000"));
			danhSach.Add(new Food("Chè Thái", "10000"));
			danhSach.Add(new Food("Chè chuối", "8000"));
			danhSach.Add(new Food("Bánh tráng hành", "5000"));
			danhSach.Add(new Food("Xắp xắp", "6000"));
			danhSach.Add(new Food("Bánh bao chiên", "5000"));
			cbx_Data.DataSource = danhSach;
			cbx_Data.DisplayMember = "Name";
		}

		private void btn_TimKiem_Click(object sender, EventArgs e)
		{
			List<Food> ketQua = new List<Food>();
			ketQua = danhSach.Where(f => f.Name.Contains(tbx_TenMonAn.Text)).ToList();
			cbx_Result.DataSource = ketQua;
			cbx_Result.DisplayMember = "Name";
		}
	}
}
