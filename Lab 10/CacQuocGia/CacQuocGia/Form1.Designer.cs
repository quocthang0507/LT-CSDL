namespace CacQuocGia
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Australia",
            "Châu Úc",
            "Canberra"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sudan",
            "Châu Phi",
            "Khartoum"}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "UK",
            "Châu Âu",
            "London"}, 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "US",
            "Châu Mỹ",
            "Washington"}, 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Vietnam",
            "Châu Á",
            "Hà Nội"}, 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLargeIcon = new System.Windows.Forms.Label();
            this.lblSmallIcon = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblTile = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TenNuoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChauLuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThuDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeIcon = new System.Windows.Forms.ImageList(this.components);
            this.smallIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblLargeIcon
            // 
            this.lblLargeIcon.AutoSize = true;
            this.lblLargeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblLargeIcon.Location = new System.Drawing.Point(37, 9);
            this.lblLargeIcon.Name = "lblLargeIcon";
            this.lblLargeIcon.Size = new System.Drawing.Size(75, 17);
            this.lblLargeIcon.TabIndex = 0;
            this.lblLargeIcon.Text = "Large Icon";
            this.lblLargeIcon.Click += new System.EventHandler(this.lblLargeIcon_Click);
            // 
            // lblSmallIcon
            // 
            this.lblSmallIcon.AutoSize = true;
            this.lblSmallIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSmallIcon.Location = new System.Drawing.Point(160, 9);
            this.lblSmallIcon.Name = "lblSmallIcon";
            this.lblSmallIcon.Size = new System.Drawing.Size(72, 17);
            this.lblSmallIcon.TabIndex = 1;
            this.lblSmallIcon.Text = "Small Icon";
            this.lblSmallIcon.Click += new System.EventHandler(this.lblSmallIcon_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetails.Location = new System.Drawing.Point(281, 9);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(51, 17);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Details";
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblList.Location = new System.Drawing.Point(392, 9);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(30, 17);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "List";
            this.lblList.Click += new System.EventHandler(this.lblList_Click);
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTile.Location = new System.Drawing.Point(479, 9);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(31, 17);
            this.lblTile.TabIndex = 4;
            this.lblTile.Text = "Tile";
            this.lblTile.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenNuoc,
            this.ChauLuc,
            this.ThuDo});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.LargeImageList = this.largeIcon;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 352);
            this.listView1.SmallImageList = this.smallIcon;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TenNuoc
            // 
            this.TenNuoc.Text = "Tên nước";
            this.TenNuoc.Width = 148;
            // 
            // ChauLuc
            // 
            this.ChauLuc.Text = "Châu lục";
            this.ChauLuc.Width = 156;
            // 
            // ThuDo
            // 
            this.ThuDo.Text = "Thủ đô";
            this.ThuDo.Width = 210;
            // 
            // largeIcon
            // 
            this.largeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeIcon.ImageStream")));
            this.largeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.largeIcon.Images.SetKeyName(0, "Australia.png");
            this.largeIcon.Images.SetKeyName(1, "Sudan.png");
            this.largeIcon.Images.SetKeyName(2, "UK.png");
            this.largeIcon.Images.SetKeyName(3, "USA.png");
            this.largeIcon.Images.SetKeyName(4, "Vietnam.png");
            // 
            // smallIcon
            // 
            this.smallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallIcon.ImageStream")));
            this.smallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.smallIcon.Images.SetKeyName(0, "Australia.png");
            this.smallIcon.Images.SetKeyName(1, "Sudan.png");
            this.smallIcon.Images.SetKeyName(2, "UK.png");
            this.smallIcon.Images.SetKeyName(3, "USA.png");
            this.smallIcon.Images.SetKeyName(4, "Vietnam.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 405);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblSmallIcon);
            this.Controls.Add(this.lblLargeIcon);
            this.Name = "Form1";
            this.Text = "Các quốc gia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargeIcon;
        private System.Windows.Forms.Label lblSmallIcon;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TenNuoc;
        private System.Windows.Forms.ColumnHeader ChauLuc;
        private System.Windows.Forms.ColumnHeader ThuDo;
        private System.Windows.Forms.ImageList largeIcon;
        private System.Windows.Forms.ImageList smallIcon;
    }
}

