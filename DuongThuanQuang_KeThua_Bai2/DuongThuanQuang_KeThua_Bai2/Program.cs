using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sach> dsSach = new List<Sach>();
            SachGiaoKhoa sgk1 = new SachGiaoKhoa("AV010", new DateTime(2023, 8, 14), 72.000, 40, "Mai Lan Huong", "moi");
            SachGiaoKhoa sgk2 = new SachGiaoKhoa("T010", new DateTime(2023, 8, 15), 55.000, 60, "Bo GD & DT", "moi");
            SachGiaoKhoa sgk3 = new SachGiaoKhoa("NV010", new DateTime(2023, 8, 20), 48.000, 50, "Bo GD & DT", "cu");

            SachThamKhao stk1 = new SachThamKhao("TDPB", new DateTime(2023, 8, 22), 60.000, 20, "Nguyen Van An", 0.05);
            SachThamKhao stk2 = new SachThamKhao("KNGT", new DateTime(2023, 8, 25), 40.000, 15, "Ho Ngoc Thanh", 0.05);
            SachThamKhao stk3 = new SachThamKhao("DVKH", new DateTime(2023, 9, 7), 75.000, 30, "Du Kim Thi", 0.05);

            dsSach.Add(sgk1);
            dsSach.Add(sgk2);
            dsSach.Add(sgk3);
            dsSach.Add(stk1);
            dsSach.Add(stk2);
            dsSach.Add(stk3);

            double toTalForSGK = 0;
            double toTalForSTK = 0;
            double priceAverage = 0;
            foreach(Sach s in dsSach)
            {
                if(s is SachGiaoKhoa)
                    toTalForSGK += s.TinhThanhTien();
                else if (s is SachThamKhao)
                    toTalForSTK += s.TinhThanhTien();
            }
            Console.WriteLine("Tong thanh tien cua cac sach giao khoa: {0}", toTalForSGK);
            Console.WriteLine("Tong thanh tien cua cac sach tham khao: {0}", toTalForSTK);
            int soLuongSach = 0;
            double tongDonGiaSTK = 0;
            foreach(Sach s in dsSach)
            {
                if(s is SachThamKhao)
                {
                    soLuongSach++;
                    tongDonGiaSTK += s.DonGia;
                }
            }
            priceAverage = tongDonGiaSTK / soLuongSach;
            Console.WriteLine("Trung binh cong don gia cua cac sach tham khao la: {0}", priceAverage);

            Console.WriteLine("nhap ten nha xuat ban can tim: ");
            string tenNXB = Console.ReadLine();
            Console.WriteLine("Cac sach giao khoa cua nha xuat ban {0}:", tenNXB);
            foreach(Sach s in dsSach)
            {
                if (s is SachGiaoKhoa && s.NhaXuatBan == tenNXB)
                    s.XuatThongTin();
            }
            Console.ReadLine();
        }
    }
}
