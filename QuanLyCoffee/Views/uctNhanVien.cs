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
    public partial class uctNhanVien : UserControl
    {
        public uctNhanVien()
        {
            InitializeComponent();
        }
        public static uctNhanVien uctNV = new uctNhanVien();
        //Khai báo biến để phân biệt thêm sửa xóa
        int flag = 0;
        void LoadNhanVien()
        {
            //Trỏ đến data nhân viên
            dgvDSNhanVien.DataSource = Models.NhanVienModel.FillDataSetNhanVien().Tables[0];
            dgvDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dgvDSNhanVien.Dock = DockStyle.Fill;
            dgvDSNhanVien.RowHeadersVisible = false;
        }

        private void uctNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            dis_end(false);
            bingding();
        }
        void bingding()
        {
            txtCodeNV.DataBindings.Clear();
            txtCodeNV.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "IdNhanVien");
            txtSurname.DataBindings.Clear();
            txtSurname.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "HoLot");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Ten");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Ngaysinh");
            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "GioiTinh");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Email");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "DiaChi");
        }
        //Hàm set các button khi load lên ...
        void dis_end(bool e)
        {
            txtSurname.Enabled = e;
            txtName.Enabled = e;
            dtpNgaySinh.Enabled = e;
            cbbGioiTinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtDienThoai.Enabled = e;
            txtEmail.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        void nhung(Control ctr)
        {
            pnIDDSNhanVien.Controls.Clear();
            pnIDDSNhanVien.BorderStyle = BorderStyle.None;
            ctr.Dock = DockStyle.Fill;
            pnIDDSNhanVien.Controls.Add(ctr);
            pnIDDSNhanVien.Show();
        }
        //Combobox giới tính
        void loadControl()
        {
            cbbGioiTinh.Items.Clear();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.Items.Add("Khác");
        }
        //Clear các control
        void clearData()
        {
            txtCodeNV.Text = Models.Connection.ExcuteScalar(string.Format("SELECT IdNhanVien = dbo.fcgetIdNhanVien()"));
            txtSurname.Text = string.Empty;
            txtName.Text = string.Empty;
            dtpNgaySinh.Text = string.Empty;
            loadControl(); // goi lại combobox giới tính
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            //Lúc sửa ta sẽ mặt định cho flag = 1
            flag = 1;
            dis_end(true);
            loadControl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctNhanVien_Load(sender, e);
            dis_end(false);
            bingding();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Khai báo các biến _CodeNV, _SurnameNV, _NameNV, _DateOfBirthNV, _SexNV, _PhoneNV, _EmailNV, _AddressNV
            string _CodeNV = string.Empty;
            try
            {
                _CodeNV = txtCodeNV.Text;
            }
            catch (Exception ex)
            {

            }
            string _SurnameNV = string.Empty;
            try
            {
                _SurnameNV = txtSurname.Text;
            }
            catch (Exception ex)
            {

            }
            string _NameNV = string.Empty;
            try
            {
                _NameNV = txtName.Text;
            }
            catch (Exception ex)
            {

            }
            DateTime _DateOfBirthNV = dtpNgaySinh.Value;
            string _SexNV = string.Empty;
            try
            {
                _SexNV = cbbGioiTinh.Text;
            }
            catch (Exception ex)
            {

            }
            string _PhoneNV = string.Empty;
            try
            {
                _PhoneNV = txtDienThoai.Text;
            }
            catch (Exception ex)
            {

            }
            string _AddressNV = string.Empty;
            try
            {
                _AddressNV = txtDiaChi.Text;
            }
            catch (Exception ex)
            {

            }
            string _EmailNV = string.Empty;
            try
            {
                _EmailNV = txtEmail.Text;
            }
            catch (Exception ex)
            {

            }
            if (flag == 0)
            {
                //Thêm mới
                if (_CodeNV == String.Empty || _SurnameNV == string.Empty || _NameNV == string.Empty) MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.NhanVienController.InsertNhanVien(_CodeNV, _SurnameNV, _NameNV, _DateOfBirthNV, _SexNV, _PhoneNV, _EmailNV, _AddressNV);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm Thành công!");
                        LoadNhanVien();
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
                i = Controllers.NhanVienController.UpdateNhanVien(_CodeNV, _SurnameNV, _NameNV, _DateOfBirthNV, _SexNV, _PhoneNV, _EmailNV, _AddressNV);
                if (i > 0)
                {
                    MessageBox.Show("Sửa Thành công!");
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            uctNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _CodeNV = string.Empty;
            try
            {
                _CodeNV = txtCodeNV.Text;
            }
            catch (Exception)
            {

            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienController.DeleteNhanVien(_CodeNV);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadNhanVien();
                    uctNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien uctSearch = new uctSearchNhanVien();
            nhung(uctSearch);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnIDDSNhanVien.Controls.Clear();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
