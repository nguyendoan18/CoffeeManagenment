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
    public partial class uctThucDon : UserControl
    {
        public uctThucDon()
        {
            InitializeComponent();
        }

        private void uctThucDon_Load(object sender, EventArgs e)
        {
            LoadThucDon();
            dis_end(false);
            bingding();
        }
        public static uctThucDon uctTD = new uctThucDon();
        //Khai báo biến để phân biệt thêm sửa xóa
        int flag = 0;
        void LoadThucDon()
        {
            //Trỏ đến data nhân viên
            dgvDSThucDon.DataSource = Models.ThucDonModel.FillDataSetThucDon().Tables[0];
            dgvDSThucDon.BorderStyle = BorderStyle.Fixed3D;
            dgvDSThucDon.RowHeadersVisible = false;
        }
        //Combobox giới tính
        void loadControl()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Hoạt động");
            cboStatus.Items.Add("Ngừng hoạt động");

            cboLoaiThucDon.DataSource = Models.LoaiThucDonModel.getTenLoaiThucDon().Tables[0];
            cboLoaiThucDon.DisplayMember = "TenLoaiThucDon";
        }
        void bingding()
        {
            txtIDThucDon.DataBindings.Clear();
            txtIDThucDon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "IdThucDon");
            cboLoaiThucDon.DataBindings.Clear();
            cboLoaiThucDon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TenLoaiThucDon");
            txtTenThucDon.DataBindings.Clear();
            txtTenThucDon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TenThucDon");
            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", dgvDSThucDon.DataSource, "DonViTinh");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDSThucDon.DataSource, "SoLuongTon");
            txtDonGiaTon.DataBindings.Clear();
            txtDonGiaTon.DataBindings.Add("Text", dgvDSThucDon.DataSource, "DonGiaTon");
            txtTonToiThieu.DataBindings.Clear();
            txtTonToiThieu.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TonToiThieu");
            cboStatus.DataBindings.Clear();
            cboStatus.DataBindings.Add("Text", dgvDSThucDon.DataSource, "TrangThai");
        }
        //Clear các control
        void clearData()
        {
            txtIDThucDon.Text = Models.Connection.ExcuteScalar(string.Format("SELECT IdThucDon = dbo.fcgetIdThucDon()"));
            txtTenThucDon.Text = string.Empty;
            txtDonViTinh.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonGiaTon.Text = string.Empty;
            txtTonToiThieu.Text = string.Empty;
            loadControl(); // goi lại combobox Trạng thái
        }
        //Hàm set các button khi load lên ...
        void dis_end(bool e)
        {
            ///txtIDKhuVuc.Enabled = e;
            txtTenThucDon.Enabled = e;
            txtTenThucDon.Enabled = e;
            txtDonViTinh.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGiaTon.Enabled = e;
            txtTonToiThieu.Enabled = e;
            cboStatus.Enabled = e;
            cboLoaiThucDon.Enabled = e;
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
            string _IDThucDon = string.Empty;
            try
            {
                _IDThucDon = txtIDThucDon.Text;
            }
            catch (Exception ex)
            {

            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.ThucDonController.DeleteThucDon(_IDThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadThucDon();
                    uctThucDon_Load(sender, e);
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
            string _IDThucDon = string.Empty;
            try
            {
                _IDThucDon = txtIDThucDon.Text;
            }
            catch (Exception ex)
            {

            }
            string _TenLoaiThucDon = string.Empty;
            try
            {
                _TenLoaiThucDon = cboLoaiThucDon.Text;
            }
            catch (Exception ex)
            {

            }
            string _TenThucDon = string.Empty;
            try
            {
                _TenThucDon = txtTenThucDon.Text;
            }
            catch (Exception ex)
            {

            }
            float _DonViTinh = 0;
            try
            {
                _DonViTinh = Convert.ToInt32(txtDonViTinh.Text);
            }
            catch (Exception ex)
            {

            }
            float _SoLuong = 0;
            try
            {
                _SoLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch (Exception ex)
            {

            }
            float _DonGiaTon = 0;
            try
            {
                _DonGiaTon = Convert.ToInt32(txtDonGiaTon.Text);
            }
            catch (Exception ex)
            {

            }
            float _TonToiThieu = 0;
            try
            {
                _TonToiThieu = Convert.ToInt32(txtTonToiThieu.Text);
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
                if (_IDThucDon == String.Empty || _TenLoaiThucDon == string.Empty || _TenThucDon == string.Empty || _DonViTinh == 0 || _SoLuong == 0 || _DonGiaTon == 0 || _TonToiThieu == 0 || _TrangThai == string.Empty) MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.ThucDonController.InsertThucDon(_IDThucDon, _TenLoaiThucDon, _TenThucDon, _DonViTinh, _SoLuong, _DonGiaTon, _TonToiThieu, _TrangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm Thành công!");
                        LoadThucDon();
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
                i = Controllers.ThucDonController.UpdateThucDon(_IDThucDon, _TenLoaiThucDon, _TenThucDon, _DonViTinh, _SoLuong, _DonGiaTon, _TonToiThieu, _TrangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa Thành công!");
                    LoadThucDon();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            uctThucDon_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctThucDon_Load(sender, e);
            dis_end(false);
        }
    }
}
