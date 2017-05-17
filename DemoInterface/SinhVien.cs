using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class SinhVien : ConNguoi, HoatDongTichCuc
    {

        private string maSinhvien;
        private string lop;
        private string email;

        public SinhVien() {

        }

        public SinhVien(string maSinhvien, string lop, string email) {
            this.maSinhvien = maSinhvien;
            this.lop = lop;
            this.email = email;
        }


        public string masinhvien
        {
            get { return maSinhvien; }
            set { maSinhvien = value; }
        }

        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public void docsach()
        {
            Console.WriteLine("Sinh vien doc sach.");
        }

        public void hoctap()
        {
            Console.WriteLine("Sinh vien hoc tap.");
        }

        public void luyentapThethao()
        {
            Console.WriteLine("Sinh vien luyen tap the thao.");
        }

        public void nghenhac()
        {
            Console.WriteLine("Sinh vien nghe nhac.");
        }

        public void uongCapheSang()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("Ma sinh vien : {0} \n. Lop : {1},\n Email :  {2}", this.maSinhvien, this.lop, this.email);
        }
    }
}
