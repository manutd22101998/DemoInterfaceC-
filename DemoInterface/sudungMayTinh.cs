using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public abstract class sudungMayTinh
    {
        public class SinhVien : ConNguoi, HoatDongTichCuc
        {
            private String masinhvien;
            private String lop;
            private String email;


            // Tạo contructor
            SinhVien()
            {

            }

            SinhVien(String masinhvien, String lop, String email)
            {
                this.masinhvien = masinhvien;
                this.lop = lop;
                this.email = email;
            }
            // Get set cho giá trị
            public String MaSinhVien
            {
                get { return MaSinhVien; }
                set { MaSinhVien = value; }
            }

            public String Lop
            {
                get { return Lop; }
                set { Lop = value; }
            }

            public String Email
            {
                get { return Email; }
                set { Email = value; }
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
                Console.WriteLine("Sinh vien uong ca phe sang.");
            }
        }
    }
}
