using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai10
{
    class Order
    {
        private int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        private List<OrderDetail> lineItems;

        internal List<OrderDetail> LineItems
        {
            get { return lineItems; }
            set { lineItems = value; }
        }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public Order(int orderID, DateTime orderDate)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.lineItems=new List<OrderDetail>();
            this.count = 4;
        }
        public void addLineItem(Product p, int x)
        {
            lineItems.Add(new OrderDetail(p, x));
        }
        public double CalcTotalCharge()
        {
            double thanhTien = 0;
            foreach(OrderDetail item in lineItems)
            {
                thanhTien += item.CalcTotalPrice();
            }
            return thanhTien;
        }
    }
}
