using System;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.GUI;
namespace QuanLyBenhNhanDenKham.View
{
    class View
    {
        private static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t║                QUẢN LÍ BỆNH NHÂN ĐẾN KHÁM                    ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║                1. QUẢN LÝ BÁC SĨ                             ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║                2. QUẢN LÝ BỆNH NHÂN                          ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║                3. QUẢN LÝ PHIẾU KHÁM                         ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║                4. QUẢN LÝ PHÒNG KHÁM                         ║");
            Console.WriteLine("\t\t\t\t╠══════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t\t\t║                0.Thoát                                       ║");
            Console.WriteLine("\t\t\t\t╚══════════════════════════════════════════════════════════════╝");
        }
        public static void Run()
        {
            int chon;
            while (true)
            {
                Menu();
                Console.Write("Nhập tùy chọn:");
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:

                        BacSi_GUI.Run();
                        Console.Clear();
                        break;
                    case 2:
                        BenhNhan_GUI.Run();
                        Console.Clear();
                        break;
                    case 3:
                        PhieuKham_GUI.Run();
                        Console.Clear();
                        break;
                    case 4:
                        PhongKham_GUI.Run();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
