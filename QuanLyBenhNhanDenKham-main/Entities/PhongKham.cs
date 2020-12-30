using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhanDenKham.Entities
{
    class PhongKham
    {
        private string maphongkham, tenphongkham, loaiphong;
        public PhongKham(string maphongkham, string tenphongkham, string loaiphong)
        {
            this.maphongkham = maphongkham;
            this.tenphongkham = tenphongkham;
            this.loaiphong = loaiphong;
        }
        override
            public string ToString()
        {
            return maphongkham + "#" + tenphongkham + "#" + loaiphong;
        }
        public string Maphongkham { get => maphongkham; set => maphongkham = value; }
        public string Tenphongkham { get => tenphongkham; set => tenphongkham = value; }
        public string Loaiphong { get => loaiphong; set => loaiphong = value; }
    }
}
