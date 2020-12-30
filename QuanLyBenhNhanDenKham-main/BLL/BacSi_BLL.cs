using QuanLyBenhNhanDenKham.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
namespace QuanLyBenhNhanDenKham.BLL
{
    class BacSi_BLL : ChucNang_IF
    {
        public BacSi find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            BacSi result = null;
            foreach (BacSi BacSi in arrayList)
            {
                if (keyword.Equals(BacSi.Mabs) || keyword.Equals(BacSi.Hoten))
                {
                    result = BacSi;
                }
            }
            return result;

        }
        public void display(BacSi BacSi)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", BacSi.Mabs, BacSi.Hoten, BacSi.Gioitinh, BacSi.Chuyenmon, BacSi.Tenphongkham, BacSi.Sdt);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã bác sĩ", "Họ tên", "Giới tính", "Chuyên môn", "Tên phòng khám", "SĐT");
            foreach (BacSi BacSi in arrayList)
            {
                display(BacSi);
            }
        }

        public void Nhap(ArrayList arrayList)
        {
           
            Console.WriteLine("Nhập mã bác sĩ");
            string mabs = Console.ReadLine();
            Console.WriteLine("Nhập họ tên");
            string hoten = Console.ReadLine();
            Console.WriteLine("Nhập giới tính");
            string gioitinh = Console.ReadLine();
            Console.WriteLine("Nhập chuyên môn");
            string chuyenmon = Console.ReadLine();
            Console.WriteLine("Nhập tên phòng khám");
            string phongkham = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            string sdt = Console.ReadLine();
            arrayList.Add(new BacSi(mabs,hoten,gioitinh,chuyenmon,phongkham,sdt));
        }

        public void Sua(ArrayList arrayList)
        {

            BacSi kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã bác sĩ");
                kq.Mabs = Console.ReadLine();
                Console.WriteLine("Nhập họ tên");
                kq.Hoten = Console.ReadLine();
                Console.WriteLine("Nhập giới tính");
                kq.Gioitinh = Console.ReadLine();
                Console.WriteLine("Nhập chuyên môn");
                kq.Chuyenmon = Console.ReadLine();
                Console.WriteLine("Nhập tên phòng khám");
                kq.Tenphongkham = Console.ReadLine();
                Console.WriteLine("Nhập số điện thoại");
                kq.Sdt = Console.ReadLine();
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            BacSi kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã bác sĩ", "Họ tên", "Giới tính", "Chuyên môn", "Tên phòng khám", "SĐT");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            BacSi kq = find(arrayList);
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
