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
    public partial class uctBan : UserControl
    {
        public uctBan()
        {
            InitializeComponent();
        }

        private void uctBan_Load(object sender, EventArgs e)
        {
            LoadBan();
            dis_end(false);
            bingding();
        }
        public static uctBan uctB = new uctBan();
        //Khai báo biến để phân biệt thêm sửa xóa
        int flag = 0;
        void LoadBan()
        {
            //Trỏ đến data nhân viên
            dgvDSBan.DataSource = Models.BanModel.FillDataSetBan().Tables[0];
            dgvDSBan.BorderStyle = BorderStyle.Fixed3D;
            dgvDSBan.RowHeadersVisible = false;

        }
        //Combobox giới tính
        void loadControl()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Hoạt động");
            cboStatus.Items.Add("Ngừng hoạt động");
            //Gọi hàm GetTenKhuVuc trả về tên khu vực
            cboTenKhuVuc.DataSource = Models.KhuVucModel.getTenKhuVuc().Tables[0];
            cboTenKhuVuc.DisplayMember = "TenKhuVuc";
        }
        void bingding()
        {
            txtIDBan.DataBindings.Clear();
            txtIDBan.DataBindings.Add("Text", dgvDSBan.DataSource, "IdBan");
            cboTenKhuVuc.DataBindings.Clear();
            cboTenKhuVuc.DataBindings.Add("Text", dgvDSBan.DataSource, "TenKhuVuc");
            txtTenBan.DataBindings.Clear();
            txtTenBan.DataBindings.Add("Text", dgvDSBan.DataSource, "TenBan");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvDSBan.DataSource, "DienGiai");
            cboStatus.DataBindings.Clear();
            cboStatus.DataBindings.Add("Text", dgvDSBan.DataSource, "TrangThai");
        }
        //Clear các control
        void clearData()
        {
            txtIDBan.Text = Models.Connection.ExcuteScalar(string.Format("SELECT IdKhuVuc = dbo.fcgetIdBan()"));
            txtTenBan.Text = string.Empty;
            txtDienGiai.Text = string.Empty;
            loadControl(); // goi lại combobox Trạng thái
        }
        //Hàm set các button khi load lên ...
        void dis_end(bool e)
        {
            ///txtIDKhuVuc.Enabled = e;
            cboTenKhuVuc.Enabled = e;
            txtTenBan.Enabled = e;
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
            string _IDBan = string.Empty;
            try
            {
                _IDBan = txtIDBan.Text;
            }
            catch (Exception ex)
            {

            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.BanController.DeleteBan(_IDBan);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadBan();
                    uctBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctBan_Load(sender, e);
            dis_end(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Khai báo các biến _CodeNV, _SurnameNV, _NameNV, _DateOfBirthNV, _SexNV, _PhoneNV, _EmailNV, _AddressNV
            string _IDBan = string.Empty;
            try
            {
                _IDBan = txtIDBan.Text;
            }
            catch (Exception ex)
            {

            }
            string _TenKhuVuc = string.Empty;
            try
            {
                _TenKhuVuc = cboTenKhuVuc.Text;
            }
            catch (Exception ex)
            {

            }
            string _TenBan = string.Empty;
            try
            {
                _TenBan = txtTenBan.Text;
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
                if (_IDBan == String.Empty || _TenKhuVuc == string.Empty || _TenBan == string.Empty || _DienGiai == string.Empty || _TrangThai == string.Empty) MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.BanController.InsertBan(_IDBan, _TenKhuVuc, _TenBan, _DienGiai, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm Thành công!");
                        LoadBan();
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
                i = Controllers.BanController.UpdateBan(_IDBan, _TenKhuVuc, _TenBan, _DienGiai, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa Thành công!");
                    LoadBan();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            uctBan_Load(sender, e);
        }
    }
}
