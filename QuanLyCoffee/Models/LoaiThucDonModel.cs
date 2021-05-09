using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyCoffee.Models
{
    class LoaiThucDonModel
    {
        #region Khai báo biến
        protected string IDLoaiThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        #endregion
        #region Khởi tạo Contructor
        public LoaiThucDonModel(string _IDLoaiThucDon)
        {
            IDLoaiThucDon = _IDLoaiThucDon;
        }
        public LoaiThucDonModel() { }
        public LoaiThucDonModel(string _IDLoaiThucDon, string _TenThucDon, string _DienGiai, string _TrangThai)
        {
            IDLoaiThucDon = _IDLoaiThucDon;
            TenThucDon = _TenThucDon;
            DienGiai = _DienGiai;
            TrangThai = _TrangThai;
        }
        #endregion

        #region Insert
        public int InsertLoaiThucDon()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IDLoaiThucDon, TenThucDon, DienGiai, TrangThai };
            i = Models.Connection.Excute_Sql("spInsertLoaiThucDon", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion
        #region Update
        public int UpdateLoaiThucDon()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IDLoaiThucDon, TenThucDon, DienGiai, TrangThai };
            i = Models.Connection.Excute_Sql("spUpdateLoaiThucDon", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Delete
        public int DeketeLoaiThucDon()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IDLoaiThucDon };
            i = Models.Connection.Excute_Sql("spDeleteLoaiThucDon", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Hàm lấy tất cả nhân viên
        public static DataSet FillDataSetLoaiThucDon()
        {
            //Thủ tục get nhân viên đã tạo ra bên class connection
            return Models.Connection.FillDataSet("spgetLoaiThucDon", CommandType.StoredProcedure);
        }
        #endregion
        #region Hàm lấy trả về tên khu vực
        public static DataSet getTenLoaiThucDon()
        {
            //Thủ tục get nhân viên đã tạo ra bên class connection
            return Models.Connection.FillDataSet("spgetTenLoaiThucDon", CommandType.StoredProcedure);
        }
        #endregion
        public DataSet FillDataSet_GetLoaiThucDonByIDLoaiThucDon()
        {
            DataSet ds = new DataSet();
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IDLoaiThucDon };
            ds = Models.Connection.FillDataSet("spgetLoaiThucDonByIdLoaiThucDon", CommandType.StoredProcedure, parameters, values);
            return ds;
        }
    }
}
