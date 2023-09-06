using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongThuanQuang_Bai7
{
    class ToaDo
    {
        private string _ten;
        private float x;
        private float y;
        public ToaDo()
        {
            this._ten = "A";
            this.x = 0;
            this.y = 0;
        }
        public ToaDo(float x, float y)
        {
            this._ten = "O";
            this.x = x;
            this.y = y;
        }
        //public string Ten
        //{
        //    get { return ten; }
        //    set { ten = value; }
        //}
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public string ToString()
        {
            return _ten+"("+x+","+y+")";
        }
    }
}
