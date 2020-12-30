using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBenhNhanDenKham.Entities
{
    class BenhNhan
    {
        private string mabn, hoten, gioitinh,sdt,ngaysinh,email,dantoc;
        public BenhNhan(string mabn,string hoten,string gioitinh,string sdt,string ngaysinh,string email,string dantoc)
        {
            this.mabn = mabn;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.ngaysinh = ngaysinh;
            this.email = email;
            this.dantoc = dantoc;
        }
        override
            public string ToString()
        {
            return mabn + "#" + hoten + "#" + gioitinh + "#" + sdt + "#" + ngaysinh + "#" + email + "#" + dantoc;
        }
        public string Mabn { get => mabn; set => mabn = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Dantoc { get => dantoc; set => dantoc = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
    }
}
