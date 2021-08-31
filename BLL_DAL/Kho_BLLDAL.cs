using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Kho_BLLDAL
    {
        CHTLDataContext CHTL = new CHTLDataContext();
        public IQueryable get_DataDatHang()
        {
            return CHTL.PHIEUDATs.Select(t => t);
        }

        public IQueryable get_DataNCC()
        {
            return CHTL.NHACUNGCAPs.Select(t => t);
        }

        public PHIEUDAT get_DataPDCuoi()
        {
            PHIEUDAT hd = CHTL.PHIEUDATs.OrderByDescending(t => t.ID_PD).FirstOrDefault();
            return hd;
        }

        public PHIEUNHAP get_DataPNCuoi()
        {
            PHIEUNHAP hd = CHTL.PHIEUNHAPs.OrderByDescending(t => t.ID_PN).FirstOrDefault();
            return hd;
        }

        public IQueryable get_DataSP_NCC(int id)
        {
            return CHTL.DANHMUCSANPHAMs.Select(t => t).Where(t => t.ID_NCC == id);
        }

        public IQueryable get_DataSP_CTPD(int id)
        {
            return CHTL.CHITIETPHIEUDATs.Select(t => t).Where(t => t.ID_PD == id);
        }

        public IQueryable get_DataSP_CTPN(int id)
        {
            return CHTL.CHITIETPHIEUNHAPs.Select(t => t).Where(t => t.ID_PD == id);
        }

        public bool insert_PhieuDat(int idncc,string idnv, DateTime ngaynhap, int tongtien)
        {
            try
            {
                PHIEUDAT insert = new PHIEUDAT();
                insert.ID_NCC = idncc;
                insert.ID_DN = idnv;
                insert.NGAYLAP = ngaynhap;
                insert.TONGTIEN = tongtien;
                insert.TINHTRANG = false;
                CHTL.PHIEUDATs.InsertOnSubmit(insert);
                CHTL.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool insert_CTPD(int idpd, int idsp, int soluong, int thanhtien)
        {
            try
            {
                CHITIETPHIEUDAT insert = new CHITIETPHIEUDAT();
                insert.ID_PD = idpd;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                insert.THANHTIEN = thanhtien;
                CHTL.CHITIETPHIEUDATs.InsertOnSubmit(insert);
                CHTL.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool insert_LoaiSP(string tensp)
        {
            try
            {
                LOAISANPHAM d = CHTL.LOAISANPHAMs.SingleOrDefault(t => t.TENLOAISANPHAM.Equals(tensp));

                if (d == null)
                {
                    LOAISANPHAM insert = new LOAISANPHAM();
                    insert.TENLOAISANPHAM = tensp;
                    CHTL.LOAISANPHAMs.InsertOnSubmit(insert);
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


        public bool insert_NCC(string ten, string diachi, string sdt)
        {
            try
            {
                NHACUNGCAP d = CHTL.NHACUNGCAPs.SingleOrDefault(t => t.TENNCC.Equals(ten));

                if (d == null)
                {
                    NHACUNGCAP insert = new NHACUNGCAP();
                    insert.TENNCC = ten;
                    insert.DIACHI = diachi;
                    insert.SDT = sdt;
                    CHTL.NHACUNGCAPs.InsertOnSubmit(insert);
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

        public bool insert_SP_NCC(int idncc, int idsp, int giaban)
        {
            try
            {
                DANHMUCSANPHAM d = CHTL.DANHMUCSANPHAMs.SingleOrDefault(t => t.ID_SP.Equals(idsp) && t.ID_NCC.Equals(idncc));

                if (d == null)
                {
                    DANHMUCSANPHAM insert = new DANHMUCSANPHAM();
                    insert.ID_NCC = idncc;
                    insert.ID_SP = idsp;
                    insert.GiaBan= giaban;
                    CHTL.DANHMUCSANPHAMs.InsertOnSubmit(insert);
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

        public bool insert_PhieuNhap(int idncc, string idnv, DateTime ngaynhap, int tongtien)
        {
            try
            {
                PHIEUNHAP insert = new PHIEUNHAP();
                insert.ID_NCC = idncc;
                insert.ID_DN = idnv;
                insert.NGAYLAP = ngaynhap;
                insert.TONGTIEN = tongtien;
                CHTL.PHIEUNHAPs.InsertOnSubmit(insert);
                CHTL.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool insert_CTPN(int idpn, int idpd, int idsp, int soluong, int gianhap, int giaban, int thanhtien)
        {
            try
            {
                CHITIETPHIEUNHAP insert = new CHITIETPHIEUNHAP();
                SANPHAM sp = CHTL.SANPHAMs.SingleOrDefault(t => t.ID_SP.Equals(idsp));
                insert.ID_PN = idpn;
                insert.ID_PD = idpd;
                insert.ID_SP = idsp;
                insert.SOLUONG = soluong;
                insert.DONGIANHAP = gianhap;
                insert.DONGIABAN = giaban;
                insert.THANHTIEN = thanhtien;
                CHTL.CHITIETPHIEUNHAPs.InsertOnSubmit(insert);

                if (sp.SOLUONG == null)
                {
                    sp.SOLUONG = soluong;
                }
                else
                    sp.SOLUONG = sp.SOLUONG + soluong;
                CHTL.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public int dem_CTPN(int idpd)
        {
            return CHTL.CHITIETPHIEUNHAPs.Where(t => t.ID_PD == idpd).Count();
        }

        public int dem_CTPD(int idpd)
        {
            return CHTL.CHITIETPHIEUDATs.Where(t => t.ID_PD == idpd).Count();
        }

        public bool update_PhieuDat(int idpd)
        {
            try
            {
                PHIEUDAT d = CHTL.PHIEUDATs.SingleOrDefault(t => t.ID_PD.Equals(idpd));

                if (d != null)
                {
                    d.TINHTRANG = true;
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
