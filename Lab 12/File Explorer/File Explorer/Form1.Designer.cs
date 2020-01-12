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
			this.largeImageList = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.tvExplorer);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.lvExplorer);
			this.splitContainer.Size = new System.Drawing.Size(500, 360);
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
			this.tvExplorer.Size = new System.Drawing.Size(150, 360);
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
			this.lvExplorer.Size = new System.Drawing.Size(346, 360);
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
			this.Name = "Form1";
			this.Text = "File Explorer (D:\\) - La Quốc Thắng ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView tvExplorer;
        private System.Windows.Forms.ListView lvExplorer;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colModify;
		private System.Windows.Forms.ImageList largeImageList;
	}
}

