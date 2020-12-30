using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
using QuanLyBenhNhanDenKham.DAL.Interface;
using System.IO;
namespace QuanLyBenhNhanDenKham.DAL
{
    class BenhNhan_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {

            if (File.Exists("Benhnhan.txt"))
            {
                StreamReader streamReader = new StreamReader("Benhnhan.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string mabn = line.Split("#")[0];
                    string hoten = line.Split("#")[1];
                    string gioitinh = line.Split("#")[2];
                    string sdt = line.Split("#")[3];
                    string ngaysinh = line.Split("#")[4];
                    string email = line.Split("#")[5];
                    string dantoc = line.Split("#")[6];

                    arrayList.Add(new BenhNhan(mabn, hoten, gioitinh, sdt, ngaysinh, email, dantoc)) ;
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("Benhnhan.txt");
            foreach (BenhNhan benhNhan in arrayList)
            {
                streamWriter.WriteLine(benhNhan.ToString());
            }
            streamWriter.Close();
        }
    }
}
