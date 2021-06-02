using PBL3_BookShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_BookShopManagement.BLL
{
    class BLL_ThongKe
    {
        private static BLL_ThongKe _Instance;
        public static BLL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ThongKe();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ThongKe() { }
        public DataTable GetHoaDon_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetHoaDon_DAL(dateFrom, dateTo);
        }
        public int GetSoLuongHoaDon_BLL()
        {
            return DAL_ThongKe.Instance.GetSoLuongHoaDon_DAL();
        }
        public decimal GetDoanhThu_BLL()
        {
            return DAL_ThongKe.Instance.GetDoanhThu_DAL();
        }
        public int GetSoLuongSachBan_BLL()
        {
            return DAL_ThongKe.Instance.GetSoLuongSachBan_DAL();
        }
        public DataTable GetDoanhThuTheoNhanVien_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetDoanhThuTheoNhanVien_DAL(dateFrom, dateTo);
        }
        public DataTable GetDoanhThuTheoTenSach_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetDoanhThuTheoTenSach_DAL(dateFrom, dateTo);
        }
        public DataTable GetDoanhThuTheoLoaiSach_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetDoanhThuTheoLoaiSach_DAL(dateFrom, dateTo);
        }
        public DataTable GetDoanhThuTheoLinhVuc_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetDoanhThuTheoLinhVuc_DAL(dateFrom, dateTo);
        }
        public decimal GetChiPhi_BLL()
        {
            return DAL_ThongKe.Instance.GetChiPhi_DAL();
        }
        public int GetSoLuongSachMua_BLL()
        {
            return DAL_ThongKe.Instance.GetSoLuongSachMua_DAL();
        }
        public DataTable GetNhatKiNhapKho_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetNhatKiNhapKho_DAL(dateFrom, dateTo);
        }
        public DataTable GetChiPhiTheoNhanVien_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetChiPhiTheoNhanVien_DAL(dateFrom, dateTo);
        }
        public DataTable GetChiPhiTheoTenSach_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetChiPhiTheoTenSach_DAL(dateFrom, dateTo);
        }
        public DataTable GetChiPhiTheoLoaiSach_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetChiPhiTheoLoaiSach_DAL(dateFrom, dateTo);
        }
        public DataTable GetChiPhiTheoLinhVuc_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetChiPhiTheoLinhVuc_DAL(dateFrom, dateTo);
        }
        public int GetSoSachBan_TG_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetSoSachBan_TG_DAL(dateFrom, dateTo);
        }
        public int GetSoHoaDon_TG_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetSoHoaDon_TG_DAL(dateFrom, dateTo);
        }
        public decimal GetTongTienMua_TG_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetTongTienMua_TG_DAL(dateFrom, dateTo);
        }
        public int GetSoSachMua_TG_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetSoSachMua_TG_DAL(dateFrom, dateTo);
        }
        public decimal GetTongTienBan_TG_BLL(DateTime dateFrom, DateTime dateTo)
        {
            return DAL_ThongKe.Instance.GetTongTienBan_TG_DAL(dateFrom, dateTo);
        }

        public DataTable GetChiTietHoaDonbyMaHD_BLL(int MaHD)
        {
            return DAL_ThongKe.Instance.GetChiTietHoaDonbyMaHD_DAL(MaHD);
        }

        public DataTable GetHoaDonbyMaHD_BLL(int MaHD)
        {
            return DAL_ThongKe.Instance.GetHoaDonbyMaHD_DAL(MaHD);
        }

        public int GetTongSoSachKho_BLL()
        {
            return DAL_ThongKe.Instance.GetTongSoSachKho_DAL();
        }
        public int GetSoSachConKho_BLL()
        {
            return DAL_ThongKe.Instance.GetSoSachConKho_DAL();
        }
        public DataTable GetKhobySach_BLL()
        {
            return DAL_ThongKe.Instance.GetKhobySach_DAL();
        }
        public DataTable GetKhobyLoaiSach_BLL()
        {
            return DAL_ThongKe.Instance.GetKhobyLoaiSach_DAL();
        }
        public DataTable GetKhobyLinhVuc_BLL()
        {
            return DAL_ThongKe.Instance.GetKhobyLinhVuc_DAL();
        }
    }
}
