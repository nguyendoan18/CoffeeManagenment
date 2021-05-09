using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCoffee.Controllers
{
    class ThucDonController
    {
        public static DataSet FillDataSet_GetThucDonByIDThucDon(string _IDThucDon)
        {
            try
            {
                Models.ThucDonModel ThucDon = new Models.ThucDonModel(_IDThucDon);
                return ThucDon.FillDataSet_GetThucDonByIDThucDon();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static int InsertThucDon(string _IDThucDon, string _TenLoaiThucDon, string _TenThucDon, float _DonViTinh, float _SoLuongTon, float _DonGiaTon, float _TonToiThieu, string _TrangThai)
        {
            try
            {
                Models.ThucDonModel ThucDon = new Models.ThucDonModel(_IDThucDon, _TenLoaiThucDon, _TenThucDon, _DonViTinh, _SoLuongTon, _DonGiaTon, _TonToiThieu, _TrangThai);
                return ThucDon.InsertThucDon();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int UpdateThucDon(string _IDThucDon, string _TenLoaiThucDon, string _TenThucDon, float _DonViTinh, float _SoLuongTon, float _DonGiaTon, float _TonToiThieu, string _TrangThai)
        {
            try
            {
                Models.ThucDonModel ThucDon = new Models.ThucDonModel(_IDThucDon, _TenLoaiThucDon, _TenThucDon, _DonViTinh, _SoLuongTon, _DonGiaTon, _TonToiThieu, _TrangThai);
                return ThucDon.UpdateThucDon();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int DeleteThucDon(string _IDThucDon)
        {
            try
            {
                Models.ThucDonModel ThucDon = new Models.ThucDonModel(_IDThucDon);
                return ThucDon.DeleteThucDon();

            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
