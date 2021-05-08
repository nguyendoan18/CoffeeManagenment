using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCoffee.Models
{
    class BanModel
    {
        #region Khai báo biến
        protected string IDBan { get; set; }
        protected string TenKhuVuc { get; set; }
        protected string TenBan { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        #endregion
        #region Khởi tạo Contructor
        public BanModel(string _IDBan)
        {
            IDBan = _IDBan;
        }
        public BanModel() { }
        public BanModel(string _IDBan, string _TenKhuVuc, string _TenBan, string _DienGiai, string _TrangThai)
        {
            IDBan = _IDBan;
            TenKhuVuc = _TenKhuVuc;
            TenBan = _TenBan;
            DienGiai = _DienGiai;
            TrangThai = _TrangThai;
        }
        #endregion

        #region Insert
        public int InsertBan()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[5] { "@IdBan", "@TenKhuVuc", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[5] { IDBan, TenKhuVuc, TenBan, DienGiai, TrangThai };
            i = Models.Connection.Excute_Sql("spInsertBan", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion
        #region Update
        public int UpdateBan()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[5] { "@IdBan", "@TenKhuVuc", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[5] { IDBan, TenKhuVuc, TenBan, DienGiai, TrangThai };
            i = Models.Connection.Excute_Sql("spUpdateBan", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Delete
        public int DeketeBan()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdBan" };
            object[] values = new object[1] { IDBan };
            i = Models.Connection.Excute_Sql("spDeleteBan", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Hàm lấy tất cả nhân viên
        public static DataSet FillDataSetBan()
        {
            //Thủ tục get nhân viên đã tạo ra bên class connection
            return Models.Connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }
        #endregion

        public DataSet FillDataSet_GetBanByIDBan()
        {
            DataSet ds = new DataSet();
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdBan" };
            object[] values = new object[1] { IDBan };
            ds = Models.Connection.FillDataSet("spgetBanByIdBan", CommandType.StoredProcedure, parameters, values);
            return ds;
        }
    }
}
