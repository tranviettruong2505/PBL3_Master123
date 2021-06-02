using PBL3_BookShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_BookShopManagement.DAL
{
    class DAL_SachKhuyenMai
    {
        private static DAL_SachKhuyenMai _Instance;
        public static DAL_SachKhuyenMai Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_SachKhuyenMai();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_SachKhuyenMai() { }
        public DataTable getAllSachKhuyenMai()
        {
            return DBHelper.Instance.GetRecord("select * from SachKhuyenMai");
        }
        public SachKMView GetSachKMView(DataRow i)
        {
            SachKMView sachKMView = new SachKMView();
            sachKMView.MaSach = Convert.ToInt32(i["MaSach"]);
            sachKMView.TenSach = i["TenSach"].ToString();
            sachKMView.GiaBia = Convert.ToInt32(i["GiaBia"]);
            sachKMView.MucGiamGia = Convert.ToDouble(i["MucGiamGia"]);
            sachKMView.GiaSauKM = sachKMView.GiaBia * (1 - sachKMView.MucGiamGia/100);
            return sachKMView;
        }
        public List<SachKMView> getListSachKMViewbyName_DaAdd_DAL(string name)
        {
            string query = "";
            //if (name == "")
            //{
            //    query = "select SachKhuyenMai.MaSach, TenSach, GiaBia, MucGiamGia from Sach, ThongTinXuatBan, SachKhuyenMai " +
            //        "where SachKhuyenMai.MaSach = ThongTinXuatBan.MaSach and SachKhuyenMai.MaSach = Sach.MaSach";
            //}
            //else
            //{
                query = "select SachKhuyenMai.MaSach, TenSach, GiaBia, MucGiamGia from Sach, ThongTinXuatBan, SachKhuyenMai " +
                    "where SachKhuyenMai.MaSach = ThongTinXuatBan.MaSach and SachKhuyenMai.MaSach = Sach.MaSach and TenSach like '%" + name + "%'";
            //}
            List<SachKMView> list = new List<SachKMView>();
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                list.Add(GetSachKMView(i));
            }
            return list;
        }

        //Lấy tất cả sách từ danh sách sách add vào danh sách
        public List<SachKMView> getListSachKMView_All_DAL()
        {
            string query = "select Sach.MaSach, TenSach, GiaBia from Sach, ThongTinXuatBan where Sach.MaSach = ThongTinXuatBan.MaSach";
            List<SachKMView> list = new List<SachKMView>();
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                list.Add(new SachKMView
                {
                    MaSach = Convert.ToInt32(i["MaSach"]),
                    TenSach = i["TenSach"].ToString(),
                    GiaBia = Convert.ToInt32(i["GiaBia"]),
                    MucGiamGia = 0,
                    GiaSauKM = Convert.ToInt32(i["GiaBia"])
                }) ;
            }
            return list;
        }
        public bool AddSachKM_DAL(SachKhuyenMai sachKhuyenMai)
        {
            string query = string.Format("insert into SachKhuyenMai values ({0}, {1})", sachKhuyenMai.MaSach, sachKhuyenMai.MucGiamGia);
            if (DBHelper.Instance.ExecuteDB(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateSachKM_DAL(SachKhuyenMai sachKhuyenMai)
        {
            string query = string.Format("Update SachKhuyenMai set MucGiamGia = {0} where SachKhuyenMai.MaSach = {1} ", 
                sachKhuyenMai.MaSach, sachKhuyenMai.MucGiamGia);
            if (DBHelper.Instance.ExecuteDB(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteSachKM_DAL(int masachKM)
        {
            string query = string.Format("delete from SachKhuyenMai where MaSach = {0}", masachKM);
            DBHelper.Instance.ExecuteDB(query);
        }

    }
}
