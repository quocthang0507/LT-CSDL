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
			this.lblTile = new System.Windows.Forms.Label();
			this.lblList = new System.Windows.Forms.Label();
			this.lblDetails = new System.Windows.Forms.Label();
			this.lblSmallIcon = new System.Windows.Forms.Label();
			this.lblLargeIcon = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTile
			// 
			this.lblTile.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTile.AutoSize = true;
			this.lblTile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lblTile.Location = new System.Drawing.Point(489, 9);
			this.lblTile.Name = "lblTile";
			this.lblTile.Size = new System.Drawing.Size(31, 17);
			this.lblTile.TabIndex = 9;
			this.lblTile.Text = "Tile";
			this.lblTile.Click += new System.EventHandler(this.lblTile_Click);
			// 
			// lblList
			// 
			this.lblList.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblList.AutoSize = true;
			this.lblList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lblList.Location = new System.Drawing.Point(402, 9);
			this.lblList.Name = "lblList";
			this.lblList.Size = new System.Drawing.Size(30, 17);
			this.lblList.TabIndex = 8;
			this.lblList.Text = "List";
			this.lblList.Click += new System.EventHandler(this.lblList_Click);
			// 
			// lblDetails
			// 
			this.lblDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblDetails.AutoSize = true;
			this.lblDetails.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lblDetails.Location = new System.Drawing.Point(291, 9);
			this.lblDetails.Name = "lblDetails";
			this.lblDetails.Size = new System.Drawing.Size(51, 17);
			this.lblDetails.TabIndex = 7;
			this.lblDetails.Text = "Details";
			this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
			// 
			// lblSmallIcon
			// 
			this.lblSmallIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblSmallIcon.AutoSize = true;
			this.lblSmallIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lblSmallIcon.Location = new System.Drawing.Point(170, 9);
			this.lblSmallIcon.Name = "lblSmallIcon";
			this.lblSmallIcon.Size = new System.Drawing.Size(72, 17);
			this.lblSmallIcon.TabIndex = 6;
			this.lblSmallIcon.Text = "Small Icon";
			this.lblSmallIcon.Click += new System.EventHandler(this.lblSmallIcon_Click);
			// 
			// lblLargeIcon
			// 
			this.lblLargeIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblLargeIcon.AutoSize = true;
			this.lblLargeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lblLargeIcon.Location = new System.Drawing.Point(47, 9);
			this.lblLargeIcon.Name = "lblLargeIcon";
			this.lblLargeIcon.Size = new System.Drawing.Size(75, 17);
			this.lblLargeIcon.TabIndex = 5;
			this.lblLargeIcon.Text = "Large Icon";
			this.lblLargeIcon.Click += new System.EventHandler(this.lblLargeIcon_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 405);
			this.Controls.Add(this.lblTile);
			this.Controls.Add(this.lblList);
			this.Controls.Add(this.lblDetails);
			this.Controls.Add(this.lblSmallIcon);
			this.Controls.Add(this.lblLargeIcon);
			this.Name = "Form1";
			this.Text = "Các quốc gia - La Quốc Thắng";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblSmallIcon;
        private System.Windows.Forms.Label lblLargeIcon;
    }
}

