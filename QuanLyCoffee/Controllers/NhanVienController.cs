using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.Controllers
{
    class NhanVienController
    {
        public static DataSet FillDataSet_GetNhanVienByIDNhanVien(string _CodeNV)
        {
            try
            {
                Models.NhanVienModel NhanVien = new Models.NhanVienModel(_CodeNV);
                return NhanVien.FillDataSet_GetNhanVienByIDNhanVien();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //Search Nhân viên
        public static DataSet FillDataSet_SearchNhanVienByIDNhanVien(string _CodeNV)
        {
            try
            {
                Models.NhanVienModel NhanVien = new Models.NhanVienModel(_CodeNV);
                return NhanVien.FillDataSet_SearchNhanVienByIDNhanVien();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchNhanVienByTenNhanVien(string _NameNV)
        {
            try
            {
                Models.NhanVienModel NhanVien = new Models.NhanVienModel(_NameNV);
                return NhanVien.FillDataSet_SearchNhanVienByTenNhanVien();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static int InsertNhanVien(string _CodeNV, string _SurnameNV, string _NameNV, DateTime _DateOfBirthNV, string _SexNV, string _PhoneNV, string _EmailNV, string _AddressNV)
        {
            try
            {
                Models.NhanVienModel NhanVien = new Models.NhanVienModel(_CodeNV, _SurnameNV, _NameNV, _DateOfBirthNV, _SexNV, _PhoneNV, _EmailNV, _AddressNV);
                return NhanVien.InsertNhanVien();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int UpdateNhanVien(string _CodeNV, string _SurnameNV, string _NameNV, DateTime _DateOfBirthNV, string _SexNV, string _PhoneNV, string _EmailNV, string _AddressNV)
        {
            try
            {
                Models.NhanVienModel NhanVien = new Models.NhanVienModel(_CodeNV, _SurnameNV, _NameNV, _DateOfBirthNV, _SexNV, _PhoneNV, _EmailNV, _AddressNV);
                return NhanVien.UpdateNhanVien();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int DeleteNhanVien(string _CodeNV)
        {
            try
            {
                Models.NhanVienModel NhanVien = new Models.NhanVienModel(_CodeNV);
                return NhanVien.DeleteNhanVien();

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
