using QuanLyBenhNhanDenKham.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
namespace QuanLyBenhNhanDenKham.BLL
{
    class BenhNhan_BLL : ChucNang_IF
    {
        public BenhNhan find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            BenhNhan result = null;
            foreach (BenhNhan BenhNhan in arrayList)
            {
                if (keyword.Equals(BenhNhan.Mabn) || keyword.Equals(BenhNhan.Hoten))
                {
                    result = BenhNhan;
                }
            }
            return result;

        }
        public void display(BenhNhan BenhNhan)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", BenhNhan.Mabn, BenhNhan.Hoten, BenhNhan.Gioitinh, BenhNhan.Sdt, BenhNhan.Ngaysinh, BenhNhan.Email,BenhNhan.Dantoc);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "Mã bệnh nhân", "Họ tên", "Giới tính", "Số điện thoại", "Ngày sinh", "Email","Dân tộc");
            foreach (BenhNhan BenhNhan in arrayList)
            {
                display(BenhNhan);
            }
        }

        public void Nhap(ArrayList arrayList)
        {

            Console.WriteLine("Nhập mã bệnh nhân");
            string mabn = Console.ReadLine();
            Console.WriteLine("Nhập họ tên");
            string hoten = Console.ReadLine();
            Console.WriteLine("Nhập giới tính");
            string gioitinh = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            string sdt = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh");
            string ngaysinh = Console.ReadLine();
            Console.WriteLine("Nhập email");
            string email = Console.ReadLine();
            Console.WriteLine("Nhập dân tộc");
            string dantoc = Console.ReadLine();
            arrayList.Add(new BenhNhan(mabn,hoten,gioitinh,sdt,ngaysinh,email,dantoc));
        }

        public void Sua(ArrayList arrayList)
        {

            BenhNhan kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã bệnh nhân");
                kq.Mabn = Console.ReadLine();
                Console.WriteLine("Nhập họ tên");
                kq.Hoten = Console.ReadLine();
                Console.WriteLine("Nhập giới tính");
                kq.Gioitinh = Console.ReadLine();
                Console.WriteLine("Nhập số điện thoại");
                kq.Sdt = Console.ReadLine();
                Console.WriteLine("Nhập ngày sinh");
                kq.Ngaysinh = Console.ReadLine();
                Console.WriteLine("Nhập email");
                kq.Email = Console.ReadLine();
                Console.WriteLine("Nhập dân tộc");
                kq.Dantoc = Console.ReadLine();
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            BenhNhan kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", "Mã bệnh nhân", "Họ tên", "Giới tính", "Số điện thoại", "Ngày sinh", "Email", "Dân tộc");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            BenhNhan kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                arrayList.Remove(kq);
                Console.WriteLine("Xóa thành công");
            }
        }
    }
}
