using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_KeThua_Bai2
{
    class Sach
    {
        protected string maSach;

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }
        protected DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        protected double donGia;

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        protected int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        protected string nhaXuatBan;

        public string NhaXuatBan
        {
            get { return nhaXuatBan; }
            set { nhaXuatBan = value; }
        }
        public Sach():this("T05",new DateTime(2023,5,12),45.000,50,"Nguyen Van A")
        { }
        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
        }
        public virtual double TinhThanhTien()
        {
            return soLuong * donGia;
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine("Ma sach: {0}", maSach);
            Console.WriteLine("Ngay nhap: {0}", ngayNhap);
            Console.WriteLine("Don gia: {0}", donGia);
            Console.WriteLine("SoLuong: {0}", soLuong);
            Console.WriteLine("Nha xuat ban: {0}", nhaXuatBan);

        }
    }
}
