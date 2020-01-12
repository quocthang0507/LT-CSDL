using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HienThiAnh
{
    public partial class Form1 : Form
    {
        List<string> listDiaDanh;

        public Form1()
        {
            InitializeComponent();
            LoadListPlaces();
        }

        void LoadListPlaces()
        {
            listDiaDanh = new List<string>() { "Bình Thuận", "Cao Bằng", "Cần Thơ", "Đà Nẵng", "Đắc Nông", "Đồng Nai", "Hà Giang", "Hà Nội", "Huế", "Lạng Sơn", "Lào Cai", "Lâm Đồng", "Nam Định", "Quảng Nam", "Quảng Ninh", "Sài Gòn" };
            cbxDiaDanh.DataSource = listDiaDanh;
        }

        void ImageBinding()
        {
            string pic = cbxDiaDanh.SelectedValue.ToString().Replace(' ', '_');
            pbxHinhAnh.Image = HienThiAnh.Properties.Resources.ResourceManager.GetObject(pic) as Image;
        }

        private void cbxDiaDanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageBinding();
        }
    }
}
