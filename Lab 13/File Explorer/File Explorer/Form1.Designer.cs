namespace File_Explorer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.tvExplorer = new System.Windows.Forms.TreeView();
			this.smallImageList = new System.Windows.Forms.ImageList(this.components);
			this.lvExplorer = new System.Windows.Forms.ListView();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colModify = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.smallIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.largeIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.details = new System.Windows.Forms.ToolStripMenuItem();
			this.list = new System.Windows.Forms.ToolStripMenuItem();
			this.tile = new System.Windows.Forms.ToolStripMenuItem();
			this.largeImageList = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 24);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.tvExplorer);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.lvExplorer);
			this.splitContainer.Size = new System.Drawing.Size(500, 336);
			this.splitContainer.SplitterDistance = 150;
			this.splitContainer.TabIndex = 0;
			// 
			// tvExplorer
			// 
			this.tvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvExplorer.ImageIndex = 0;
			this.tvExplorer.ImageList = this.smallImageList;
			this.tvExplorer.Location = new System.Drawing.Point(0, 0);
			this.tvExplorer.Name = "tvExplorer";
			this.tvExplorer.SelectedImageIndex = 0;
			this.tvExplorer.Size = new System.Drawing.Size(150, 336);
			this.tvExplorer.TabIndex = 0;
			this.tvExplorer.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvExplorer_AfterCollapse);
			this.tvExplorer.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvExplorer_AfterExpand);
			this.tvExplorer.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvExplorer_NodeMouseClick);
			// 
			// smallImageList
			// 
			this.smallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.smallImageList.ImageSize = new System.Drawing.Size(20, 20);
			this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lvExplorer
			// 
			this.lvExplorer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colModify});
			this.lvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvExplorer.GridLines = true;
			this.lvExplorer.HideSelection = false;
			this.lvExplorer.Location = new System.Drawing.Point(0, 0);
			this.lvExplorer.MultiSelect = false;
			this.lvExplorer.Name = "lvExplorer";
			this.lvExplorer.Size = new System.Drawing.Size(346, 336);
			this.lvExplorer.TabIndex = 0;
			this.lvExplorer.UseCompatibleStateImageBehavior = false;
			this.lvExplorer.View = System.Windows.Forms.View.Details;
			this.lvExplorer.SelectedIndexChanged += new System.EventHandler(this.lvExplorer_SelectedIndexChanged);
			// 
			// colName
			// 
			this.colName.Text = "Name";
			// 
			// colType
			// 
			this.colType.Text = "Type";
			// 
			// colModify
			// 
			this.colModify.Text = "Last Modified";
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(500, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallIcon,
            this.largeIcon,
            this.details,
            this.list,
            this.tile});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			this.viewToolStripMenuItem.DropDownClosed += new System.EventHandler(this.viewToolStripMenuItem_DropDownClosed);
			this.viewToolStripMenuItem.MouseLeave += new System.EventHandler(this.viewToolStripMenuItem_MouseLeave);
			// 
			// smallIcon
			// 
			this.smallIcon.Name = "smallIcon";
			this.smallIcon.Size = new System.Drawing.Size(152, 22);
			this.smallIcon.Text = "Small Icon";
			// 
			// largeIcon
			// 
			this.largeIcon.Name = "largeIcon";
			this.largeIcon.Size = new System.Drawing.Size(129, 22);
			this.largeIcon.Text = "Large Icon";
			this.largeIcon.Click += new System.EventHandler(this.largeIcon_Click);
			// 
			// details
			// 
			this.details.Name = "details";
			this.details.Size = new System.Drawing.Size(129, 22);
			this.details.Text = "Details";
			this.details.Click += new System.EventHandler(this.details_Click);
			// 
			// list
			// 
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(129, 22);
			this.list.Text = "List";
			this.list.Click += new System.EventHandler(this.list_Click);
			// 
			// tile
			// 
			this.tile.Name = "tile";
			this.tile.Size = new System.Drawing.Size(129, 22);
			this.tile.Text = "Tile";
			this.tile.Click += new System.EventHandler(this.tile_Click);
			// 
			// largeImageList
			// 
			this.largeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.largeImageList.ImageSize = new System.Drawing.Size(16, 16);
			this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 360);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Form1";
			this.Text = "File Explorer (D:\\) - La Quốc Thắng ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView tvExplorer;
        private System.Windows.Forms.ListView lvExplorer;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colModify;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smallIcon;
		private System.Windows.Forms.ToolStripMenuItem largeIcon;
		private System.Windows.Forms.ToolStripMenuItem details;
		private System.Windows.Forms.ToolStripMenuItem list;
		private System.Windows.Forms.ToolStripMenuItem tile;
		private System.Windows.Forms.ImageList largeImageList;
	}
}

