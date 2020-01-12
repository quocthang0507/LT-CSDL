using System;
using System.Threading;
using System.Windows.Forms;

namespace Threads
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void btn_DemNguoc_Click(object sender, EventArgs e)
		{
			Thread demNguoc = new Thread(() =>
			{
				int so;
				if (int.TryParse(tbx_So.Text, out so))
					if (so > 0)
					{
						for (int i = so; i > 0; i--)
						{
							Thread.Sleep(100);
							lbl_DemNguoc.Text = i.ToString();
						}
					}
			});
			demNguoc.Start();
		}

		private void btn_DemXuoi_Click(object sender, EventArgs e)
		{
			Thread demXuoi = new Thread(DemXuoi);
			demXuoi.Start();
		}

		void DemXuoi()
		{
			int so;
			if (int.TryParse(tbx_So.Text, out so))
				if (so > 0)
				{
					for (int i = 0; i < so; i++)
					{
						Thread.Sleep(100);
						lbl_DemXuoi.Text = i.ToString();
					}
				}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(1);
		}
	}
}
