using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BanHang_BLLDAL
    {
        CHTLDataContext CHTL = new CHTLDataContext();

        public KHACHHANG get_DataKH(int id)
        {
            return CHTL.KHACHHANGs.SingleOrDefault(t => t.ID_KH.Equals(id));
        }

        public bool insert_KhachHang(string ten, string gioitinh, string diachi, string sdt, int diem)
        {
            try
            {
                KHACHHANG d = CHTL.KHACHHANGs.SingleOrDefault(t => t.SDT.Equals(sdt));

                if (d == null)
                {
                    KHACHHANG insert = new KHACHHANG();
                    insert.TENKH = ten;
                    insert.SDT = sdt;
                    insert.GIOITINH = gioitinh;
                    insert.DIACHI = diachi;
                    insert.DIEM = diem;
                    CHTL.KHACHHANGs.InsertOnSubmit(insert);
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

        public bool update_KhachHang(int id, int diem)
        {
            try
            {
                KHACHHANG d = CHTL.KHACHHANGs.SingleOrDefault(t => t.ID_KH.Equals(id));

                if (d != null)
                {
                    d.DIEM += diem;
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

        public IQueryable get_DataKM()
        {
            return CHTL.KHUYENMAIs.Select(t => t);
        }

        public IQueryable get_DataCTKM(int id)
        {
            return CHTL.CHITIETKHUYENMAIs.Select(t => t).Where(t => t.ID_KM.Equals(id));
        }

        public bool insert_KhuyenMai(string tenkm, DateTime ngaybd, DateTime ngaykt, string chuthich)
        {
            try
            {
                KHUYENMAI d = CHTL.KHUYENMAIs.SingleOrDefault(t => t.TENKHUYENMAI.Equals(tenkm));

                if (d == null)
                {
                    KHUYENMAI insert = new KHUYENMAI();
                    insert.TENKHUYENMAI = tenkm;
                    insert.NGAYBD = ngaybd;
                    insert.NGAYKT = ngaykt;
                    insert.CHUTHICH = chuthich;
                    CHTL.KHUYENMAIs.InsertOnSubmit(insert);
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

        public bool insert_HoaDon(DateTime ngaylap, string idnv, int idkh, int idkm, int tongtien)
        {
            try
            {
                HOADON insert = new HOADON();
                insert.NGAYLAP = ngaylap;
                insert.ID_DN = idnv;
                if (idkh > 0)
                {
                    insert.ID_KH = idkh;
                }
                if (idkm > 0)
                {
                    insert.ID_KM = idkm;
                }
                
                insert.TONGTIEN = tongtien;
                CHTL.HOADONs.InsertOnSubmit(insert);
                CHTL.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool insert_CTHoaDon(int idhd, int idsp, int soluong, float dongia, float thanhtien)
        {
            try
            {
                CHITIETHOADON insert = new CHITIETHOADON();
                insert.ID_HD = idhd;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                insert.DONGIA = dongia;
                insert.THANHTIEN = thanhtien;
                CHTL.CHITIETHOADONs.InsertOnSubmit(insert);
                CHTL.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public HOADON get_DataHDCuoi()
        {
            HOADON hd = CHTL.HOADONs.OrderByDescending(t => t.ID_HD).FirstOrDefault();
            return hd;
        }

        public bool update_SanPham(int id, int soluong)
        {
            try
            {
                SANPHAM d = CHTL.SANPHAMs.SingleOrDefault(t => t.ID_SP.Equals(id));

                if (d != null)
                {
                    d.SOLUONG -= soluong;
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
