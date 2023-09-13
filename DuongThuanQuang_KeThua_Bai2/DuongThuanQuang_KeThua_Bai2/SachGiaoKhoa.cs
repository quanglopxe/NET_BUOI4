using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai2
{
    class SachGiaoKhoa:Sach
    {
        private string tinhTrang;

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public override double TinhThanhTien()
        {
            if (tinhTrang == "moi")
                return SoLuong * DonGia;
            else
                return SoLuong * DonGia * 0.5;
        }
        public SachGiaoKhoa():base()
        {
            this.tinhTrang = "moi";
        }
        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, string tinhTrang):base(maSach,ngayNhap,donGia,soLuong,nhaXuatBan)
        {
            this.tinhTrang = tinhTrang;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Tinh trang: {0}", tinhTrang);
        }
    }
}
