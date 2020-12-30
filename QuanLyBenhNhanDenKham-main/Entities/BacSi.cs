using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhanDenKham.Entities
{
    class BacSi
    {
        private string mabs, hoten, gioitinh, chuyenmon, tenphongkham, sdt;
        public BacSi(string mabs,string hoten,string gioitinh,string chuyenmon,string tenphongkham,string sdt)
        {
            this.mabs = mabs;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.chuyenmon = chuyenmon;
            this.tenphongkham = tenphongkham;
            this.sdt = sdt;
        }
        override
            public string ToString()
        {
            return mabs + "#" + hoten + "#" + gioitinh + "#" + chuyenmon + "#" + tenphongkham + "#" + sdt;
        }
        public string Mabs { get => mabs; set => mabs = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Chuyenmon { get => chuyenmon; set => chuyenmon = value; }
        public string Tenphongkham { get => tenphongkham; set => tenphongkham = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
    }
}
