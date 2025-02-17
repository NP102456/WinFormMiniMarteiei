using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMiniMart
{
    internal class connDB
    {
        public static SqlConnection ConnectMinimart()
        {
            string server = @"LAPTOP-IQ8TJ0SI\SQLEXPRESS"; //ชื่อserverของตัวเอง
            string db = "MiniMart"; //ชื่อฐานข้อมูล

            //คำสั่งเชื่อมต่อ
            string strCon = string.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=True; Encrypt=False", server, db);
            //ประกาศตัวแปรคลาสเชื่อมต่อ
            SqlConnection conn = new SqlConnection(strCon);
            //เปิดการเชื่อมต่อกับฐานช้อมูล
            conn.Open();
            return conn;
        }
    }
}
