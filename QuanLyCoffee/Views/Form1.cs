using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffee
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Thêm một tab pages phía dưới
        /// </summary>
        internal static List<byte> typePages = new List<byte>();
        public void AddTabPage(UserControl uct, byte typeControl, string NameTab)
        {
            #region Kiểm tra tồn tại trang này chưa?
            for (int i = 0; i < tabHienThi.TabPages.Count; i++)
            {
                if (tabHienThi.TabPages[i].Contains(uct) == true)
                {
                    tabHienThi.SelectedTab = tabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = NameTab;
            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
            #endregion
        }
        /// <summary>
        /// Đóng tab Hiện tại
        /// </summary>
        public void CloseTabPresent()
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTab);
        }
        /// <summary>
        /// Đóng tât cả tab
        /// </summary>
        public void CloseAllTab()
        {
            while (tabHienThi.TabPages.Count > 0)
            {
                CloseTabPresent();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) Application.Exit();
            else return;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTabPage(Views.uctNhanVien.uctNV, 4, "Quản lý nhân viên");
        }

        private void đóngTabHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseTabPresent();
        }

        private void đóngTấtCảTavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTab();
        }

        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTabPage(Views.uctKhuVuc.uctKV, 4, "Hệ thống khu vực");
        }

        private void bànKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTabPage(Views.uctBan.uctB, 4, "Bàn khu vực");
        }

        private void loạiThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTabPage(Views.uctLoaiThucDon.uctLTD, 4, "Loại thực đơn");
        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTabPage(Views.uctThucDon.uctTD, 4, "Thực đơn");
        }
    }
}
