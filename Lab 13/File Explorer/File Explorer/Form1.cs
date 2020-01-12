using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace File_Explorer
{
	public partial class Form1 : Form
	{
		View view;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			GetImageFormResource();
			PopulateTreeView();
			view = lvExplorer.View;
			foreach (ToolStripItem item in viewToolStripMenuItem.DropDownItems)
			{
				item.MouseHover += Item_MouseHover;
			}
		}

		private void Item_MouseHover(object sender, EventArgs e)
		{
			subMenuItem_MouseHover(sender.ToString());
		}

		void GetImageFormResource()
		{
			string[] imageNames = { "Drive", "Folder_Closed", "Folder_Opened", "Archive", "File", "Application" };
			largeImageList.ImageSize = new Size(75, 75);
			smallImageList.ImageSize = new Size(20, 20);
			foreach (var item in imageNames)
			{
				smallImageList.Images.Add(item, File_Explorer.Properties.Resources.ResourceManager.GetObject(item) as Image);
				largeImageList.Images.Add(item, File_Explorer.Properties.Resources.ResourceManager.GetObject(item) as Image);
			}
			lvExplorer.LargeImageList = largeImageList;
			lvExplorer.SmallImageList = smallImageList;
		}

		void PopulateTreeView()
		{
			TreeNode rootNode;
			DirectoryInfo info = new DirectoryInfo(@"D:\");
			if (info.Exists)
			{
				rootNode = new TreeNode(info.Name);
				rootNode.Tag = info;
				rootNode.ImageIndex = 0;
				GetDirectories(info.GetDirectories(), rootNode);
				tvExplorer.Nodes.Add(rootNode);
			}
		}

		//Find all files and folders recursively
		private void GetDirectories(DirectoryInfo[] subDirs, TreeNode rootNode)
		{
			TreeNode aNode;
			DirectoryInfo[] subSubDirs;
			var filtered = subDirs.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
			try
			{
				foreach (DirectoryInfo subDir in filtered)
				{
					aNode = new TreeNode(subDir.Name, 1, 2);
					aNode.Tag = subDir;
					subSubDirs = subDir.GetDirectories();
					if (subSubDirs.Length != 0)
						GetDirectories(subSubDirs, aNode);
					rootNode.Nodes.Add(aNode);
				}
			}
			catch (Exception)
			{
				//throw;
			}
		}

		string[] archive_formats = { "iso", "7z", "rar", "zip" };

		void LoadFromTreeViewToListView(TreeView treeView, TreeNode newSelected)
		{
			lvExplorer.Items.Clear();
			DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
			ListViewItem.ListViewSubItem[] subItems;
			ListViewItem item = null;
			var dir_filtered = nodeDirInfo.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
			foreach (DirectoryInfo dir in dir_filtered)
			{
				item = new ListViewItem(dir.Name, 1);
				subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, dir.LastAccessTime.ToShortDateString()) };
				item.SubItems.AddRange(subItems);
				item.ImageKey = "Folder_Closed";
				lvExplorer.Items.Add(item);
			}
			var file_filtered = nodeDirInfo.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
			foreach (FileInfo file in file_filtered)
			{
				item = new ListViewItem(file.Name);
				subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "File"), new ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()) };
				item.SubItems.AddRange(subItems);
				string[] temp = file.Name.Split('.');
				if (temp[temp.Length - 1] == "exe")
					item.ImageIndex = 5;
				else if (Array.Exists(archive_formats, t => t == temp[temp.Length - 1]))
					item.ImageIndex = 3;
				else
					item.ImageIndex = 4;
				lvExplorer.Items.Add(item);
			}
			lvExplorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void tvExplorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			LoadFromTreeViewToListView((TreeView)sender, e.Node);
		}

		private void lvExplorer_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView lv = sender as ListView;
			if (lv.SelectedItems.Count > 0)
			{
				string path;
				foreach (ListViewItem item in lv.SelectedItems)
					if (string.Compare(item.SubItems[1].Text, "File") == 0)
					{
						path = tvExplorer.SelectedNode.FullPath + "\\" + lv.SelectedItems[0].Text;
						Process.Start(path);
					}
					else
					{
						path = lv.SelectedItems[0].SubItems[0].Text;
						foreach (TreeNode node in tvExplorer.SelectedNode.Nodes)
						{
							if (string.Compare(path, node.Text) == 0)
							{
								tvExplorer.SelectedNode = node;
								tvExplorer.SelectedNode.Expand();
								LoadFromTreeViewToListView(tvExplorer, node);
							}
						}
					}
			}
		}

		//Display closed folder icon
		private void tvExplorer_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			if (e.Node != tvExplorer.Nodes[0])
				e.Node.ImageIndex = 1;
		}

		//Display opened folder icon
		private void tvExplorer_AfterExpand(object sender, TreeViewEventArgs e)
		{
			if (e.Node != tvExplorer.Nodes[0])
				e.Node.ImageIndex = 2;
		}

		private void smallIcon_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.SmallIcon;
			view = lvExplorer.View;
		}

		private void largeIcon_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.LargeIcon;
			view = lvExplorer.View;
		}

		private void details_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = true;
			lvExplorer.FullRowSelect = true;
			lvExplorer.View = View.Details;
			view = lvExplorer.View;
		}

		private void list_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.List;
			view = lvExplorer.View;
		}

		private void tile_Click(object sender, EventArgs e)
		{
			lvExplorer.CheckBoxes = false;
			lvExplorer.FullRowSelect = false;
			lvExplorer.View = View.Tile;
			view = lvExplorer.View;
		}

		private void viewToolStripMenuItem_MouseLeave(object sender, EventArgs e)
		{
			lvExplorer.View = view;
		}

		private void subMenuItem_MouseHover(string item)
		{
			switch (item)
			{
				case "Details":
					lvExplorer.View = View.Details;
					break;
				case "List":
					lvExplorer.View = View.List;
					break;
				case "Tile":
					lvExplorer.View = View.Tile;
					break;
				case "Large Icon":
					lvExplorer.View = View.LargeIcon;
					break;
				case "Small Icon":
					lvExplorer.View = View.SmallIcon;
					break;
				default:
					break;
			}
		}

		private void viewToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
		{
			lvExplorer.View = view;
		}
	}
}
