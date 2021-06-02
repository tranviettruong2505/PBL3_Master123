using PBL3_BookShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_BookShopManagement.DAL
{
    class DAL_Sach
    {
        private static DAL_Sach _Instance;
        public static DAL_Sach Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DAL_Sach();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_Sach() { }
        public DataTable getAllSach_DAL()
        {
            return DBHelper.Instance.GetRecord("select * from Sach");
        }
        public DataTable getAllThongTinXB()
        {
            return DBHelper.Instance.GetRecord("select * from ThongTinXuatBan");
        }
        public SachView GetSachView(DataRow i)
        {
            return new SachView
            {
                MaSach = Convert.ToInt32(i["MaSach"]),
                TenSach = i["TenSach"].ToString(),
                GiaMua = Convert.ToInt32(i["GiaMua"]),
                TenLoaiSach = i["TenLoaiSach"].ToString(),
                TenTacGia = i["TenTacGia"].ToString(),
                TenLinhVuc = i["TenLinhVuc"].ToString(),
                NhaXuatBan = i["NhaXuatBan"].ToString(),
                LanTaiBan = i["LanTaiBan"].ToString(),
                NamXuatBan = i["NamXuatBan"].ToString(),
                GiaBia = Convert.ToInt32(i["GiaBia"]),
            };
        }
        public List<SachView> getListSachViewbyName_DAL(string name)
        {
            string query = "";
            //if (name == "")
            //{
            //    query = "select Sach.MaSach, TenSach, GiaMua, TenLoaiSach, TenTacGia, TenLinhVuc, LanTaiBan, NamXuatBan, NhaXuatBan, GiaBia " +
            //     "from Sach, ThongTinXuatBan where Sach.MaSach = ThongTinXuatBan.MaSach";
            //}
            //else
            //{
                query = "select Sach.MaSach, TenSach, GiaMua, TenLoaiSach, TenTacGia, TenLinhVuc, LanTaiBan, NamXuatBan, NhaXuatBan, GiaBia " +
                    "from Sach, ThongTinXuatBan where Sach.MaSach = ThongTinXuatBan.MaSach and TenSach like '%" + name + "%'";
            //}
            List<SachView> list = new List<SachView>();
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                list.Add(GetSachView(i));
            }
            return list;
        }
        public List<SachView> getListSachViewbyLinhVuc_DAL(string LinhVuc, string name)
        {
            if (LinhVuc == "All")
            {
                return getListSachViewbyName_DAL(name);
            }
            else
            {
                List<SachView> list = new List<SachView>();
                foreach (SachView i in getListSachViewbyName_DAL(name))
                {
                    if (i.TenLinhVuc == LinhVuc)
                    {
                        list.Add(i);
                    }
                }
                return list;
            }
        }
        public List<SachView> getListSachViewbyLoaiSach_DAL(string LoaiSach, string LinhVuc, string name)
        {
            if (LoaiSach == "All")
            {
                return getListSachViewbyLinhVuc_DAL(LinhVuc, name);
            }
            else
            {
                List<SachView> list = new List<SachView>();
                foreach (SachView i in getListSachViewbyLinhVuc_DAL(LinhVuc, name))
                {
                    if (i.TenLoaiSach == LoaiSach)
                    {
                        list.Add(i);
                    }
                }
                return list;
            }
        }
        public void AddSach_DAL(Sach sach, ThongTinXuatBan thongTin)
        {
            string query_insertSach = string.Format("insert into Sach values ('{0}', {1}, '{2}', '{3}', '{4}')",
                sach.TenSach, sach.GiaMua, sach.TenLoaiSach, sach.TenTacGia, sach.TenLinhVuc);
            DBHelper.Instance.ExecuteDB(query_insertSach);

            string query = "SELECT TOP 1 MaSach FROM Sach ORDER BY MaSach DESC";

            int masach = -1;
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                masach = Convert.ToInt32(i[0]);
            }

            string query_insertTTXB = string.Format("insert into ThongTinXuatBan values ({0}, '{1}', '{2}', '{3}', {4})",
                masach, thongTin.LanTaiBan, thongTin.NamXuatBan, thongTin.NhaXuatBan, thongTin.GiaBia);
            DBHelper.Instance.ExecuteDB(query_insertTTXB);
        }
        public void UpdateSach_DAL(Sach sach, ThongTinXuatBan thongTin)
        {
            string query_updateSach = string.Format("update Sach set TenSach = '{0}', GiaMua = {1}, TenLoaiSach = '{2}', TenTacGia = '{3}', TenLinhVuc = '{4}' where MaSach = {5}",
                sach.TenSach, sach.GiaMua, sach.TenLoaiSach, sach.TenTacGia, sach.TenLinhVuc, sach.MaSach);
            DBHelper.Instance.ExecuteDB(query_updateSach);
            string query_UpdateTTXB = string.Format("update ThongTinXuatBan set LanTaiBan = '{0}', NamXuatBan = '{1}', NhaXuatBan = '{2}', GiaBia = {3} where MaSach = {4}",
                thongTin.LanTaiBan, thongTin.NamXuatBan, thongTin.NhaXuatBan, thongTin.GiaBia, thongTin.MaSach);
            DBHelper.Instance.ExecuteDB(query_UpdateTTXB);
        }
        public void DeleteSach_DAL(int masach)
        {
            string queryDel_TTXB = "delete from ThongTinXuatBan where ThongTinXuatBan.MaSach = " + masach.ToString();
            DBHelper.Instance.ExecuteDB(queryDel_TTXB);
            string queryDel_Sach = "delete from Sach where Sach.MaSach = " + masach.ToString();
            DBHelper.Instance.ExecuteDB(queryDel_Sach);
        }
    }
}
