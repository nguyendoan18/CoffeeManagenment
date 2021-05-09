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
    public partial class uctLoaiThucDon : UserControl
    {
        public uctLoaiThucDon()
        {
            InitializeComponent();
        }

        private void uctLoaiThucDon_Load(object sender, EventArgs e)
        {
            LoadLoaiThucDon();
            dis_end(false);
            bingding();
        }
        public static uctLoaiThucDon uctLTD = new uctLoaiThucDon();
        //Khai báo biến để phân biệt thêm sửa xóa
        int flag = 0;
        void LoadLoaiThucDon()
        {
            //Trỏ đến data nhân viên
            dgvDSLoaiThucDon.DataSource = Models.LoaiThucDonModel.FillDataSetLoaiThucDon().Tables[0];
            dgvDSLoaiThucDon.BorderStyle = BorderStyle.Fixed3D;
            dgvDSLoaiThucDon.RowHeadersVisible = false;
        }
        //Combobox giới tính
        void loadControl()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Hoạt động");
            cboStatus.Items.Add("Ngừng hoạt động");
        }
        void bingding()
        {
            txtIDLoaiThucDon.DataBindings.Clear();
            txtIDLoaiThucDon.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "IdLoaiThucDon");
            txtTenLoaiThucDon.DataBindings.Clear();
            txtTenLoaiThucDon.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "TenLoaiThucDon");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "DienGiai");
            cboStatus.DataBindings.Clear();
            cboStatus.DataBindings.Add("Text", dgvDSLoaiThucDon.DataSource, "TrangThai");
        }
        //Clear các control
        void clearData()
        {
            txtIDLoaiThucDon.Text = Models.Connection.ExcuteScalar(string.Format("SELECT IdLoaiThucDon = dbo.fcgetIdLoaiThucDon()"));
            txtTenLoaiThucDon.Text = string.Empty;
            txtDienGiai.Text = string.Empty;
            loadControl(); // goi lại combobox Trạng thái
        }
        //Hàm set các button khi load lên ...
        void dis_end(bool e)
        {
            ///txtIDKhuVuc.Enabled = e;
            txtTenLoaiThucDon.Enabled = e;
            txtDienGiai.Enabled = e;
            cboStatus.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Lúc sửa ta sẽ mặt định cho flag = 1
            flag = 1;
            dis_end(true);
            loadControl();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _IDLoaiThucDon = string.Empty;
            try
            {
                _IDLoaiThucDon = txtIDLoaiThucDon.Text;
            }
            catch (Exception ex)
            {

            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.LoaiThucDonController.DeleteLoaiThucDon(_IDLoaiThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadLoaiThucDon();
                    uctLoaiThucDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Khai báo các biến _CodeNV, _SurnameNV, _NameNV, _DateOfBirthNV, _SexNV, _PhoneNV, _EmailNV, _AddressNV
            string _IDLoaiThucDon = string.Empty;
            try
            {
                _IDLoaiThucDon = txtIDLoaiThucDon.Text;
            }
            catch (Exception ex)
            {

            }
            string _TenLoaiThucDon = string.Empty;
            try
            {
                _TenLoaiThucDon = txtTenLoaiThucDon.Text;
            }
            catch (Exception ex)
            {

            }
            string _DienGiai = string.Empty;
            try
            {
                _DienGiai = txtDienGiai.Text;
            }
            catch (Exception ex)
            {

            }
            string _TrangThai = string.Empty;
            try
            {
                _TrangThai = cboStatus.Text;
            }
            catch (Exception ex)
            {

            }

            if (flag == 0)
            {
                //Thêm mới
                if (_IDLoaiThucDon == String.Empty || _TenLoaiThucDon == string.Empty || _TrangThai == string.Empty) MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.LoaiThucDonController.InsertLoaiThucDon(_IDLoaiThucDon, _TenLoaiThucDon, _DienGiai, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm Thành công!");
                        LoadLoaiThucDon();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
            }
            else
            {
                int i = 0;
                i = Controllers.LoaiThucDonController.UpdateLoaiThucDon(_IDLoaiThucDon, _TenLoaiThucDon, _DienGiai, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa Thành công!");
                    LoadLoaiThucDon();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            uctLoaiThucDon_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctLoaiThucDon_Load(sender, e);
            dis_end(false);
        }
    }
}
