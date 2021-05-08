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
    public partial class uctKhuVuc : UserControl
    {
        public uctKhuVuc()
        {
            InitializeComponent();
        }

        private void uctKhuVuc_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
            dis_end(false);
            bingding();
        }
        public static uctKhuVuc uctKV = new uctKhuVuc();
        //Khai báo biến để phân biệt thêm sửa xóa
        int flag = 0;
        void LoadKhuVuc()
        {
            //Trỏ đến data nhân viên
            dgvThongTinKhuVuc.DataSource = Models.KhuVucModel.FillDataSetKhuVuc().Tables[0];
            dgvThongTinKhuVuc.BorderStyle = BorderStyle.Fixed3D;
           dgvThongTinKhuVuc.RowHeadersVisible = false;
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
            txtIDKhuVuc.DataBindings.Clear();
            txtIDKhuVuc.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "IdKhuVuc");
            txtTenKhuVuc.DataBindings.Clear();
            txtTenKhuVuc.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "TenKhuVuc");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "DienGiai");
            cboStatus.DataBindings.Clear();
            cboStatus.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "TrangThai");
        }
        //Clear các control
        void clearData()
        {
            txtIDKhuVuc.Text = Models.Connection.ExcuteScalar(string.Format("SELECT IdKhuVuc = dbo.fcgetIdkhuVuc()"));
            txtTenKhuVuc.Text = string.Empty;
            txtDienGiai.Text = string.Empty;
            loadControl(); // goi lại combobox Trạng thái
        }
        //Hàm set các button khi load lên ...
        void dis_end(bool e)
        {
            ///txtIDKhuVuc.Enabled = e;
            txtTenKhuVuc.Enabled = e;
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
            string _IDKhuVuc = string.Empty;
            try
            {
                _IDKhuVuc = txtIDKhuVuc.Text;
            }
            catch (Exception ex)
            {

            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.KhuVucController.DeleteKhuVuc(_IDKhuVuc);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadKhuVuc();
                    uctKhuVuc_Load(sender, e);
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
            string _IDKhuVuc = string.Empty;
            try
            {
                _IDKhuVuc = txtIDKhuVuc.Text;
            }
            catch (Exception ex)
            {

            }
            string _TenKhuVuc = string.Empty;
            try
            {
                _TenKhuVuc = txtTenKhuVuc.Text;
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
                if (_IDKhuVuc == String.Empty || _TenKhuVuc == string.Empty || _DienGiai == string.Empty || _TrangThai == string.Empty) MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.KhuVucController.InsertKhuVuc(_IDKhuVuc, _TenKhuVuc, _DienGiai, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm Thành công!");
                        LoadKhuVuc();
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
                i = Controllers.KhuVucController.UpdateKhuVuc(_IDKhuVuc, _TenKhuVuc, _DienGiai, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa Thành công!");
                    LoadKhuVuc();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            uctKhuVuc_Load(sender, e);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctKhuVuc_Load(sender, e);
            dis_end(false);
        }
    }
}
