using _2180600531_PhamDangHuy.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2180600531_PhamDangHuy
{
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<SINHVIEN> listSV = context.SINHVIENs.ToList();
                List<LOP> listLop = context.LOPs.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtNgaysinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Lop(List<LOP> listLop)
        {
            this.cboLop.DataSource = listLop;
            this.cboLop.DisplayMember = "TenLop";
            this.cboLop.ValueMember = "MaLop";
        }
        private void HienThi(List<SINHVIEN> listSV)
        {
            lvSinhVien.Items.Clear();
            foreach(var item in listSV)
            {
                ListViewItem lv = new ListViewItem(item.MaSV);
                lv.SubItems.Add(item.HotenSV);
                lv.SubItems.Add(item.NgaySinh.ToString());
                lv.SubItems.Add(item.LOP.TenLop);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                string fullName = button7.Text.Trim();
                var query = context.SINHVIENs.AsQueryable();
                if (!string.IsNullOrEmpty(fullName))
                    query = query.Where(s => s.HotenSV.Contains(fullName));
                var results = query.ToList();
                HienThi(results);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
