using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai1
{
    class ChuyenXe
    {
        protected string maSoChuyen;

        public string MaSoChuyen
        {
            get { return maSoChuyen; }
            set { maSoChuyen = value; }
        }
        protected string hoTenTaiXe;

        public string HoTenTaiXe
        {
            get { return hoTenTaiXe; }
            set { hoTenTaiXe = value; }
        }
        protected int soXe;

        public int SoXe
        {
            get { return soXe; }
            set { soXe = value; }
        }
        protected double doanhThu;

        public double DoanhThu
        {
          get { return doanhThu; }
          set { doanhThu = value; }
        }

        public ChuyenXe()
            : this("SaiGon", "Nguyen Van Hung", 21, 375.500)
        { }
        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, int soXe, double doanhThu)
        {
            this.maSoChuyen = maSoChuyen;
            this.hoTenTaiXe = hoTenTaiXe;
            this.soXe = soXe;
            this.doanhThu=doanhThu;
        }
        public virtual double TinhDoanhThu()
        {
            return DoanhThu;
        }
    }
}
