using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class NguoiDung_BLLDAL
    {
        CHTLDataContext CHTL = new CHTLDataContext();

        public NGUOIDUNG get_Info(string id)
        {
            return CHTL.NGUOIDUNGs.SingleOrDefault(t => t.ID_DN.Equals(id));
        }

        public IQueryable get_DanhMucND()
        {
            return CHTL.NGUOIDUNGs.Select(t => t);
        }

        public bool update_Info(string id, string ten, string sdt, string diachi, DateTime ngaysinh, string gioitinh)
        {
            try
            {
                NGUOIDUNG nguoidung = CHTL.NGUOIDUNGs.SingleOrDefault(t => t.ID_DN.Equals(id));
                if (nguoidung != null)
                {
                    nguoidung.TEN = ten;
                    nguoidung.SDT = sdt;
                    nguoidung.DIACHI = diachi;
                    nguoidung.NGAYSINH = ngaysinh;
                    nguoidung.GIOITINH = gioitinh;
                    CHTL.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
