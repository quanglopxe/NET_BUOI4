using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai2
{
    class SachThamKhao:Sach
    {
        private double _thue;

        public double Thue
        {
            get { return _thue; }
            set { _thue = value; }
        }
        public override double TinhThanhTien()
        {
            return base.TinhThanhTien() + Thue;
        }
        public SachThamKhao():base()
        {
            this._thue = 0.1;
        }
        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double _thue):base(maSach,ngayNhap,donGia,soLuong,nhaXuatBan)
        {
            this._thue = _thue;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("Thue: {0}", _thue);

        }
    }
}
