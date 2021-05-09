using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCoffee.Models
{
    class ThucDonModel
    {
        #region Khai báo biến
        protected string IDThucDon { get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected float DonViTinh { get; set; }
        protected float SoLuongTon { get; set; }
        protected float DonGiaTon { get; set; }
        protected float TonToiThieu { get; set; }
        protected string TrangThai { get; set; }
        #endregion
        #region Khởi tạo Contructor
        public ThucDonModel(string _IDThucDon)
        {
            IDThucDon = _IDThucDon;
        }
        public ThucDonModel() { }
        public ThucDonModel(string _IDThucDon, string _TenLoaiThucDon, string _TenThucDon, float _DonViTinh, float _SoLuongTon, float _DonGiaTon, float _TonToiThieu, string _TrangThai)
        {
            IDThucDon = _IDThucDon;
            TenLoaiThucDon = _TenLoaiThucDon;
            TenThucDon = _TenThucDon;
            DonViTinh = _DonViTinh;
            SoLuongTon = _SoLuongTon;
            DonGiaTon = _DonGiaTon;
            TonToiThieu = _TonToiThieu;
            TrangThai = _TrangThai;
        }
        #endregion

        #region Insert
        public int InsertThucDon()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[8] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TonToiThieu", "@TrangThai" };
            object[] values = new object[8] { IDThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TonToiThieu, TrangThai };
            i = Models.Connection.Excute_Sql("spInsertThucDon", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion
        #region Update
        public int UpdateThucDon()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[8] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TonToiThieu", "@TrangThai" };
            object[] values = new object[8] { IDThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TonToiThieu, TrangThai };
            i = Models.Connection.Excute_Sql("spUpdateThucDon", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Delete
        public int DeleteThucDon()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IDThucDon };
            i = Models.Connection.Excute_Sql("spDeleteThucDon", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Hàm lấy tất cả nhân viên
        public static DataSet FillDataSetThucDon()
        {
            //Thủ tục get nhân viên đã tạo ra bên class connection
            return Models.Connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
        }
        #endregion
        public DataSet FillDataSet_GetThucDonByIDThucDon()
        {
            DataSet ds = new DataSet();
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IDThucDon };
            ds = Models.Connection.FillDataSet("spgetThucDonByIdThucDon", CommandType.StoredProcedure, parameters, values);
            return ds;
        }
    }
}
