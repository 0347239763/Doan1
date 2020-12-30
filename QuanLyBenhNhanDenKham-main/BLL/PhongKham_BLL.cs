using QuanLyBenhNhanDenKham.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
namespace QuanLyBenhNhanDenKham.BLL
{
    class PhongKham_BLL : ChucNang_IF
    {
        public PhongKham find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            PhongKham result = null;
            foreach (PhongKham PhongKham in arrayList)
            {
                if (keyword.Equals(PhongKham.Maphongkham) || keyword.Equals(PhongKham.Tenphongkham))
                {
                    result = PhongKham;
                }
            }
            return result;

        }
        public void display(PhongKham PhongKham)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", PhongKham.Maphongkham, PhongKham.Tenphongkham, PhongKham.Loaiphong);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "Mã phòng khám", "Tên phòng khám", "Loại phòng khám");
            foreach (PhongKham PhongKham in arrayList)
            {
                display(PhongKham);
            }
        }

        public void Nhap(ArrayList arrayList)
        {

            Console.WriteLine("Nhập mã phòng khám");
            string mapk = Console.ReadLine();
            Console.WriteLine("Nhập tên phòng khám");
            string tenpk = Console.ReadLine();
            Console.WriteLine("Nhập loại phòng");
            string loaiphong = Console.ReadLine();
           
            arrayList.Add(new PhongKham(mapk, tenpk, loaiphong));
        }

        public void Sua(ArrayList arrayList)
        {

            PhongKham kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã phòng khám");
                kq.Maphongkham = Console.ReadLine();
                Console.WriteLine("Nhập tên phòng khám");
                kq.Tenphongkham = Console.ReadLine();
                Console.WriteLine("Nhập loại phòng");
                kq.Loaiphong = Console.ReadLine();

                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            PhongKham kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|", "Mã phòng khám", "Tên phòng khám", "Loại phòng khám"); 
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            PhongKham kq = find(arrayList);
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
