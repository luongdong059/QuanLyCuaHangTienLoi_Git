using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.Ado
{
    public class Model_KNN
    {
        //Khai báo 
        int m, k = 5;

        ThongTin[] data = new ThongTin[1000];
        ThongTin[] data_khoangcach = new ThongTin[1000];
        ThongTin[] data_k = new ThongTin[100];

        //Hàm tính khoảng cách
        public int tinhKhoangCach(ThongTin data, ThongTin input)
        {
            int tuoi;
            tuoi = (int)Math.Pow(data.Tuoi - input.Tuoi, 2);
            return (int)Math.Sqrt(tuoi);
        }

        //Hàm lấy lấy khoảng cách của từng dòng dữ liệu
        public void layGiaTri(ThongTin[] data,int n, ThongTin input, ThongTin[] output)
        {
            m = 0;
            for (int i = 0; i < n; i++)
            {
                ThongTin a = new ThongTin();
                a.Tuoi = tinhKhoangCach(data[i], input);
                a.Theloai = data[i].Theloai;
                output[m] = a;
                m++;
            }
        }

        //Hàm sắp xếp tăng
        public void sapxep_tang(ThongTin[] output)
        {
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (output[j].Tuoi < output[i].Tuoi)
                    {
                        ThongTin tam;
                        tam = output[i];
                        output[i] = output[j];
                        output[j] = tam;
                    }
                }
            }
        }

        //Hàm lấy k giá trị 
        public void lay_k_giatri(ThongTin[] output, ThongTin[] gt_output)
        {
            for (int i = 0; i < k; i++)
            {
                gt_output[i] = output[i];
            }
        }

        //Hàm đếm số lần xuất hiện của phần tử
        public int dem(ThongTin[] gt_output, ThongTin a)
        {
            int dem = 0;
            for (int i = 0; i < k; i++)
            {
                if (string.Compare(gt_output[i].Theloai, a.Theloai, true) == 0)
                {
                    dem++;
                }
            }
            return dem;
        }
        //Hàm kiểm tra nhãn dán
        public string kiemtra_nhan(ThongTin[] gt_output)
        {
            int max = dem(gt_output, gt_output[0]), vt = 0;
            for (int i = 1; i < k; i++)
            {
                if (dem(gt_output, gt_output[i]) > max)
                {
                    max = dem(gt_output, gt_output[i]);
                    vt = i;
                }
            }
            return gt_output[vt].Theloai;
        }
    }
}
