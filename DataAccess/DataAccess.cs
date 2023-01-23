using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Data
    {
        public SqlConnection getConnect() //Nhận chuỗi kết nối
        {
            return new SqlConnection("Data Source=.\\PHAMTHEHIEN;Initial Catalog=QLDT;Integrated Security=True");
        }
        //Lệnh trả về một bảng
        public DataTable GetTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        //Lệnh thực hiện 1 hành động, không trả về một bảng
        public void ExecuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }
    }
}
