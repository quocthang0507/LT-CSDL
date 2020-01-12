﻿using System;
using System.Collections.Specialized;
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
        string currentNode = "";
        string[] archive_formats = { "iso", "7z", "rar", "zip" };
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        string[] imageNames = { "Drive", "Folder_Closed", "Folder_Opened", "Archive", "File", "Application" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getImageFormResource();
            populateTreeView();
            view = lvExplorer.View;
            foreach (ToolStripItem item in viewToolStripMenuItem.DropDownItems)
                item.MouseHover += Item_MouseHover;
            addNotifyIcon();
        }

        void addNotifyIcon()
        {
            notifyIcon.Icon = SystemIcons.Application;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipTitle = "Thông báo!";
            notifyIcon.BalloonTipText = "Chương trình đang chạy";
            notifyIcon.ShowBalloonTip(2000);
        }

        private void Item_MouseHover(object sender, EventArgs e)
        {
            subMenuItem_MouseHover(sender.ToString());
        }

        void getImageFormResource()
        {
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

        void populateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"D:\");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                rootNode.ImageIndex = 0;
                getDirectories(info.GetDirectories(), rootNode);
                tvExplorer.Nodes.Add(rootNode);
            }
        }

        //Find all files and folders recursively
        void getDirectories(DirectoryInfo[] subDirs, TreeNode rootNode)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;	//Thư mục con của thư mục gốc
            var filtered = subDirs.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
			//Với mỗi thư mục gốc hay thư mục trong subDirs
			foreach (DirectoryInfo subDir in filtered)
            {
				//Tạo một node mới
				aNode = new TreeNode(subDir.Name, 1, 2);
                aNode.Tag = subDir;
                subSubDirs = subDir.GetDirectories();	//Tìm các subSubDirs có trong subDirs
                if (subSubDirs.Length != 0)
                    getDirectories(subSubDirs, aNode);	//Thêm vào node đó
                rootNode.Nodes.Add(aNode);	//Thêm vào node gốc
            }
        }

        string convertFileLength(double len)
        {
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return string.Format("{0:0.##} {1}", len, sizes[order]);
        }

        double getDirectorySize(string folderPath)
        {
            double size = 0;
            DirectoryInfo info = new DirectoryInfo(folderPath);
            DirectoryInfo[] subDirs = info.GetDirectories();
            var filtered = subDirs.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
            if (subDirs.Length > 0)
                foreach (var dir in filtered)
                {
                    size += getDirectorySize(dir.FullName);
                }
            FileInfo[] subFiles = info.GetFiles();
            size += subFiles.Sum(f => f.Length);
            return size;
        }

        string getListDirectories(string path)
        {
            string result = "";
            DirectoryInfo info = new DirectoryInfo(path);
            DirectoryInfo[] subDirs = info.GetDirectories();
            var filtered = subDirs.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
            if (subDirs.Length > 0)
                foreach (var dir in filtered)
                {
                    result += dir.Name + ", ";
                    if (result.Length > 50)
                    {
                        result += "...";
                        break;
                    }
                }
            return result;
        }

        string getListFiles(string path)
        {
            string result = "";
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] subFiles = info.GetFiles();
            var filtered = subFiles.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
            if (subFiles.Length > 0)
                foreach (var file in filtered)
                {
                    result += file.Name + ", ";
                    if (result.Length > 50)
                    {
                        result += "...";
                        break;
                    }
                }
            return result;
        }

        string getOwnerFile(string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            return info.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
        }

        string getType(string fileNameOrExtension)
        {
            string mimeType = "application/unknown";
            string ext = (fileNameOrExtension.Contains(".")) ? System.IO.Path.GetExtension(fileNameOrExtension).ToLower() : "." + fileNameOrExtension;
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null) mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }

        ListViewItem createNewListItem(Object _object)
        {
            ListViewItem item = null;
            ListViewItem.ListViewSubItem[] subItems;
            if (_object is DirectoryInfo)
            {
                item = new ListViewItem(((DirectoryInfo)_object).Name, 1);
                subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "Directory"), new ListViewItem.ListViewSubItem(item, ((DirectoryInfo)_object).LastAccessTime.ToShortDateString()) };
                item.SubItems.AddRange(subItems);
                item.ImageKey = "Folder_Closed";
            }
            else if (_object is FileInfo)
            {
                item = new ListViewItem(((FileInfo)_object).Name);
                subItems = new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(item, "File"), new ListViewItem.ListViewSubItem(item, ((FileInfo)_object).LastAccessTime.ToShortDateString()) };
                item.SubItems.AddRange(subItems);
                string[] temp = item.Text.Split('.');
                if (temp[temp.Length - 1] == "exe")
                    item.ImageIndex = 5;
                else if (Array.Exists(archive_formats, t => t == temp[temp.Length - 1]))
                    item.ImageIndex = 3;
                else
                    item.ImageIndex = 4;
            }
            return item;
        }

        void setStatusBar()
        {
            status1.Text = lvExplorer.Items.Count.ToString() + " item(s)";
            status2.Text = lvExplorer.SelectedItems.Count.ToString() + " item(s) selected";
        }

        void loadFromTreeViewToListView(TreeView treeView, TreeNode newSelected)
        {
            lvExplorer.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            var dir_filtered = nodeDirInfo.GetDirectories().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
            foreach (DirectoryInfo dir in dir_filtered)
                lvExplorer.Items.Add(createNewListItem(dir));
            var file_filtered = nodeDirInfo.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));
            foreach (FileInfo file in file_filtered)
                lvExplorer.Items.Add(createNewListItem(file));
            currentNode = nodeDirInfo.FullName;
            lvExplorer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            setStatusBar();
        }

        private void tvExplorer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            loadFromTreeViewToListView((TreeView)sender, e.Node);
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

        private void viewToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
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

        private void lvExplorer_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            ListViewItem item = e.Item;
            string info, currentPath;
            currentPath = currentNode + "\\" + item.Text;
            if (item.SubItems[1].Text == "File")
            {
                FileInfo file = new FileInfo(currentPath);
                info = String.Format("Type: {0}\r\nAuthors: {1}\r\nSize: {2}\r\nDate Modified: {3}", getType(file.Extension), getOwnerFile(file.FullName), convertFileLength(file.Length), file.LastWriteTime.ToShortDateString());
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(currentPath);
                info = String.Format("Date created: {0}\r\nSize: {1}\r\nFiles: {2}\r\nFolders: {3}", dir.CreationTime.ToShortDateString() + " " + dir.CreationTime.ToShortTimeString(), convertFileLength(getDirectorySize(dir.FullName)), getListFiles(dir.FullName), getListDirectories(dir.FullName));
            }
            item.ToolTipText = info;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string currentPath = currentNode + "\\" + lvExplorer.SelectedItems[0].Text;
            Process.Start(currentPath);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new StringCollection();
            foreach (ListViewItem item in lvExplorer.SelectedItems)
                list.Add(currentNode + "\\" + item.Text);
            Clipboard.SetFileDropList(list);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = Clipboard.GetFileDropList();
            if (list.Count > 0)
            {
                foreach (var path in list)
                {
                    if (path.Contains("."))
                    {
                        FileInfo file = new FileInfo(path);
                        lvExplorer.Items.Add(createNewListItem(file));
                        string fileName = Path.GetFileName(path);
                        File.Copy(path, Path.Combine(currentNode, fileName));
                    }
                    else
                    {
                        DirectoryInfo dir = new DirectoryInfo(path);
                        lvExplorer.Items.Add(createNewListItem(dir));
                        Directory.CreateDirectory(currentNode + "\\" + Path.GetFileName(path));
                        foreach (string dirPath in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
                            Directory.CreateDirectory(dirPath.Replace(path, currentNode + "\\" + Path.GetFileName(path)));
                        foreach (string newPath in Directory.GetFiles(path, "*.*", SearchOption.AllDirectories))
                            File.Copy(newPath, newPath.Replace(path, currentNode), true);
                    }
                }
                setStatusBar();
            }
        }
    }
}
