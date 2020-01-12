using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCong_Click(object sender, EventArgs e)
		{
			double so1, so2;
			if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
				txtKetQua.Text = (so1 + so2).ToString();
			else if (!double.TryParse(txtSo1.Text, out so1))
				txtSo1.Focus();
			else txtSo2.Focus();
		}

		private void btnTru_Click(object sender, EventArgs e)
		{
			double so1, so2;
			if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
				txtKetQua.Text = (so1 - so2).ToString();
			else if (!double.TryParse(txtSo1.Text, out so1))
				txtSo1.Focus();
			else txtSo2.Focus();
		}

		private void btnNhan_Click(object sender, EventArgs e)
		{
			double so1, so2;
			if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
				txtKetQua.Text = (so1 * so2).ToString();
			else if (!double.TryParse(txtSo1.Text, out so1))
				txtSo1.Focus();
			else txtSo2.Focus();
		}

		private void btnChia_Click(object sender, EventArgs e)
		{
			double so1, so2;
			if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
				if (so2 != 0)
					txtKetQua.Text = (so1 / so2).ToString();
				else txtSo2.Focus();
			else if (!double.TryParse(txtSo1.Text, out so1))
				txtSo1.Focus();
			else txtSo2.Focus();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			txtSo1.Clear();
			txtSo2.Clear();
			txtKetQua.Clear();
			txtSo1.Focus();
		}
	}
}
