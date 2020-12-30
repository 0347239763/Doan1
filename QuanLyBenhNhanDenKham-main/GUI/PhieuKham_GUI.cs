using System;
using System.Collections;
using System.Text;
using QuanLyBenhNhanDenKham.BLL;
using QuanLyBenhNhanDenKham.DAL;

namespace QuanLyBenhNhanDenKham.GUI
{
    class PhieuKham_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t║                     QUẢN LÍ PHIẾU KHÁM                       ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║              1. Nhập thêm phiếu khám                         ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║              2. Hiện thị danh sách phiếu khám                ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║              3. Sửa thông tin phiếu khám                     ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║              4. Xóa thông tin phiếu khám                     ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║              5. Tìm kiếm phiếu khám                          ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║              0.Thoát                                         ║");
            Console.WriteLine("\t\t\t\t╚══════════════════════════════════════════════════════════════╝");
        }
        static PhieuKham_DAL PhieuKham_DAL = new PhieuKham_DAL();
        static PhieuKham_BLL PhieuKham_BLL = new PhieuKham_BLL();
        static ArrayList arrayList = new ArrayList();

        public static void Run()
        {
            PhieuKham_DAL.DocFile(arrayList);
            int chon;
            while (true)
            {
                Menu();
                //chọn chức  năng
                Console.Write("Nhập tùy chọn:");
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        PhieuKham_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        PhieuKham_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        PhieuKham_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        PhieuKham_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        PhieuKham_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        PhieuKham_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        PhieuKham_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        PhieuKham_BLL.TimKiem(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
