using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiYKien
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGui_Click(object sender, EventArgs e)
		{
			string name = txtTen.Text;
			//string haiLong = chk_HaiLong.Checked == true ? "hài lòng" : chk_HaiLong.Checked == false ? "không hài lòng" : "phân vân";
			string haiLong = chk_HaiLong.CheckState == CheckState.Checked ? "hài lòng" : chk_HaiLong.CheckState == CheckState.Unchecked ? "không hài lòng" : "phân vân";
			string strShow = string.Format("Bạn {0} cảm thấy {1} về dịch vụ!", name, haiLong);
			MessageBox.Show(strShow);
		}
	}
}
