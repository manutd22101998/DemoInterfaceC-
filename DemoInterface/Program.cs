using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        //private String maNhanVien;
        //private String phongBan;
        //private double mucluong;

        static void Main(string[] args)
        {
            Console.WriteLine("Nhan vien 1");
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = "b1123";
            nv.PhongBan = "Ke toan";
            nv.MucLuong = 8.6;
            Console.WriteLine("Ma nhan vien la : " + nv.maNhanVien + "\n Phong ban la :  " + nv.phongBan + "\n Muc luong la : " + nv.MucLuong);
            Console.WriteLine("--------------------");
            Console.WriteLine("Nhan vien 2");
            NhanVien nv1 = new NhanVien("A123","Quan ly",7.6);
            Console.WriteLine(nv1.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sinh vien 1");
            SinhVien sv1 = new SinhVien();
            sv1.masinhvien = "D00279";
            sv1.Lop = "C1608L";
            sv1.Email = "tienvmd00279@fpt.edu.vn";
            Console.WriteLine("Ma sinh vien : " + sv1.masinhvien + "\n Lop :  " + sv1.Lop + "\n Email : " + sv1.Email);
            Console.WriteLine("--------------------");
            Console.WriteLine("Sinh vien 2");
            SinhVien nv2 = new SinhVien("Abcd123", "Fpt Aptech", "tien2210@gmail.com");
            Console.WriteLine(nv2.ToString());
            Console.ReadKey();

        }
    }
}