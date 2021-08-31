using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Ado
{
    public class QL_DangNhap
    {
        // Kiểm tra kết nối
        public static int Check_Config()
        {
            if (Properties.Settings.Default.LTWNCConn == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.LTWNCConn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }

        //Kiểm tra đăng nhập + tình trạng
        public static int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NGUOIDUNG where ID_DN='" + pUser + "' and MATKHAU ='" + pPass + "'", Properties.Settings.Default.LTWNCConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;// User không tồn tại
            else if (dt.Rows[0][7] == null || dt.Rows[0][7].ToString() == "False")
            {
                return 1;// Không hoạt động
            }
            return 2;// Đăng nhập thành công
        }

        //Get tên server
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        //Get tên CSDL
        public DataTable GetDBName(string server, string user, string pass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + server + ";Initial Catalog=master;User ID=" + user + ";pwd = " + pass + "");
            da.Fill(dt);
            return dt;
        }

        //Lưu config
        public void SaveConfig(string server, string user, string pass, string dbname)
        {
            QuanLyCuaHangTienLoi.Properties.Settings.Default.LTWNCConn = "Data Source=" + server + ";Initial Catalog=" + dbname + ";User ID=" + user + ";pwd = " + pass + "";
            QuanLyCuaHangTienLoi.Properties.Settings.Default.Save();
        }

        //Kiểm tra mật khẩu
        public static int Check_Pass(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NguoiDung where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'", Properties.Settings.Default.LTWNCConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return 1;// Không hoạt động
            }
            return 2;// Đăng nhập thành công
        }

        //Kiểm tra tên đăng nhập
        public static int Check_User(string pUser)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from NguoiDung where ID_DN='" + pUser + "'", Properties.Settings.Default.LTWNCConn);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;// User không tồn tại
            else if (dt.Rows[0][7] == null || dt.Rows[0][7].ToString() == "False")
            {
                return 1;// Không hoạt động
            }
            return 2;// Đăng nhập thành công
        }
        //Kiểm tra số điện thoại
        public static int Check_SDT(string pSDT, string pTenDN)
        {
            SqlDataAdapter daSDT = new SqlDataAdapter("select * from NguoiDung where SDT='" + pSDT + "' and ID_DN = '"+pTenDN+"'", Properties.Settings.Default.LTWNCConn); ;
            DataTable dt = new DataTable();
            daSDT.Fill(dt);
            if (dt.Rows.Count == 0)
                return 0;// User không tồn tại
            else if (dt.Rows[0][7] == null || dt.Rows[0][7].ToString() == "False")
            {
                return 1;// Không hoạt động
            }
            return 2;// Tồn tại
        }

        // Cập nhât mật khẩu
        public static int Reset_Pass(string pTenDN, string pPass)
        {
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.LTWNCConn);
            _Sqlconn.Open();

            String str = "UPDATE NguoiDung SET MatKhau = '" + pPass + "' WHERE ID_DN ='" + pTenDN + "'";
            SqlCommand cmd = new SqlCommand(str, _Sqlconn);
            SqlDataAdapter da = new SqlDataAdapter();
            int x = cmd.ExecuteNonQuery();
            _Sqlconn.Close();
            if (x != 0)
                return 1;// Thành công
            return 0;// Không thành công
        }

    }
}
