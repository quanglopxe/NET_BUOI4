using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td = new ToaDo(5,5);
            HinhTron ht = new HinhTron(td, 10.5);
            Console.WriteLine("Hinh tron co tam {0} voi ban kinh {1} co dien tich va chu vi lan luot la {2} va {3}", td.ToString(), ht.BanKinh, ht.TinhDienTich(), ht.TinhChuVi());
            Console.ReadLine();
        }
    }
}
