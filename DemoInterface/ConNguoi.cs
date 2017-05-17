using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public abstract class ConNguoi
    {
        private String ten;
        private String ngaysinh;
        private int gioitinh;
        private String diachi;

        public ConNguoi()
        {

        }

        public ConNguoi(String ten, String ngaysinh, int gioitinh, String diachi)
        {
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
        }
        // Get set cho giá trị
        public String Ten
        {
            get { return Ten; }
            set { Ten = value; }
        }

        public String NgaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }

        public String GioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }

        public String DiaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }

        public void an()
        {
            Console.WriteLine("Con nguoi an.");
        }

        public void ngu()
        {
            Console.WriteLine("Con nguoi ngu.");
        }

        public void chay()
        {
            Console.WriteLine("Con nguoi chay.");
        }

        public void choi()
        {
            Console.WriteLine("Con nguoi choi.");
        }

        public void gioithieu()
        {
            Console.WriteLine("Con nguoi gioi thieu.");
        }

    }
}
