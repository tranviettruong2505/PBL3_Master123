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
    class DAL_Staff
    {
        private static DAL_Staff _Instance;
        public static DAL_Staff Instance 
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new DAL_Staff();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_Staff() { }
        public DataTable getAllStaff_DAL()
        {
            return DBHelper.Instance.GetRecord("select * from Staff");
        }

        //public DataTable getAllStaffView_DAL()
        //{
        //    string query = "select Staff.ID_Staff, Name_Staff, Gender, DateOfBirth, Address, Account.ID_User, UserName, Password, NamePosition " +
        //                     "from Staff, Account, Position where Staff.ID_User = Account.ID_User and Account.ID_Position = Position.ID_Position";
        //    return DBHelper.Instance.GetRecord(query);
        //}
        public DataTable getAllPosition_DAL()
        {
            return DBHelper.Instance.GetRecord("select * from Position");
        }
        public void AddStaff_DAL(Staff staff, Account account)
        {
            string query_insertAccount = string.Format("insert into Account values ( N'{0}',  N'{1}', {2})", 
                account.UserName, account.Password, account.ID_Position);
                //"insert into Account values ('" + account.UserName + "', '" + account.Password + "', " + account.ID_Position.ToString() + ")";
            DBHelper.Instance.ExecuteDB(query_insertAccount);

            string query = "SELECT TOP 1 ID_User FROM Account ORDER BY ID_User DESC";

            // DataTable dt = DBHelper.Instance.GetRecord(query);

            int id_user = -1;
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                id_user = Convert.ToInt32(i[0]);
            }

            //string query_insertStaff = "insert into Staff values ('" + staff.Name_Staff + "' , '" +  staff.Gender.ToString() 
            //    + "', '" + staff.DateOfBirth.ToString() + "', '" + staff.Address + "', " + id_user.ToString() + ")";
            string query_insertStaff = string.Format("insert into Staff values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})",
                staff.Name_Staff, staff.Gender, staff.DateOfBirth, staff.Address, id_user,staff.SDT,staff.Mail);
            DBHelper.Instance.ExecuteDB(query_insertStaff);
        }
        public void UpdateStaff_DAL(Staff staff, Account account)
        {
            //Cập nhật bảng Account ko được nhưng bảng user đc => database có thay đổi => database ko đổi
            string query_updateAccount = "update Account set UserName = '" + account.UserName + "', Password = '" + account.Password + "', ID_Position = " + account.ID_Position.ToString() + " where ID_User =" + account.ID_User.ToString();
            DBHelper.Instance.ExecuteDB(query_updateAccount);
            string query_UpdateStaff = "update Staff set Name_Staff = '" + staff.Name_Staff + "', Gender = '" + staff.Gender.ToString() + "', DateOfBirth = '"
                + staff.DateOfBirth.ToString() + "', Address = '" + staff.Address + "', Mail = '" + staff.Mail + "', SDT = '" + staff.SDT + "' where ID_Staff = " 
                + staff.ID_Staff.ToString();
            DBHelper.Instance.ExecuteDB(query_UpdateStaff);
        }
        public DataTable GetAllAcount_DAL()
        {
            string query = "select * from Account";
            return DBHelper.Instance.GetRecord(query);
        }
        public void DeleteStaff_DAL(string IDStaff)
        {
            string query = "select ID_User from Staff where ID_Staff = " + IDStaff;
            DataTable dt = DBHelper.Instance.GetRecord(query);
            int IDUser = -1;
            foreach(DataRow i in dt.Rows)
            {
                IDUser = Convert.ToInt32(i["ID_User"]);
            }

            string query_DelStaff  = "delete from Staff where ID_Staff = " + IDStaff;
            DBHelper.Instance.ExecuteDB(query_DelStaff);

            string query_DelAccount = "delete from Account where ID_User = " + IDUser;
            DBHelper.Instance.ExecuteDB(query_DelAccount);
        }
        public StaffView GetStaffView(DataRow i)
        {
            return new StaffView
            {
                ID_Staff = Convert.ToInt32(i["ID_Staff"]),
                Name_Staff = i["Name_Staff"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"]),
                DateOfBirth = Convert.ToDateTime(i["DateOfBirth"]),
                Address = i["Address"].ToString(),
                ID_User = Convert.ToInt32(i["ID_User"]),
                UserName = i["UserName"].ToString(),
                Password = i["Password"].ToString(),
                NamePosition = i["NamePosition"].ToString(),
                Mail = i["Email"].ToString(),
                SDT = i["PhoneNumber"].ToString()
            };
        }
        public string getNamePosition(int idPos)
        {
            string Pos = "";
            foreach(DataRow i in getAllPosition_DAL().Rows)
            {
                if(Convert.ToInt32(i["ID_Position"]) == idPos)
                {
                    Pos = i["NamePosition"].ToString();
                }
            }
            return Pos;
        }
        public List<StaffView> GetListStaffViewbyName_DAL(string name)
        {
            string query = "";
            //if (name == null)
            //{
            //    query = "select Staff.ID_Staff, Name_Staff, Gender, DateOfBirth, Address, Mail, SDT, Account.ID_User, UserName, Password, NamePosition " +
            //                     "from Staff, Account, Position where Staff.ID_User = Account.ID_User and Account.ID_Position = Position.ID_Position";
            //}
            //else
            //{
                query = "select Staff.ID_Staff, Name_Staff, Gender, DateOfBirth, Address, Email, PhoneNumber, Account.ID_User, UserName, Password, NamePosition " +
                             "from Staff, Account, Position where Staff.ID_User = Account.ID_User and Account.ID_Position = Position.ID_Position and Name_Staff like '%" + name + "%'"; 
            //}
            List<StaffView> list = new List<StaffView>();
            foreach(DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                list.Add(GetStaffView(i));
            }
            return list;
        }
        public List<StaffView> GetListStaffViewbyIDPos_DAL(int idPos, string name)
        {
            if (idPos == 0)
            {
                return GetListStaffViewbyName_DAL(name);
            }
            else
            {
                List<StaffView> data = new List<StaffView>();
                foreach(StaffView i in GetListStaffViewbyName_DAL(name))
                {
                    if(i.NamePosition == getNamePosition(idPos))
                    {
                        data.Add(i);
                    }
                }
                return data;
            }
            //if (name == null)
            //{
            //    string query = "select Staff.ID_Staff, Name_Staff, Gender, DateOfBirth, Address, Account.ID_User, UserName, Password, NamePosition " +
            //     "from Staff, Account, Position where Staff.ID_User = Account.ID_User and Account.ID_Position = Position.ID_Position " +
            //     " and Account.ID_Position = " + idPos.ToString();
            //    return DBHelper.Instance.GetRecord(query);
            //}
            //else
            //{
            //    string query = "select Staff.ID_Staff, Name_Staff, Gender, DateOfBirth, Address, Account.ID_User, UserName, Password, NamePosition " +
            //     "from Staff, Account, Position where Staff.ID_User = Account.ID_User and Account.ID_Position = Position.ID_Position " +
            //     " Name_Staff = '" + name +  "' and Account.ID_Position = " + idPos.ToString();
            //    return DBHelper.Instance.GetRecord(query);
            //}
        }


    }
}
