using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraTracNghiem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			SortIt();
			timer1.Start();
		}

		void SortIt()
		{
			//Sắp xếp danh sách control theo tên
			System.Collections.Generic.IEnumerable<Control> sortedlist =
				from control in this.Controls.Cast<Control>()
				orderby control.Name
				select control;
			int counter = 0;
			//Áp dụng thứ tự đó vào ControlCollection
			foreach (Control control in sortedlist)
			{
				this.Controls.SetChildIndex(control, counter);
				counter++;
			}
		}

		bool GetResult()
		{
			bool coTraLoi = false;
			int i = 1;
			foreach (var panel in this.Controls)
			{
				if (panel is Panel)
				{
					((Panel)panel).Enabled = false;
					foreach (var radioBtn in ((Panel)panel).Controls)
					{
						if (radioBtn is RadioButton)
							if (((RadioButton)radioBtn).Checked)
							{
								coTraLoi = true;
								richTextBox1.Text += string.Format("Câu {0}: {1}\n", i++, ((RadioButton)radioBtn).Text);
							}
					}
				}
			}
			return coTraLoi;
		}

		private void btnNopBai_Click(object sender, EventArgs e)
		{
			btnNopBai.Enabled = false;
			DialogResult msg = MessageBox.Show("Bạn có chắc chắn nộp bài?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (msg == DialogResult.OK)
			{
				btnThoat.Enabled = true;
				bool coLamBai = GetResult();
				if (!coLamBai)
					MessageBox.Show("Bạn chưa làm bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		Color RandomColor()
		{
			Random n = new Random();
			return System.Drawing.Color.FromArgb(n.Next(255), n.Next(255), n.Next(255));
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.BackColor = RandomColor();
		}
	}
}
