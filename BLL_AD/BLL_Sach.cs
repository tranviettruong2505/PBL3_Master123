using PBL3_BookShopManagement.DAL;
using PBL3_BookShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_BookShopManagement.BLL
{
    class BLL_Sach
    {
        private static BLL_Sach _Instance;
        public static BLL_Sach Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_Sach();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_Sach()
        {
        }
        public List<SachView> getListSachView_BLL(string name, string LinhVuc, string LoaiSach)
        {
            if ((LinhVuc == "All") && (LoaiSach == "All"))
            {
                return DAL_Sach.Instance.getListSachViewbyName_DAL(name);
            }
            else
            {
                if (LoaiSach == "All")
                {
                    return DAL_Sach.Instance.getListSachViewbyLinhVuc_DAL(LinhVuc, name);
                }
                else
                {
                    return DAL_Sach.Instance.getListSachViewbyLoaiSach_DAL(LoaiSach, LinhVuc, name);
                }
            }
        }
        public void AddBook_BLL(Sach sach, ThongTinXuatBan thongTin)
        {
            DAL_Sach.Instance.AddSach_DAL(sach, thongTin);
        }
        public void UpdateBook_BLL(Sach sach, ThongTinXuatBan thongTin)
        {
            DAL_Sach.Instance.UpdateSach_DAL(sach, thongTin);
        }
        public void ExecuteSach(Sach sach, ThongTinXuatBan thongTin)
        {
            bool check = false;
            foreach (DataRow i in DAL_Sach.Instance.getAllSach_DAL().Rows)
            {
                if (Convert.ToInt32(i["MaSach"]) == sach.MaSach)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                UpdateBook_BLL(sach, thongTin);
            }
            else
            {
                AddBook_BLL(sach, thongTin);
            }
        }
        public SachView GetSachViewByMaSach(int masach)
        {
            SachView sach = new SachView();
            foreach (SachView i in getListSachView_BLL("", "All", "All"))
            {
                if (i.MaSach == masach)
                {
                    sach = i;
                    break;
                }
            }
            return sach;
        }
        public void DeleteSach_BLL(List<int> listMaSach)
        {
            foreach(int i in listMaSach)
            {
                DAL_Sach.Instance.DeleteSach_DAL(i);
            }
        }
    }
}
