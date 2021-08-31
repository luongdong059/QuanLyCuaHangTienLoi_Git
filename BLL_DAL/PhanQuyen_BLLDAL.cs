using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhanQuyen_BLLDAL
    {
        CHTLDataContext CHTL = new CHTLDataContext();

        public IQueryable get_Data_Nhom(string iddn)
        {
            return CHTL.NGUOIDUNGNHOMNGUOIDUNGs.Select(t => t).Where(t => t.ID_DN.Equals(iddn));
        }

        public IQueryable get_Data_ManHinh(string idnhom)
        {
            return CHTL.PHANQUYENs.Select(t => t).Where(t => t.ID_NHOM.Equals(idnhom));
        }


        public bool check_dangnhap(string pUser, string pPass)
        {
            NGUOIDUNG nd = CHTL.NGUOIDUNGs.SingleOrDefault(t => t.ID_DN.Equals(pUser) && t.MATKHAU.Equals(pPass));
            if (nd == null)
            {
                return false;
            }
            else
                return true;
        }

        public bool check_hoatdong(string pUser)
        {
            NGUOIDUNG nd = CHTL.NGUOIDUNGs.SingleOrDefault(t => t.ID_DN.Equals(pUser));
            if (nd != null || nd.ID_DN != null)
            {
                if (nd.TINHTRANG.Equals(true))
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }
    }
}
