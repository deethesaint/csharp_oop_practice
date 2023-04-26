using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Buoi2
{
    class Program
    {

        public class HinhTron
        {
            private double r;
            public double R
            {
                get { return r; }
                set
                {
                    if (value < 0)
                        Console.WriteLine("Can't assign negative value!");
                    else
                        r = value;
                }
            }

            public HinhTron()
            {
                r = 0;
            }

            public HinhTron(double r)
            {
                R = r;
            }

            public void Nhap()
            {
                Console.WriteLine("Nhap ban kinh: ");
                R = double.Parse(Console.ReadLine());
            }

            public double ChuVi()
            {
                return r * 2 * Math.PI;
            }

            public double DienTich()
            {
                return r * r * Math.PI;
            }

            public void Xuat()
            {
                Console.WriteLine("Hinh tron co ban kinh: {0:0.00}, chu vi: {1:0.00}, dien tich: {2:0.00}", r, ChuVi(), DienTich());
            }
        }

        public class NhanVien
        {
            private String ms, ht;
            private int nc;
            public String MS
            {
                get { return ms; }
                set { ms = value; }
            }

            public String HT
            {
                get { return ht; }
                set { ht = value; }
            }

            public int NC
            {
                get { return nc; }
                set { nc = value; }
            }

            public char XL
            {
                get
                {
                    if (nc >= 26)
                        return 'A';
                    else if (nc >= 22)
                        return 'B';
                    else
                        return 'C';
                }
            }

            public static int LuongNgay = 200000;

            public NhanVien()
            {
                ms = ht = String.Empty;
                nc = 0;
            }

            public NhanVien(String ms, String ht, int nc)
            {
                this.ms = ms;
                this.ht = ht;
                this.nc = nc;
            }

            public NhanVien(NhanVien a)
            {
                this.ms = a.MS;
                this.ht = a.HT;
                this.nc = a.NC;
            }

            ~NhanVien()
            {

            }
        }
        static void Main(string[] args)
        {

        }
    }
}
