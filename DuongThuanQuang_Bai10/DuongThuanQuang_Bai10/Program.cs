using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(1, new DateTime(2015, 9, 10));
            order.addLineItem(new Product("Nuoc tuong", "sp4", 8000), 10);
            order.addLineItem(new Product("Gao", "sp1", 18000), 5);
            order.addLineItem(new Product("Duong", "sp3", 10000), 1);
            order.addLineItem(new Product("Gao", "sp1", 18000), 1);

            Console.WriteLine("Ma hoa don: {0}", order.OrderID);
            Console.WriteLine("Ngay lap hoa don: {0}", order.OrderDate);
            Console.WriteLine("{0,-5}|{1, -10}|{2, -20}|{3,10}|{4,10}|{5,20}", "STT", "Ma SP", "Mo ta", "Don gia", "So luong", "Thanh tien");
            int count = 1;
            foreach (OrderDetail Item in order.LineItems)
            {
                Console.WriteLine(string.Format("{0,-5}|{1, -10}|{2, -20}|{3,10}|{4,10}|{5,16} VNĐ", count, Item.Product.ProductID, Item.Product.Description, Item.Product.Price, Item.Quantity, Item.CalcTotalPrice()));
                count++;
            }
            Console.WriteLine("Tong tien thanh toan: {0} VNĐ", order.CalcTotalCharge());
            Console.ReadLine();
        }
    }
}
