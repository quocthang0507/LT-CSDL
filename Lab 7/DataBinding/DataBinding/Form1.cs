using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBinding();
        }

        void DataBinding()
        {
            List<SinhVien> listItems = new List<SinhVien>()
            {
                new SinhVien() {MSSV = "1610235", hoTen = "Nguyễn Hiếu Trung", diem = 10 },
                new SinhVien() {MSSV="1610229", hoTen = "Cao Quốc Bảo Toàn", diem = 5 },
                new SinhVien() {MSSV="1610207", hoTen = "La Quốc Thắng", diem = 8 },
                new SinhVien() {MSSV="1610211", hoTen = "Nguyễn Thành Quốc", diem = 3.9 },
                new SinhVien() {MSSV="1620255", hoTen = "Trần Trọng Hiệp", diem = 4.9 }
            };
            cbx_MSSV.DataSource = listItems;
            cbx_MSSV.DisplayMember = "MSSV";
            txtHoTen.DataBindings.Add("Text", cbx_MSSV.DataSource, "hoTen");
            txtDiem.DataBindings.Add("Text", cbx_MSSV.DataSource, "diem");
        }
    }

    public class SinhVien
    {
        public string MSSV { get; set; }
        public string hoTen { get; set; }
        public double diem { get; set; }
    }
}
