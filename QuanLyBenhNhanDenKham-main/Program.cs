using System;
using System.Text;
using QuanLyBenhNhanDenKham.View;
namespace QuanLyBenhNhanDenKham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            View.View.Run();
        }
    }
}
