using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.Controllers
{
    class KhuVucController
    {
        public static DataSet FillDataSet_GetKhuVucByIDKhuVuc(string _IDKhuVuc)
        {
            try
            {
                Models.KhuVucModel KhuVuc = new Models.KhuVucModel(_IDKhuVuc);
                return KhuVuc.FillDataSet_GetKhuVucByIDKhuVuc();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static int InsertKhuVuc(string _IDKhuVuc, string _TenKhuVuc, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.KhuVucModel KhuVuc = new Models.KhuVucModel(_IDKhuVuc, _TenKhuVuc, _DienGiai, _TrangThai);
                return KhuVuc.InsertKhuVuc();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int UpdateKhuVuc(string _IDKhuVuc, string _TenKhuVuc, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.KhuVucModel KhuVuc = new Models.KhuVucModel(_IDKhuVuc, _TenKhuVuc, _DienGiai, _TrangThai);
                return KhuVuc.UpdateKhucVuc();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int DeleteKhuVuc(string _IDKhuVuc)
        {
            try
            {
                Models.KhuVucModel KhuVuc = new Models.KhuVucModel(_IDKhuVuc);
                return KhuVuc.DeketeKhucVuc();

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
