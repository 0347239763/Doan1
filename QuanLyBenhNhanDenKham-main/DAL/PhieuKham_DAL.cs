using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
using QuanLyBenhNhanDenKham.DAL.Interface;
using System.IO;
namespace QuanLyBenhNhanDenKham.DAL
{
    class PhieuKham_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {

            if (File.Exists("PhieuKham.txt"))
            {
                StreamReader streamReader = new StreamReader("PhieuKham.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string mapk = line.Split("#")[0];
                    string ngaykham = line.Split("#")[1];
                    string mabs = line.Split("#")[2];
                    string mabn = line.Split("#")[3];
                    string lydo = line.Split("#")[4];
                    string chuandoan = line.Split("#")[5];
                    string ketluan = line.Split("#")[6];
                    double tongtien = double.Parse( line.Split("#")[7]);

                    arrayList.Add(new PhieuKham(mapk, ngaykham, mabs, mabn, lydo, chuandoan,ketluan,tongtien));
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("PhieuKham.txt");
            foreach (PhieuKham PhieuKham in arrayList)
            {
                streamWriter.WriteLine(PhieuKham.ToString());
            }
            streamWriter.Close();
        }
    }
}
