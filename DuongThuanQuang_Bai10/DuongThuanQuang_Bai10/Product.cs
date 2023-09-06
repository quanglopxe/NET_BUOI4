using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai10
{
    class Product
    {
        private string _description;
        private string productID;
        private double _price;
        public Product():this("gao","sp00",20000)
        { }
        public Product(string _description, string productID, double _price)
        {
            this._description = _description;
            this.productID = productID;
            this._price = _price;
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public 
    }
}
