using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCoffee.Models
{
    class KhuVucModel
    {
        #region Khai báo biến
        protected string IDKhuVuc { get; set; }
        protected string TenKhuVuc { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        #endregion
        #region Khởi tạo Contructor
        public KhuVucModel(string _IDKhuVuc)
        {
            IDKhuVuc = _IDKhuVuc;
        }
        public KhuVucModel() { }
        public KhuVucModel(string _IDKhuVuc, string _TenKhuVuc, string _DienGiai, string _TrangThai)
        {
            IDKhuVuc = _IDKhuVuc;
            TenKhuVuc = _TenKhuVuc;
            DienGiai = _DienGiai;
            TrangThai = _TrangThai;
        }
        #endregion

        #region Insert
        public int InsertKhuVuc()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[4] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai"};
            object[] values = new object[4] { IDKhuVuc, TenKhuVuc, DienGiai, TrangThai};
            i = Models.Connection.Excute_Sql("spInsertKhuVuc", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion
        #region Update
        public int UpdateKhucVuc()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[4] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IDKhuVuc, TenKhuVuc, DienGiai, TrangThai };
            i = Models.Connection.Excute_Sql("spUpdateKhuVuc", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Delete
        public int DeketeKhucVuc()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdKhuVuc" };
            object[] values = new object[1] { IDKhuVuc };
            i = Models.Connection.Excute_Sql("spDeleteKhuVuc", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Hàm lấy tất cả nhân viên
        public static DataSet FillDataSetKhuVuc()
        {
            //Thủ tục get nhân viên đã tạo ra bên class connection
            return Models.Connection.FillDataSet("spgetKhuVuc", CommandType.StoredProcedure);
        }
        #endregion

        public DataSet FillDataSet_GetKhuVucByIDKhuVuc()
        {
            DataSet ds = new DataSet();
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdKhuVuc" };
            object[] values = new object[1] { IDKhuVuc };
            ds = Models.Connection.FillDataSet("spgetKhuVucByIdKhuVuc", CommandType.StoredProcedure, parameters, values);
            return ds;
        }
    }
}
