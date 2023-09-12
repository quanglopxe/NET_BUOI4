using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai1
{
    class ChuyenXeNoiThanh:ChuyenXe
    {
        private int soTuyen;

        public int SoTuyen
        {
            get { return soTuyen; }
            set { soTuyen = value; }
        }
        private int soKm;

        public int SoKm
        {
            get { return soKm; }
            set { soKm = value; }
        }
        public ChuyenXeNoiThanh():base()
        {
            this.soTuyen = 23;
            this.soKm = 58;
        }
        public ChuyenXeNoiThanh(string maSoChuyen, string hoTenTaiXe, int soXe, int soTuyen, int soKm, double doanhThu):base(maSoChuyen,hoTenTaiXe,soXe,doanhThu)
        {
            this.soTuyen = soTuyen;
            this.soKm = soKm;
        }
        public override double TinhDoanhThu()
        {
            return base.TinhDoanhThu();
        }
    }
}
