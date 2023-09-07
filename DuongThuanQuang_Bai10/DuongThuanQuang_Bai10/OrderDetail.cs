using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai10
{
    class OrderDetail
    {
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private Product _product;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public OrderDetail(Product _product, int _quantity)
        {
            this._product = _product;
            this._quantity = _quantity;
        }
        public double CalcTotalPrice()
        {
            return Quantity * Product.Price;
        }
        
    }
}
