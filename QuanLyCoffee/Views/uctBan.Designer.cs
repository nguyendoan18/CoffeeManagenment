
namespace QuanLyCoffee.Views
{
    partial class uctBan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDSBan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTenKhuVuc = new System.Windows.Forms.ComboBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.IdBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "DANH SÁCH BÀN";
            // 
            // dgvDSBan
            // 
            this.dgvDSBan.AllowUserToAddRows = false;
            this.dgvDSBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDSBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBan,
            this.TenKhuVuc,
            this.TenBan,
            this.DienGiai,
            this.TrangThai});
            this.dgvDSBan.Location = new System.Drawing.Point(33, 36);
            this.dgvDSBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSBan.Name = "dgvDSBan";
            this.dgvDSBan.Size = new System.Drawing.Size(602, 276);
            this.dgvDSBan.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(776, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "THÔNG TIN BÀN";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(933, 242);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(826, 242);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1002, 206);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(884, 206);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(776, 206);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTenKhuVuc
            // 
            this.cboTenKhuVuc.FormattingEnabled = true;
            this.cboTenKhuVuc.Location = new System.Drawing.Point(746, 65);
            this.cboTenKhuVuc.Margin = new System.Windows.Forms.Padding(4);
            this.cboTenKhuVuc.Name = "cboTenKhuVuc";
            this.cboTenKhuVuc.Size = new System.Drawing.Size(374, 24);
            this.cboTenKhuVuc.TabIndex = 36;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(746, 98);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(374, 22);
            this.txtTenBan.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(645, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Tên bàn";
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(746, 130);
            this.txtDienGiai.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(374, 22);
            this.txtDienGiai.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Điển giải";
            // 
            // txtIDBan
            // 
            this.txtIDBan.Enabled = false;
            this.txtIDBan.Location = new System.Drawing.Point(746, 33);
            this.txtIDBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.Size = new System.Drawing.Size(374, 22);
            this.txtIDBan.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(645, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "ID Bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tên khu vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Trạng thái";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(746, 162);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(374, 24);
            this.cboStatus.TabIndex = 61;
            // 
            // IdBan
            // 
            this.IdBan.DataPropertyName = "IdBan";
            this.IdBan.HeaderText = "ID Bàn";
            this.IdBan.Name = "IdBan";
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.TenKhuVuc.HeaderText = "Tên khu vực";
            this.TenKhuVuc.Name = "TenKhuVuc";
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.Name = "TenBan";
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "Diễn giải";
            this.DienGiai.Name = "DienGiai";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // uctBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDienGiai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTenKhuVuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDSBan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctBan";
            this.Size = new System.Drawing.Size(1149, 382);
            this.Load += new System.EventHandler(this.uctBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDSBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboTenKhuVuc;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
