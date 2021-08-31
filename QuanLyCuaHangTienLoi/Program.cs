using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    static class Program
    {
        public static View.frmError errorserver = null;
        public static View.frmTrangChu mainForm = null;
        public static View.frmDangNhap login = null;
        public static View.frmDoiMatKhau reset= null;
        public static View.frmBanHang banhang = null;
        public static View.frmQuenMatKhau reset_pass = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new View.frmTrangChu();
            reset = new View.frmDoiMatKhau();
            login = new View.frmDangNhap();
            Application.Run(login);
        }
    }
}
