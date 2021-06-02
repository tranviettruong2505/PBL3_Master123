using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement
{
    class CSDL_OOP
    {
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null) _Instance = new CSDL_OOP();
                return _Instance;
            }
            private set
            {

            }
        }
       public List<Bookstore> Sort_item(int Property)
        {
            List<Bookstore> BS = new List<Bookstore>();
            foreach(DataRow i in CSDL_USER.Instance.Books.Rows)
            {
                BS.Add(GetDBBook(i));
            }
            List<object[]> tg = new List<object[]>();
            for(int i = 0; i<BS.Count; i++)
            {
                object[] t = new object[CSDL_USER.Instance.Books.Columns.Count];
                t[0] = BS[i].MaSach;
                t[1] = BS[i].TenSach;
                t[2] = BS[i].TongSoLuong;
                t[3] = BS[i].SoLuongCon;
                tg.Add(t);

            }
            for (int i = 0; i < tg.Count; i++)
            {
                for (int j = i + 1; j < tg.Count - 1; j++)
                {
                    if (string.Compare(tg[i][Property].ToString(), tg[j][Property].ToString()) > 0)
                    {
                        object[] t = tg[i];
                        tg[i] = tg[j];
                        tg[j] = t;
                    }
                }
            }
            return BS;
        }
        public Diary GetDiary(DataRow Dr)
        {
            Diary dr = new Diary();
            dr.STT = Convert.ToInt32(Dr["STT"]);
            dr.MaSach = Convert.ToInt32(Dr["MaSach"]);
            dr.SoLuong = Convert.ToInt32(Dr["SoLuong"]);
            dr.NgayNhap = Convert.ToDateTime(Dr["NgayNhap"]);
            dr.ID_Staff = Convert.ToInt32(Dr["ID_Staff"]);
            return dr;
        }
        public List<Diary> GetDiaries()
        {
            List<Diary> DR = new List<Diary>();
            foreach(DataRow i in CSDL_USER.Instance.Diary.Rows)
            {
                DR.Add(GetDiary(i));
            }
            return DR;
        }
        public Bookstore GetDBBook(DataRow Book)
        {
            Bookstore St = new Bookstore();
            St.MaSach = Convert.ToString(Book["MaSach"]);
            St.TenSach = Convert.ToString(Book["TenSach"]);
            St.TongSoLuong = Convert.ToString(Book["TongSoLuong"]);
            St.SoLuongCon = Convert.ToString(Book["SoLuongCon"]);
            return St;
        }
        public List<Bookstore> GetBookstores(string Name)
        {
            List<Bookstore> St = new List<Bookstore>();

            foreach(DataRow i in Login_DAL.Instance.Get_BookStore().Rows)
            {
                if(Name == Convert.ToString(i["TenSach"]))
                St.Add(GetDBBook(i));
                if (Name == "") St.Add(GetDBBook(i));
            }
            return St;
        }
        public Staff GetDBStaff( DataRow staff)
        {
            Staff _Staff = new Staff();
            _Staff.ID_Staff = Convert.ToInt32(staff["ID_Staff"]);
            _Staff.Name_Staff = Convert.ToString(staff["Name_Staff"]);
            _Staff.Gender = Convert.ToBoolean(staff["Gender"]);
            _Staff.DateOfBirth = Convert.ToDateTime(staff["DateOfBirth"]);
            _Staff.Address = Convert.ToString(staff["Address"]);
            _Staff.PhoneNumber = Convert.ToString(staff["PhoneNumber"]);
            _Staff.Email = Convert.ToString(staff["Email"]);
            return _Staff;
        }
        public List<Staff> GetAll()
        {
            List<Staff> St = new List<Staff>();
            foreach (DataRow i in CSDL_USER.Instance.Staff_Infor.Rows)
            {
                St.Add(GetDBStaff(i));
            }
            return St;
        }
        public Staff getST()
        {
            Staff _Staff = new Staff();
            foreach (DataRow i in CSDL_USER.Instance.Staff_Infor.Rows)
            {
                _Staff.ID_Staff = Convert.ToInt32(i["ID_Staff"]);
                _Staff.Name_Staff = Convert.ToString(i["Name_Staff"]);
                _Staff.Gender = Convert.ToBoolean(i["Gender"]);
                _Staff.DateOfBirth = Convert.ToDateTime(i["DateOfbirth"]);
                _Staff.Address = Convert.ToString(i["Address"]);
                _Staff.PhoneNumber = Convert.ToString(i["PhoneNumber"]);
                _Staff.Email = Convert.ToString(i["Email"]);
            }
            return _Staff;
        }
    }
}
