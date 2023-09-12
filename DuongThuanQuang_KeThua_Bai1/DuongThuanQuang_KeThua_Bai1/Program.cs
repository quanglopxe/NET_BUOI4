using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ChuyenXe> dsChuyenXe = new List<ChuyenXe>();
            ChuyenXeNoiThanh noiThanh1 = new ChuyenXeNoiThanh("KienGiang46", "Ngo Tuan Vinh", 59, 42, 40, 250.000);
            ChuyenXeNoiThanh noiThanh2 = new ChuyenXeNoiThanh("LongAn22", "Ha Van Thai", 51, 72, 50, 350.000);
            ChuyenXeNgoaiThanh ngoaiThanh1 = new ChuyenXeNgoaiThanh("TPCHM", "Ho Van Kiet", 36, "Quan 12", 1, 150.000);
            ChuyenXeNgoaiThanh ngoaiThanh2 = new ChuyenXeNgoaiThanh("TPHCM", "Nguyen Thi Hong", 24, "Go Vap", 2, 700.000);
            dsChuyenXe.Add(noiThanh1);
            dsChuyenXe.Add(noiThanh2);
            dsChuyenXe.Add(ngoaiThanh1);
            dsChuyenXe.Add(ngoaiThanh2);

            double tongDoanhThuForAll = 0;
            double tongDoanhThuNoiThanh = 0;
            double tongDoanhThuNgoaiThanh = 0;
            //tong doanh thu cho tat ca cac chuyen xe:
            foreach(ChuyenXe chuyenXe in dsChuyenXe)
            {
                tongDoanhThuForAll += chuyenXe.TinhDoanhThu();
            }
            foreach(ChuyenXe chuyenXe in dsChuyenXe)
            {
                if (chuyenXe is ChuyenXeNoiThanh)
                    tongDoanhThuNoiThanh += chuyenXe.TinhDoanhThu();
                else if(chuyenXe is ChuyenXeNgoaiThanh)
                    tongDoanhThuNgoaiThanh += chuyenXe.TinhDoanhThu();
            }
            Console.WriteLine("Tong doanh thu cua tat ca cac chuyen xe: {0}", tongDoanhThuForAll);
            Console.WriteLine("Tong doanh thu cua chuyen xe noi thanh: {0}", tongDoanhThuNoiThanh);
            Console.WriteLine("Tong doanh thu cua chuyen xe ngoai thanh {0}", tongDoanhThuNgoaiThanh);
            Console.ReadLine();
        }
    }
}
