using System;
using System.Collections;
using System.Text;
using QuanLyBenhNhanDenKham.BLL;
using QuanLyBenhNhanDenKham.DAL;

namespace QuanLyBenhNhanDenKham.GUI
{
    class PhongKham_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t║                      QUẢN LÍ PHÒNG KHÁM                      ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║            1. Nhập thêm phòng khám                           ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║            2. Hiện thị danh sách phòng khám                  ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║            3. Sửa thông tin phòng khám                       ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║            4. Xóa thông tin phòng khám                       ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║            5. Tìm kiếm phòng khám                            ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║            0.Thoát                                           ║");
            Console.WriteLine("\t\t\t\t╚══════════════════════════════════════════════════════════════╝");
        }
        static PhongKham_DAL PhongKham_DAL = new PhongKham_DAL();
        static PhongKham_BLL PhongKham_BLL = new PhongKham_BLL();
        static ArrayList arrayList = new ArrayList();

        public static void Run()
        {
            PhongKham_DAL.DocFile(arrayList);
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
                        PhongKham_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        PhongKham_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        PhongKham_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        PhongKham_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        PhongKham_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        PhongKham_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        PhongKham_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        PhongKham_BLL.TimKiem(arrayList);
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
