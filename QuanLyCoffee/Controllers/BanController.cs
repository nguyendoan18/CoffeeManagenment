using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.Controllers
{
    class BanController
    {
        public static DataSet FillDataSet_GetBanByIDBan(string _IDBan)
        {
            try
            {
                Models.BanModel Ban = new Models.BanModel(_IDBan);
                return Ban.FillDataSet_GetBanByIDBan();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static int InsertBan(string _IDBan, string _TenKhuVuc, string _TenBan, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.BanModel Ban = new Models.BanModel(_IDBan, _TenKhuVuc, _TenBan, _DienGiai, _TrangThai);
                return Ban.InsertBan();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int UpdateBan(string _IDBan, string _TenKhuVuc, string _TenBan, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.BanModel Ban = new Models.BanModel(_IDBan, _TenKhuVuc, _TenBan, _DienGiai, _TrangThai);
                return Ban.UpdateBan();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int DeleteBan(string _IDBan)
        {
            try
            {
                Models.BanModel Ban = new Models.BanModel(_IDBan);
                return Ban.DeketeBan();

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
