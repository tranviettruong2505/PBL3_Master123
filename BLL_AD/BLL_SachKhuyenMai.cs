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
    class BLL_SachKhuyenMai
    {
        private static BLL_SachKhuyenMai _Instance;
        public static BLL_SachKhuyenMai Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SachKhuyenMai();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_SachKhuyenMai() { }
        public List<SachKMView> getListSachKMView_BLL(string name)
        {
            return DAL_SachKhuyenMai.Instance.getListSachKMViewbyName_DaAdd_DAL(name);
        }
        public bool AddSachKM_BLL(SachKhuyenMai sachKhuyenMai)
        {
            return DAL_SachKhuyenMai.Instance.AddSachKM_DAL(sachKhuyenMai);
        }
        public bool UpdateSachKM_BLL(SachKhuyenMai sachKhuyenMai)
        {
            return DAL_SachKhuyenMai.Instance.UpdateSachKM_DAL(sachKhuyenMai);
        }
        public SachKMView GetSachKMViewByID_BLL(int id)
        {
            SachKMView sachKMView = new SachKMView();
            foreach (SachKMView i in DAL_SachKhuyenMai.Instance.getListSachKMViewbyName_DaAdd_DAL(""))
            {
                if (i.MaSach == id)
                {
                    sachKMView = i;
                }
            }
            return sachKMView;
        }
        //hàm lấy thông tin sách chưa có trong table sachKhuyenMai
        public void ExecuteSachKM_BLL(SachKhuyenMai sachKhuyenMai)
        {
            bool check = false;
            foreach(DataRow i in DAL_SachKhuyenMai.Instance.getAllSachKhuyenMai().Rows)
            {
                if (sachKhuyenMai.MaSach == Convert.ToInt32(i["MaSach"]))
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                BLL_SachKhuyenMai.Instance.UpdateSachKM_BLL(sachKhuyenMai);
            }
            else
            {
                BLL_SachKhuyenMai.Instance.AddSachKM_BLL(sachKhuyenMai);
            }
        }
        //Lấy ra sách có id trùng (cả có trong danh sách khuyến mãi lẫn chưa)
        public SachKMView GetSachKMViewByID_All_BLL(int id)
        {
            SachKMView sachKMView = new SachKMView();
            foreach (SachKMView i in DAL_SachKhuyenMai.Instance.getListSachKMView_All_DAL())
            {
                if(i.MaSach == id)
                {
                    sachKMView = i;
                }
            }
            return sachKMView;
        }
        public void DeleteSachKM_BLL(List<int> listDel)
        {
            foreach(int i in listDel)
            {
                DAL_SachKhuyenMai.Instance.DeleteSachKM_DAL(i);
            }
        }
    }
}
