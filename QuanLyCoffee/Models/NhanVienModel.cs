using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCoffee.Models
{
    class NhanVienModel
    {
        #region Khai báo biến
        protected string CodeNV { get; set; }
        protected string SurnameNV { get; set; }
        protected string NameNV { get; set; }
        protected DateTime DateOfBirthNV { get; set; }
        protected string SexNV { get; set; }
        protected string PhoneNV { get; set; }
        protected string EmailNV { get; set; }
        protected string AddressNV { get; set; }
        #endregion

        #region Khởi tạo Contructor
        public NhanVienModel(string _CodeNV)
        {
            CodeNV = _CodeNV;
        }
        public NhanVienModel() { }
        public NhanVienModel(string _CodeNV, string _SurnameNV, string _NameNV, DateTime _DateOfBirthNV, string _SexNV, string _PhoneNV, string _EmailNV, string _AddressNV)
        {
            CodeNV = _CodeNV;
            SurnameNV = _SurnameNV;
            NameNV = _NameNV;
            DateOfBirthNV = _DateOfBirthNV;
            SexNV = _SexNV;
            PhoneNV = _PhoneNV;
            EmailNV = _EmailNV;
            AddressNV = _AddressNV;
        }
        #endregion

        #region Insert
        public int InsertNhanVien()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { CodeNV, SurnameNV, NameNV, DateOfBirthNV, SexNV, PhoneNV, EmailNV, AddressNV };
            i = Models.Connection.Excute_Sql("spInsertNhanVien", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion
        #region Update
        public int UpdateNhanVien()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { CodeNV, SurnameNV, NameNV, DateOfBirthNV, SexNV, PhoneNV, EmailNV, AddressNV };
            i = Models.Connection.Excute_Sql("spUpdateNhanVien", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion

        #region Delete
        public int DeleteNhanVien()
        {
            int i = 0;
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdNhanVien"};
            object[] values = new object[1] { CodeNV};
            i = Models.Connection.Excute_Sql("spDeleteNhanVien", CommandType.StoredProcedure, parameters, values);
            return i;
        }
        #endregion
        
        #region Hàm lấy tất cả nhân viên
        public static DataSet FillDataSetNhanVien()
        {
            //Thủ tục get nhân viên đã tạo ra bên class connection
            return Models.Connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);
        }
        #endregion

        public DataSet FillDataSet_GetNhanVienByIDNhanVien()
        {
            DataSet ds = new DataSet();
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { CodeNV };
            ds = Models.Connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, parameters, values);
            return ds;
        }
        //Search nhân viên User Control Search Nhân viên
        public DataSet FillDataSet_SearchNhanVienByIDNhanVien()
        {
            DataSet ds = new DataSet();
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { CodeNV };
            ds = Models.Connection.FillDataSet("spSearchNVByIdNV", CommandType.StoredProcedure, parameters, values);
            return ds;
        }
        public DataSet FillDataSet_SearchNhanVienByTenNhanVien()
        {
            DataSet ds = new DataSet();
            //Lưu ý: các biến truyền vào phải giống bên các biến khai báo bên sql
            string[] parameters = new string[1] { "@Ten" };
            object[] values = new object[1] { CodeNV };
            ds = Models.Connection.FillDataSet("spSearchNVByTenNV", CommandType.StoredProcedure, parameters, values);
            return ds;
        }
    }
}
