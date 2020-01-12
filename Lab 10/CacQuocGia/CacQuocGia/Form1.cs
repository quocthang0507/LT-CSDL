using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacQuocGia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLargeIcon_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = false;
            listView1.View = View.LargeIcon;
        }

        private void lblSmallIcon_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = false;
            listView1.View = View.SmallIcon;
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
        }

        private void lblList_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = false;
            listView1.View = View.List;
        }

        private void lblTile_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.FullRowSelect = false;
            listView1.View = View.Tile;
        }
    }
}
