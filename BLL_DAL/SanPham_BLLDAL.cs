using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SanPham_BLLDAL
    {
        CHTLDataContext CHTL = new CHTLDataContext();

        public IQueryable get_DataSP()
        {
            return CHTL.SANPHAMs.Select(t => t);
        }
      
        public IQueryable get_DataSP_LSP(int id)
        {
            //var sanpham = from kh in CHTL.SANPHAMs
            //              where kh.ID_LSP == id
            //              select kh;
            //return sanpham.ToList();

            return CHTL.SANPHAMs.Select(t => t).Where(t => t.ID_LSP == id);
        }

        public IQueryable<LOAISANPHAM> get_DataLSP()
        {
            return CHTL.LOAISANPHAMs.Select(t => t);
        }

        public bool insert_SanPham(string tensp, string dvt, int id_lsp, string hinh, int dongia)
        {
            try
            {
                SANPHAM d = CHTL.SANPHAMs.SingleOrDefault(t => t.TENSP.Equals(tensp));

                if (d == null)
                {
                    SANPHAM insert = new SANPHAM();
                    insert.TENSP = tensp;
                    insert.DVT = dvt;
                    insert.ID_LSP = id_lsp;
                    insert.HINHANH = hinh;
                    insert.DONGIA = dongia;
                    CHTL.SANPHAMs.InsertOnSubmit(insert);
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

        public bool update_SanPham(int id, string tensp, string dvt, string hinh, int dongia)
        {
            try
            {
                SANPHAM d = CHTL.SANPHAMs.SingleOrDefault(t => t.ID_SP.Equals(id));

                if (d != null)
                {
                    d.TENSP = tensp;
                    d.DVT = dvt;
                    d.HINHANH = hinh;
                    d.DONGIA = dongia;
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

        public List<SANPHAM> get_DataSP_Search(string tensp)
        {
            CHTLDataContext sqlObj = new CHTLDataContext();
            var sanpham = from sp in sqlObj.SANPHAMs
                          where sp.TENSP.Contains(tensp)
                          select (sp);
            return sanpham.ToList();
        }

        public bool get_TenSP(string ten)
        {
            try
            {
                SANPHAM a = CHTL.SANPHAMs.SingleOrDefault(t => t.TENSP.Equals(ten));
                if (a == null)
                {
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
