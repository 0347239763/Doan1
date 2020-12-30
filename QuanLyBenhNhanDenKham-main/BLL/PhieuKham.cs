using QuanLyBenhNhanDenKham.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
namespace QuanLyBenhNhanDenKham.BLL
{
    class PhieuKham_BLL : ChucNang_IF
    {
        public PhieuKham find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            PhieuKham result = null;
            foreach (PhieuKham PhieuKham in arrayList)
            {
                if (keyword.Equals(PhieuKham.Mapk) || keyword.Equals(PhieuKham.Mabn))
                {
                    result = PhieuKham;
                }
            }
            return result;

        }
        public void display(PhieuKham PhieuKham)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", PhieuKham.Mapk, PhieuKham.Ngaykham, PhieuKham.Mabs, PhieuKham.Mabn, PhieuKham.Lydo, PhieuKham.Chuandoan, PhieuKham.Tongtien);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Mã phiếu khám", "Ngày khám", "Mã bác sĩ", "Mã bệnh nhân", "Lý do", "Chẩn đoán", "Kết luận","Tổng tiền");
            foreach (PhieuKham PhieuKham in arrayList)
            {
                display(PhieuKham);
            }
        }

        public void Nhap(ArrayList arrayList)
        {

            Console.WriteLine("Nhập mã phiếu khám");
            string mapk = Console.ReadLine();
            Console.WriteLine("Nhập ngày khám");
            string ngaykham = Console.ReadLine();
            Console.WriteLine("Nhập mã bác sĩ");
            string mabs = Console.ReadLine();
            Console.WriteLine("Nhập mã bệnh nhân");
            string mabn = Console.ReadLine();
            Console.WriteLine("Nhập lý do");
            string lido = Console.ReadLine();
            Console.WriteLine("Nhập chẩn đoán");
            string chandoan = Console.ReadLine();
            Console.WriteLine("Nhập kết luận");
            string ketluan = Console.ReadLine();
            Console.WriteLine("Nhập tổng tiền");
            double tongtien = double.Parse(Console.ReadLine());
            arrayList.Add(new PhieuKham(mapk,ngaykham,mabs,mabn,lido,chandoan,ketluan,tongtien));
        }

        public void Sua(ArrayList arrayList)
        {

            PhieuKham kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã phiếu khám");
                kq.Mapk = Console.ReadLine();
                Console.WriteLine("Nhập ngày khám");
                kq.Ngaykham = Console.ReadLine();
                Console.WriteLine("Nhập mã bác sĩ");
                kq.Mabs = Console.ReadLine();
                Console.WriteLine("Nhập mã bệnh nhân");
                kq.Mabn = Console.ReadLine();
                Console.WriteLine("Nhập lý do");
                kq.Lydo = Console.ReadLine();
                Console.WriteLine("Nhập chẩn đoán");
                kq.Chuandoan = Console.ReadLine();
                Console.WriteLine("Nhập kết luận");
                kq.Ketluan = Console.ReadLine();
                Console.WriteLine("Nhập tổng tiền");
                kq.Tongtien = double.Parse(Console.ReadLine());
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            PhieuKham kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Mã phiếu khám", "Ngày khám", "Mã bác sĩ", "Mã bệnh nhân", "Lý do", "Chẩn đoán", "Kết luận", "Tổng tiền");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            PhieuKham kq = find(arrayList);
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
