using System.Drawing;
using System.Windows.Forms;

namespace CacQuocGia
{
	public partial class Form1 : Form
	{
		ListView listView;
		ImageList smallImageList;
		ImageList largeImageList;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			CreateImageList();
			CreateListView();
		}

		void AddImage2ImageList(string name)
		{
			largeImageList.Images.Add(name, CacQuocGia.Properties.Resources.ResourceManager.GetObject(name) as Image);
			smallImageList.Images.Add(name, CacQuocGia.Properties.Resources.ResourceManager.GetObject(name) as Image);
		}

		private void CreateImageList()
		{
			smallImageList = new ImageList() { ImageSize = new Size(20, 20) };
			largeImageList = new ImageList() { ImageSize = new Size(100, 100) };
			AddImage2ImageList("US");
			AddImage2ImageList("Australia");
			AddImage2ImageList("UK");
			AddImage2ImageList("Vietnam");
			AddImage2ImageList("Sudan");
		}

		void AddRowToListView(string itemName, string countryName, string continent, string capital)
		{
			ListViewItem item = new ListViewItem();
			item.Name = itemName;
			item = new ListViewItem(new string[] { countryName, continent, capital });
			item.ImageIndex = smallImageList.Images.IndexOfKey(countryName);
			listView.Items.Add(item);
		}

		void CreateListView()
		{
			listView = new ListView() { Size = new Size(559, 352), Location = new Point(12, 41), Dock = DockStyle.Bottom, Anchor = AnchorStyles.Top, GridLines = true, Font = new Font("Times New Roman", 13), BackColor = Color.Aquamarine, SmallImageList = smallImageList, LargeImageList = largeImageList, MultiSelect = true };
			this.Controls.Add(listView);
			listView.Columns.Add("Tên nước");
			listView.Columns.Add("Châu lục");
			listView.Columns.Add("Thủ đô");
			listView.View = View.Details;
			AddRowToListView("item1", "US", "Châu Mỹ", "Washington");
			AddRowToListView("item2", "Australia", "Châu Úc", "Canberra");
			AddRowToListView("item3", "UK", "Châu Âu", "London");
			AddRowToListView("item4", "Vietnam", "Châu Á", "Hà Nội");
			AddRowToListView("item5", "Sudan", "Châu Phi", "Khartoum");
			listView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
			listView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
			listView.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
			listView.SelectedIndexChanged += ListView_SelectedIndexChanged;
		}

		private void ListView_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string message = "";
			ListView selectedListView = sender as ListView;
			if (selectedListView.SelectedItems.Count > 0)
			{
				foreach (ListViewItem item in selectedListView.SelectedItems)
					message += item.SubItems[0].Text + " - " + item.SubItems[1].Text + " - " + item.SubItems[2].Text + "\r\n";
				MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void lblLargeIcon_Click(object sender, System.EventArgs e)
		{
			listView.CheckBoxes = false;
			listView.FullRowSelect = false;
			listView.View = View.LargeIcon;
		}

		private void lblSmallIcon_Click(object sender, System.EventArgs e)
		{
			listView.CheckBoxes = false;
			listView.FullRowSelect = false;
			listView.View = View.SmallIcon;
		}

		private void lblDetails_Click(object sender, System.EventArgs e)
		{
			listView.CheckBoxes = true;
			listView.FullRowSelect = true;
			listView.View = View.Details;
		}

		private void lblList_Click(object sender, System.EventArgs e)
		{
			listView.CheckBoxes = false;
			listView.FullRowSelect = false;
			listView.View = View.List;
		}

		private void lblTile_Click(object sender, System.EventArgs e)
		{
			listView.CheckBoxes = false;
			listView.FullRowSelect = false;
			listView.View = View.Tile;
		}
	}
}
