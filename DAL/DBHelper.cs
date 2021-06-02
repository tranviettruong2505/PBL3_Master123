﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.DAL
{
    class DBHelper
    {
        private static DBHelper _Instance;
        private SqlConnection cnn;
        private DBHelper (string s)
        {
            cnn = new SqlConnection(s);
        }
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = @"Data Source=LAPTOP-IMN5TH1T\SQLEXPRESS;Initial Catalog = PBL3; Integrated Security = true";
                    _Instance = new DBHelper(cnnstr);
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable GetRecord(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void ExcuteDB(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
