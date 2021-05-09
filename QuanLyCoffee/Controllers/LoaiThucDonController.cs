using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCoffee.Controllers
{
    class LoaiThucDonController
    {
        public static DataSet FillDataSet_GetLoaiThucDonByIDLoaiThucDon(string _IDLoaiThucDon)
        {
            try
            {
                Models.LoaiThucDonModel LoaiThucDon = new Models.LoaiThucDonModel(_IDLoaiThucDon);
                return LoaiThucDon.FillDataSet_GetLoaiThucDonByIDLoaiThucDon();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static int InsertLoaiThucDon(string _IDLoaiThucDon, string _TenThucDon, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.LoaiThucDonModel LoaiThucDon = new Models.LoaiThucDonModel(_IDLoaiThucDon, _TenThucDon, _DienGiai, _TrangThai);
                return LoaiThucDon.InsertLoaiThucDon();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int UpdateLoaiThucDon(string _IDLoaiThucDon, string _TenThucDon, string _DienGiai, string _TrangThai)
        {
            try
            {
                Models.LoaiThucDonModel LoaiThucDon = new Models.LoaiThucDonModel(_IDLoaiThucDon, _TenThucDon, _DienGiai, _TrangThai);
                return LoaiThucDon.UpdateLoaiThucDon();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int DeleteLoaiThucDon(string _IDLoaiThucDon)
        {
            try
            {
                Models.LoaiThucDonModel LoaiThucDon = new Models.LoaiThucDonModel(_IDLoaiThucDon);
                return LoaiThucDon.DeketeLoaiThucDon();

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
