using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai7
{
    class HinhTron
    {
        private ToaDo _tam;
        private double _banKinh;
        public HinhTron()
        { }
        public HinhTron(ToaDo _tam,double _banKinh)
        {
            this._tam = _tam;
            this._banKinh = _banKinh;
        }
        public ToaDo Tam
        {
            get { return _tam; }
            set { _tam = value; }
        }
        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }
        public double TinhChuVi()
        {
            return BanKinh * 2 * Math.PI;
        }
        public double TinhDienTich()
        {
            return BanKinh * BanKinh * Math.PI;
        }
    }
}
