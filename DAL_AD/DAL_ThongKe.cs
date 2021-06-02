using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_BookShopManagement.DAL
{
    class DAL_ThongKe
    {
        private static DAL_ThongKe _Instance;
        public static DAL_ThongKe Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_ThongKe();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_ThongKe() { }

        public int GetSoLuongHoaDon_DAL()
        {
            int SoHoaDon = 0;
            foreach(DataRow i in DBHelper.Instance.GetRecord("select count(MaHoaDon) from HoaDon").Rows)
            {
                if(i[0].ToString() != "")
                {
                    SoHoaDon = Convert.ToInt32(i[0]);
                }
            }
            return SoHoaDon;
        }
        public decimal GetDoanhThu_DAL()
        {
            int DoanhThu = 0;
            foreach(DataRow i in DBHelper.Instance.GetRecord("select sum(TongTien) from HoaDon").Rows)
            {
                if (i[0].ToString() != "")
                {
                    DoanhThu = Convert.ToInt32(i[0]);
                }
            }
            return DoanhThu;
        }
        public int GetSoLuongSachBan_DAL()
        {
            int SoSach = 0;
            foreach (DataRow i in DBHelper.Instance.GetRecord("select sum(SoLuong) from ChiTietHoaDon").Rows)
            {
                if (i[0].ToString() != "")
                {
                    SoSach = Convert.ToInt32(i[0]);
                }
            }
            return SoSach;
        }
        public DataTable GetHoaDon_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select MaHoaDon, TenKhachHang, NgayLap, TongTien, HoaDon.ID_Staff, Name_Staff from HoaDon, Staff " +
                "where NgayLap >= '{0}' and NgayLap <= '{1}' and HoaDon.ID_Staff = Staff.ID_Staff", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetHoaDonbyMaHD_DAL(int MaHD)
        {
            string query = string.Format("select MaHoaDon, TenKhachHang, NgayLap, TongTien, HoaDon.ID_Staff, Name_Staff from HoaDon, Staff " +
                "where HoaDon.MaHoaDon = {0} and HoaDon.ID_Staff = Staff.ID_Staff", MaHD);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetChiTietHoaDonbyMaHD_DAL(int MaHD)
        {
            string query = string.Format("select ChiTietHoaDon.MaSach, TenSach, SoLuong, MucGiamGia, GiaBia, " +
                "GiaBia * (1 - ChiTietHoaDon.MucGiamGia / 100) as GiaBan, GiaBia * (1 - ChiTietHoaDon.MucGiamGia / 100) * SoLuong as TongTienBan " +
                "from ChiTietHoaDon, Sach, ThongTinXuatBan where ChiTietHoaDon.MaSach = Sach.MaSach and ChiTietHoaDon.MaSach = ThongTinXuatBan.MaSach " +
                "and ChiTietHoaDon.MaHoaDon = {0}", MaHD);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetDoanhThuTheoNhanVien_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select HoaDon.ID_Staff, Name_Staff, SUM(SoLuong) as SoSachBan, SUM(TongTien) as TongTienBan " +
                "from ChiTietHoaDon, HoaDon, Staff where HoaDon.ID_Staff = Staff.ID_Staff and NgayLap >= '{0}' and NgayLap <= '{1}' " +
                "and ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon group by HoaDon.ID_Staff, Name_Staff ", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetDoanhThuTheoTenSach_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select truyvancon.MaSach, TenSach, TongSachBan, TongTienBan from Sach, " +
                "(select ChiTietHoaDon.MaSach, Sum(SoLuong) as TongSachBan, SUM(GiaBia*(1 - ChiTietHoaDon.MucGiamGia/100)*SoLuong) " +
                "as TongTienBan from ChiTietHoaDon, ThongTinXuatBan, HoaDon where ChiTietHoaDon.MaSach = ThongTinXuatBan.MaSach " +
                "and NgayLap >= '{0}' and NgayLap <= '{1}' and ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon " +
                "group by ChiTietHoaDon.MaSach) truyvancon where truyvancon.MaSach = Sach.MaSach", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetDoanhThuTheoLoaiSach_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select TenLoaiSach, SUM(SoLuong) as TongSachBan, SUM(GiaBia*(1 - ChiTietHoaDon.MucGiamGia/100)*SoLuong) " +
                "as TongTienBan from Sach, ChiTietHoaDon, HoaDon, ThongTinXuatBan where ChiTietHoaDon.MaSach = Sach.MaSach " +
                "and ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon and ChiTietHoaDon.MaSach = ThongTinXuatBan.MaSach and NgayLap >= '{0}' " +
                "and NgayLap <= '{1}' group by TenLoaiSach", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetDoanhThuTheoLinhVuc_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select TenLinhVuc, SUM(SoLuong) as TongSoLuong, SUM(GiaBia*(1 - ChiTietHoaDon.MucGiamGia/100)*SoLuong) " +
                "as TongTien from HoaDon, ChiTietHoaDon, Sach, ThongTinXuatBan where ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon and " +
                "ChiTietHoaDon.MaSach = Sach.MaSach and ChiTietHoaDon.MaSach = ThongTinXuatBan.MaSach and NgayLap >= '{0}' " +
                "and NgayLap <= '{1}' group by TenLinhVuc", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public decimal GetChiPhi_DAL()
        {
            int DoanhThu = 0;
            foreach (DataRow i in DBHelper.Instance.GetRecord("select Sum(ChiPhi) as TongChiPhi from (select NhatKiNhapSach.MaSach, SoLuong*GiaMua as ChiPhi " +
                "from Sach, NhatKiNhapSach where Sach.MaSach = NhatKiNhapSach.MaSach) as truyvan").Rows)
            {
                if(i[0].ToString() != "")
                {
                    DoanhThu = Convert.ToInt32(i[0]);
                }
            }
            return DoanhThu;
        }
        public int GetSoLuongSachMua_DAL()
        {
            int SoSach = 0;
            foreach (DataRow i in DBHelper.Instance.GetRecord("select sum(SoLuong) from NhatKiNhapSach").Rows)
            {
                if (i[0].ToString() != "")
                {
                    SoSach = Convert.ToInt32(i[0]);
                }
            }
            return SoSach;
        }
        public DataTable GetNhatKiNhapKho_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select STT, NhatKiNhapSach.MaSach, TenSach, SoLuong, SoLuong*GiaMua as ChiPhi, NgayNhap, " +
                "NhatKiNhapSach.ID_Staff, Name_Staff from NhatKiNhapSach, Sach, Staff where NhatKiNhapSach.MaSach = Sach.MaSach " +
                "and NhatKiNhapSach.ID_Staff = Staff.ID_Staff and NgayNhap >= '{0}' and NgayNhap <= '{1}'", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetChiPhiTheoNhanVien_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select truyvan.ID_Staff, Name_Staff, TongSachMua, TongTienMua from Staff, (select NhatKiNhapSach.ID_Staff, SUM(SoLuong) as TongSachMua, " +
                "Sum(SoLuong * GiaMua) as TongTienMua from Sach, NhatKiNhapSach where NhatKiNhapSach.MaSach = Sach.MaSach and NgayNhap >= '{0}' " +
                "and NgayNhap <= '{1}'group by NhatKiNhapSach.ID_Staff) truyvan where truyvan.ID_Staff = Staff.ID_Staff", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetChiPhiTheoTenSach_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select truyvancon.MaSach, TenSach, TongSachMua, TongTienMua from Sach, (select NhatKiNhapSach.MaSach, Sum(SoLuong) " +
                "as TongSachMua, Sum(SoLuong * GiaMua) as TongTienMua from Sach, NhatKiNhapSach where Sach.MaSach = NhatKiNhapSach.MaSach and NgayNhap >= '{0}' " +
                "and NgayNhap <= '{1}' group by NhatKiNhapSach.MaSach) truyvancon where truyvancon.MaSach = Sach.MaSach", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetChiPhiTheoLoaiSach_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select TenLoaiSach , SUM(SoLuong) as TongSachMua, SUM(SoLuong*GiaMua) as TongTienMua from Sach, NhatKiNhapSach " +
                "where NhatKiNhapSach.MaSach = Sach.MaSach and NgayNhap >= '{0}' and NgayNhap <= '{1}' group by Sach.TenLoaiSach", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public DataTable GetChiPhiTheoLinhVuc_DAL(DateTime dateFrom, DateTime dateTo)
        {
            string query = string.Format("select TenLinhVuc , SUM(SoLuong) as TongSachMua, SUM(SoLuong*GiaMua) as TongTienMua from Sach, NhatKiNhapSach " +
                "where NhatKiNhapSach.MaSach = Sach.MaSach and NgayNhap >= '{0}' and NgayNhap <= '{1}' group by Sach.TenLinhVuc", dateFrom, dateTo);
            return DBHelper.Instance.GetRecord(query);
        }
        public int GetSoSachBan_TG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            int soluong = 0;
            string query = string.Format("select SUM(SoLuong) from ChiTietHoaDon, HoaDon where NgayLap >= '{0}' and NgayLap <= '{1}' and ChiTietHoaDon.MaHoaDon = HoaDon.MaHoaDon", dateFrom, dateTo);
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                if(i[0].ToString() != "")
                {
                    soluong = Convert.ToInt32(i[0]);
                }
            }
            return soluong;
        }
        public int GetSoHoaDon_TG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            int soluong = 0;
            string query = string.Format("select COUNT(MaHoaDon) from HoaDon where NgayLap >= '{0}' and NgayLap <= '{1}'", dateFrom, dateTo);
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                if(i[0].ToString() != "")
                {
                    soluong = Convert.ToInt32(i[0]);
                } 
            }
            return soluong;
        }
        public decimal GetTongTienBan_TG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            decimal tongtien = 0;
            string query = string.Format("select SUM(TongTien) from HoaDon where NgayLap >= '{0}' and NgayLap <= '{1}'", dateFrom, dateTo);
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                if (i[0].ToString() != "")
                {
                    tongtien = Convert.ToInt32(i[0]);
                }
            }
            return tongtien;
        }
        public int GetSoSachMua_TG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            int soluong = 0;
            string query = string.Format("select SUM(SoLuong) from NhatKiNhapSach where NgayNhap >= '{0}' and NgayNhap <= '{1}'", dateFrom, dateTo);
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                if(i[0].ToString() != "")
                {
                    soluong = Convert.ToInt32(i[0]);
                }
            }
            return soluong;
        }
        public decimal GetTongTienMua_TG_DAL(DateTime dateFrom, DateTime dateTo)
        {
            decimal TienMua = 0;
            string query = string.Format("select SUM(SoLuong*GiaMua) as ChiPhi from Sach, NhatKiNhapSach where Sach.MaSach = NhatKiNhapSach.MaSach " +
                "and NgayNhap >= '{0}' and NgayNhap <= '{1}'", dateFrom, dateTo);
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                if(i[0].ToString() != "")
                {
                    TienMua = Convert.ToInt32(i[0]);
                } 
            }
            return TienMua;
        }
        public int GetTongSoSachKho_DAL()
        {
            int soluong = 0;
            foreach(DataRow i in DBHelper.Instance.GetRecord("select Sum(TongSoLuong) from Kho").Rows)
            {
                if (i[0].ToString() != "")
                {
                    soluong = Convert.ToInt32(i[0]);
                }
            }
            return soluong;
        }
        public int GetSoSachConKho_DAL()
        {
            int soluong = 0;
            foreach (DataRow i in DBHelper.Instance.GetRecord("select Sum(SoLuongCon) from Kho").Rows)
            {
                if(i[0].ToString() != "")
                {
                    soluong = Convert.ToInt32(i[0]);
                }
            }
            return soluong;
        }
        public DataTable GetKhobySach_DAL()
        {
            return DBHelper.Instance.GetRecord("select Kho.MaSach, TenSach, TongSoLuong, SoLuongCon  from Kho, Sach " +
                "where Kho.MaSach = Sach.MaSach");
        }
        public DataTable GetKhobyLoaiSach_DAL()
        {
            return DBHelper.Instance.GetRecord("select TenLoaiSach, SUM(TongSoLuong), SUM(SoLuongCon) from Kho, Sach " +
                "where Kho.MaSach = Sach.MaSach group by TenLoaiSach");
        }
        public DataTable GetKhobyLinhVuc_DAL()
        {
            return DBHelper.Instance.GetRecord("select TenLinhVuc, SUM(TongSoLuong), SUM(SoLuongCon) from Kho, Sach " +
                "where Kho.MaSach = Sach.MaSach group by TenLinhVuc");
        }

        //public DataTable Test()
        //{
        //    return DBHelper.Instance.GetRecord("select * from HoaDon");
        //}
    }
}
