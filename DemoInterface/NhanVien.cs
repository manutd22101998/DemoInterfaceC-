using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class NhanVien : ConNguoi, HoatDongTieuCuc
    {
        public string maNhanVien;
        public string phongBan;
        public double mucluong;

        // Tạo contructor
        public NhanVien()
        {

        }

        public NhanVien(string maNhanVien, string phongBan, double mucluong)
        {
            this.maNhanVien = maNhanVien;
            this.phongBan = phongBan;
            this.mucluong = mucluong;
        }

        // Get set cho giá trị

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }

        public double MucLuong
        {
            get { return mucluong; }
            set { mucluong = value; }
        }

        public void choiCobac()
        {
            Console.WriteLine("Nhan vien choi co bac.");
        }

        public void hutThuoc()
        {
            Console.WriteLine("Nhan vien hut thuoc.");
        }

        public void uongRuou()
        {
            Console.WriteLine("Nhan vien uong ruou.");
        }
        public override string ToString()
        {
            return string.Format("Ma nhan vien : {0} \n. Phong ban : {1},\n Luong  {2}", this.maNhanVien, this.phongBan, this.MucLuong);
        }
    }
}
