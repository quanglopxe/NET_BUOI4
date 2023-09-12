using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai1
{
    class ChuyenXeNgoaiThanh:ChuyenXe
    {
        private string noiDen;

        public string NoiDen
        {
            get { return noiDen; }
            set { noiDen = value; }
        }
        private int soNgayDiDuoc;

        public int SoNgayDiDuoc
        {
            get { return soNgayDiDuoc; }
            set { soNgayDiDuoc = value; }
        }
        public ChuyenXeNgoaiThanh():base()
        {
            this.noiDen = "Ha Tinh";
            this.soNgayDiDuoc = 1;
        }
        public ChuyenXeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, int soXe, string noiDen, int soNgayDiDuoc,double doanhThu):base(maSoChuyen,hoTenTaiXe,soXe,doanhThu)
        {
            this.noiDen = noiDen;
            this.soNgayDiDuoc = soNgayDiDuoc;
        }
        public override double TinhDoanhThu()
        {
            return base.TinhDoanhThu();
        }
    }
}
