using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBenhNhanDenKham.Entities;
using QuanLyBenhNhanDenKham.DAL.Interface;
using System.IO;
namespace QuanLyBenhNhanDenKham.DAL
{
    class BacSi_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {
           
            if (File.Exists("Bacsi.txt"))
            {
                StreamReader streamReader = new StreamReader("Bacsi.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string mabs = line.Split("#")[0];
                    string hoten = line.Split("#")[1];
                    string gioitinh = line.Split("#")[2];
                    string chuyenmon = line.Split("#")[3];
                    string tenphongkham = line.Split("#")[4];
                    string sdt = line.Split("#")[5];

                    arrayList.Add(new BacSi(mabs, hoten, gioitinh, chuyenmon, tenphongkham, sdt));
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("Bacsi.txt");
            foreach (BacSi bacSi in arrayList)
            {
                streamWriter.WriteLine(bacSi.ToString());
            }
            streamWriter.Close();
        }
    }
}
