using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhanDenKham.Entities
{
    class PhieuKham
    {
        private string mapk, ngaykham, mabs, mabn, lydo, chuandoan, ketluan;
        private double tongtien;
        public PhieuKham(string mapk,string ngaykham,string mabs,string mabn,string lydo,string chuandoan,string ketluan,double tongtien)
        {
            this.mapk = mapk;
            this.ngaykham = ngaykham;
            this.mabs = mabs;
            this.mabn = mabn;
            this.lydo = lydo;
            this.chuandoan = chuandoan;
            this.ketluan = ketluan;
            this.tongtien = tongtien;
        }
        override
            public string ToString()
        {
            return mapk + "#" + ngaykham + "#" + mabs + "#" + mabn + "#" + lydo + "#" + chuandoan + "#" + ketluan + "#" + tongtien;
        }
        public string Mapk { get => mapk; set => mapk = value; }
        public string Ngaykham { get => ngaykham; set => ngaykham = value; }
        public string Mabs { get => mabs; set => mabs = value; }
        public string Mabn { get => mabn; set => mabn = value; }
        public string Lydo { get => lydo; set => lydo = value; }
        public string Chuandoan { get => chuandoan; set => chuandoan = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
        public string Ketluan { get => ketluan; set => ketluan = value; }
    }
}
