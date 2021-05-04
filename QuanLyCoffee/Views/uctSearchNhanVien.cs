using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffee.Views
{
    public partial class uctSearchNhanVien : UserControl
    {
        public uctSearchNhanVien()
        {
            InitializeComponent();
        }
        void LoadControl()
        {
            cboFind.Items.Clear();
            cboFind.Items.Add("ID Nhân viên");
            cboFind.Items.Add("Tên Nhân viên");
        }

        private void uctSearchNhanVien_Load(object sender, EventArgs e)
        {
            cboFind.Text = "ID Nhân viên";
            LoadControl();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string strFind = txtFind.Text;
            if (txtFind.Text == string.Empty)
            {
                DataTable dt = new DataTable();
                dt = Models.NhanVienModel.FillDataSetNhanVien().Tables[0];
                dgvDSNhanVien.DataSource = dt;
            }
            else
            {
                if (cboFind.Text == "ID Nhân viên")
                {
                    //string CodeNV = txtFind.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienController.FillDataSet_SearchNhanVienByIDNhanVien(strFind).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDSNhanVien.DataSource = dt;
                    }
                    else MessageBox.Show("ID Nhân viên " + txtFind.Text + " không có trong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //string NameNV = txtFind.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienController.FillDataSet_SearchNhanVienByTenNhanVien(strFind).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDSNhanVien.DataSource = dt;
                    }
                    else MessageBox.Show("Tên Nhân viên " + txtFind.Text + " không có trong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string strFind = txtFind.Text;
            if (cboFind.Text == "ID Nhân viên")
            {
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienController.FillDataSet_SearchNhanVienByIDNhanVien(strFind).Tables[0];
                dgvDSNhanVien.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienController.FillDataSet_SearchNhanVienByIDNhanVien(strFind).Tables[0];
                dgvDSNhanVien.DataSource = dt;
            }
        }
    }
}
