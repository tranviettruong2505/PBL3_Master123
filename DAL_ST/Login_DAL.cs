using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
   public class Login_DAL
    {
        Connect dc;
        SqlDataAdapter da,da_;
        private  DataTable dt;
        private static Login_DAL _Instance;
        public string ID_Pos = "";
        public string Pass = "";
        public string Acc = "";
        SqlCommand cmd;
        public static Login_DAL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new Login_DAL();
                 return _Instance;
            }
            private set
            {

            }   
        }
        public Login_DAL()
        {
            dc = new Connect();
        }
        public bool ChangePass(string _Pass)
        {
            string SQL = "UPDATE Account SET Password = @Pass WHERE UserName= '"+Acc+"'";
            SqlConnection Con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(SQL, Con);
                Con.Open();
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = _Pass;
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e)
            {
                return false;
            };
            return true;
        }
        public DataTable Staff_Infor(string Account  , string Password )
        {
            Pass = Password;
            Acc = Account;
            string SQL = "SELECT ID_User,ID_Position FROM Account WHERE UserName='" + Account + "'AND Password = '" + Password + "'";
            SqlConnection Con = dc.getConnect();
            da = new SqlDataAdapter(SQL, Con);
            Con.Open();
            dt = new DataTable();
            da.Fill(dt);
            Con.Close();
            return dt;
        }
        public DataTable Get_Infor_Staff()
        {
            string ID_USER = "";
            foreach (DataRow i in dt.Rows)
            {
                ID_USER = Convert.ToString(i["ID_User"]);
                ID_Pos = Convert.ToString(i["ID_Position"]);
            }
            string Staff_In4 ="SELECT * FROM Staff WHERE ID_User = " + ID_USER;
            SqlConnection Con = dc.getConnect();
            da_ = new SqlDataAdapter(Staff_In4, Con);
            Con.Open();
            DataTable TB_Staff = new DataTable();
            da_.Fill(TB_Staff);
            if(TB_Staff.Rows.Count == 0) MessageBox.Show("Invalid Login please check" + ID_USER + " username and password");
            Con.Close();
            return TB_Staff;
        }
        public DataTable Get_BookStore()
        {
            String SQL = "SELECT Kho.MaSach , TenSach , TongSoLuong,SoLuongCon from dbo.Kho,dbo.Sach where Sach.Masach = Kho.MaSach";
            SqlConnection Con = dc.getConnect();
            da_ = new SqlDataAdapter(SQL, Con);
            Con.Open();
            DataTable TB_Staff = new DataTable();
            da_.Fill(TB_Staff);
            if (TB_Staff.Rows.Count == 0) MessageBox.Show("Invalid Login please check username and password");
            Con.Close();
            return TB_Staff;

        }
        public DataTable Get_Diary()
        {
            string SQL = "SELECT *from NhatKiNhapSach";
            SqlConnection Con = dc.getConnect();
            da_ = new SqlDataAdapter(SQL, Con);
            DataTable TB_Staff = new DataTable();
            da_.Fill(TB_Staff);
            if (TB_Staff.Rows.Count == 0) MessageBox.Show("Invalid Login please check username and password");
            Con.Close();
            return TB_Staff;
        }
    }
}
