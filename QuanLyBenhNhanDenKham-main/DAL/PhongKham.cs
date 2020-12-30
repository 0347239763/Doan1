using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
using QuanLyBenhNhanDenKham.DAL.Interface;
using System.IO;
namespace QuanLyBenhNhanDenKham.DAL
{
    class PhongKham_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {

            if (File.Exists("PhongKham.txt"))
            {
                StreamReader streamReader = new StreamReader("PhongKham.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string mapk = line.Split("#")[0];
                    string tenpk = line.Split("#")[1];
                    string loaiphong = line.Split("#")[2];
                   
                    arrayList.Add(new PhongKham(mapk, tenpk,loaiphong));
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("PhongKham.txt");
            foreach (PhongKham PhongKham in arrayList)
            {
                streamWriter.WriteLine(PhongKham.ToString());
            }
            streamWriter.Close();
        }
    }
}
