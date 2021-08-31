using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Ado
{
    public class GioHang
    {
        int id, soluong;
        float dongia, thanhtien;
        public GioHang() { }
        public GioHang(int id, int soluong, float dongia, float thanhtien)
        {
            this.Id = id;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien;
        }

        public int Id { get => id; set => id = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
