using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Program
    {
        public class PhanSo
        {
            public int num { get; set; }
            public int dem { get; set; }

            public PhanSo(int num, int dem)
            {
                this.num = num;
                try
                {
                    if (dem == 0)
                    {
                        this.dem = 1;
                        throw new Exception();
                    }
                    else
                        this.dem = dem;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
                this.Simplify();
            }

            public PhanSo()
            {
                this.num = 0;
                this.dem = 1;
                
            }

            public PhanSo(int num)
            {
                this.num = num;
                this.dem = 1;
            }

            public PhanSo(PhanSo l)
            {
                this.num = l.num;
                this.dem = l.dem;
            }

            public void Nhap()
            {
                Console.WriteLine("Nhap tu so: ");
                this.num = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine("Nhap mau so: ");
                    this.dem = int.Parse(Console.ReadLine());
                    if (this.dem == 0)
                    {
                        this.dem = 1;
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
                this.Simplify();
            }


            public void Xuat()
            {
                Console.WriteLine("{0}/{1}", this.num, this.dem);
            }

            public void Simplify()
            {
                int tnum = Math.Abs(this.num);
                int tdem = Math.Abs(this.dem);
                int max = tnum < tdem ? tdem : tnum;
                for (int i = max; i >= 1; --i)
                {
                    if (this.num % i == 0 && this.dem % i == 0)
                    {
                        this.num /= i;
                        this.dem /= i;
                        break;
                    }
                }
                if ((num < 0 && dem > 0) || (num > 0 && dem < 0))
                    num = -num;
                else if (num < 0 && dem < 0)
                {
                    num = -num;
                    dem = -dem;
                }
            }

            public double getDouble()
            {
                return (double)this.num / this.dem;
            }
            public PhanSo Cong(PhanSo ps)
            {
                return new PhanSo(ps.num * this.dem + this.num * ps.dem, ps.dem * this.dem);
            }

            public PhanSo Tru(PhanSo ps)
            {
                return new PhanSo(ps.num * this.dem - this.num * ps.dem, ps.dem * this.dem);
            }

            public PhanSo Nhan(PhanSo ps)
            {
                return new PhanSo(ps.num * this.num, ps.dem * this.dem);
            }

            public PhanSo Chia(PhanSo ps)
            {
                return new PhanSo(ps.num * this.dem, ps.dem * this.num);
            }

            public static PhanSo operator +(PhanSo l, PhanSo r)
            {
                return l.Cong(r);
            }

            public static PhanSo operator -(PhanSo l, PhanSo r)
            {
                return l.Tru(r);
            }
            public static PhanSo operator *(PhanSo l, PhanSo r)
            {
                return l.Nhan(r);
            }
            public static PhanSo operator /(PhanSo l, PhanSo r)
            {
                return l.Chia(r);
            }
            public static bool operator >(PhanSo l, PhanSo r)
            {
                return l.getDouble() > r.getDouble();
            }
            public static bool operator >=(PhanSo l, PhanSo r)
            {
                return l.getDouble() >= r.getDouble();
            }
            public static bool operator <(PhanSo l, PhanSo r)
            {
                return l.getDouble() < r.getDouble();
            }
            public static bool operator <=(PhanSo l, PhanSo r)
            {
                return l.getDouble() <= r.getDouble();
            }
            public static bool operator ==(PhanSo l, PhanSo r)
            {
                return l.getDouble() == r.getDouble();
            }
            public static bool operator !=(PhanSo l, PhanSo r)
            {
                return l.getDouble() != r.getDouble();
            }
            public static PhanSo operator ++(PhanSo l)
            {
                return new PhanSo(++l.num, l.dem);
            }
            public static PhanSo operator --(PhanSo l)
            {
                return new PhanSo(--l.num, l.dem);
            }
            public static PhanSo operator ^(PhanSo l, int pc)
            {
                PhanSo x = new PhanSo(1);
                for (int i = 0; i < pc; ++i)
                    x = x * l;
                return x;
            }

            public static implicit operator double(PhanSo l)
            {
                return l.getDouble();
            }

            public static explicit operator PhanSo(double ld)
            {
                return new PhanSo((int)ld);
            }

            public static explicit operator int(PhanSo l)
            {
                return (int)l.getDouble();
            }

            public static implicit operator PhanSo(int li)
            {
                return new PhanSo(li);
            }
            public HonSo TransformToHonSo()
            {
                return new HonSo(this.num / this.dem, this.num % this.dem, this.dem);
            }

            public override string ToString()
            {
                this.Xuat();
                return (this.num) + "/" + (this.dem);
            }

        }

        public class HonSo
        {
            public int n { get; set; }
            public PhanSo ps {get; set;}

            public HonSo()
            {
                this.n = 0;
                this.ps = new PhanSo();
            }

            public HonSo(int n, int num, int dem)
            {
                this.n = n;
                this.ps = new PhanSo(num, dem);
            }

            public HonSo(HonSo l)
            {
                this.n = l.n;
                this.ps = new PhanSo(l.ps.num, l.ps.dem);
            }

            public void Nhap()
            {
                Console.WriteLine("Nhap phan nguyen: ");
                this.n = int.Parse(Console.ReadLine());
                this.ps.Nhap();
            }

            public void Xuat()
            {
                Console.Write(n + " ");
                this.ps.Xuat();
            }

            public PhanSo TransformToPhanSo()
            {
                if (this.n > 0)
                    return new PhanSo(this.ps.num * this.n, this.ps.dem);
                else
                    return new PhanSo(this.ps.num, this.ps.dem);
            }

            public static HonSo operator+(HonSo l, HonSo r)
            {
                PhanSo a = new PhanSo(l.ps.num, l.ps.dem);
                PhanSo b = new PhanSo(r.ps.num, r.ps.dem);
                PhanSo x = a + b;
                return new HonSo(x.TransformToHonSo());
            }

            public static HonSo operator -(HonSo l, HonSo r)
            {
                return new HonSo((new PhanSo(l.TransformToPhanSo()) - r.TransformToPhanSo()).TransformToHonSo());
            }

            public static HonSo operator *(HonSo l, HonSo r)
            {
                return new HonSo((new PhanSo(l.TransformToPhanSo()) * r.TransformToPhanSo()).TransformToHonSo());
            }

            public static HonSo operator /(HonSo l, HonSo r)
            {
                return new HonSo((new PhanSo(l.TransformToPhanSo()) / r.TransformToPhanSo()).TransformToHonSo());
            }

            public static bool operator <(HonSo l, HonSo r)
            {
                return l.TransformToPhanSo() < r.TransformToPhanSo();
            }

            public static bool operator <=(HonSo l, HonSo r)
            {
                return l.TransformToPhanSo() <= r.TransformToPhanSo();
            }

            public static bool operator >(HonSo l, HonSo r)
            {
                return l.TransformToPhanSo() > r.TransformToPhanSo();
            }

            public static bool operator >=(HonSo l, HonSo r)
            {
                return l.TransformToPhanSo() >= r.TransformToPhanSo();
            }

            public static bool operator !=(HonSo l, HonSo r)
            {
                return l.TransformToPhanSo() != r.TransformToPhanSo();
            }

            public static bool operator ==(HonSo l, HonSo r)
            {
                return l.TransformToPhanSo() == r.TransformToPhanSo();
            }

        }

        public class ThiSinh
        {
            public string SBD { get; set; }
            public string TEN { get; set; }
            public int NAMSINH { get; set; }
            public double TOAN { get; set; }
            public double VAN { get; set; }
            public double ANH { get; set; }

            //a
            public ThiSinh()
            {
                SBD = "";
                TEN = "";
                NAMSINH = 0;
                TOAN = VAN = ANH = 0;
            }

            public ThiSinh(string _sbd, string _ten, int nams, double toan, double van, double anh)
            {
                SBD = _sbd;
                TEN = _ten;
                NAMSINH = nams;
                TOAN = toan;
                VAN = van;
                ANH = anh;
            }

            public ThiSinh(ThiSinh ts)
            {
                SBD = ts.SBD;
                TEN = ts.TEN;
                NAMSINH = ts.NAMSINH;
                TOAN = ts.TOAN;
                VAN = ts.VAN;
                ANH = ts.ANH;
            }

            //b
            public double TongDiem()
            {
                return (TOAN + VAN + ANH * 2);
            }

            //c
            public void KetQua()
            {
                if (TongDiem() >= 25)
                    Console.WriteLine("Dau!");
                else
                    Console.WriteLine("Rot!");
            }

            public bool getKetQua()
            {
                if (TongDiem() >= 25)
                    return true;
                else
                    return false;
            }

            //d
            public void Xuat()
            {
                Console.WriteLine("SBD: {0}, Ten: {1}, Nam sinh: {2}, Diem toan: {3}, Diem van: {4}, Diem anh: {5}, Tong: {6}"
                    , SBD, TEN, NAMSINH, TOAN, VAN, ANH, TongDiem());
            }
        }

        public class DSThiSinh
        {
            public List<ThiSinh> lTS { get; set; }

            public DSThiSinh()
            {
                lTS = new List<ThiSinh>();
            }

            public DSThiSinh(List<ThiSinh> ls)
            {
                lTS = new List<ThiSinh>();
                lTS = ls;
            }
            /*
             * Read the xml file data into list
             */
            // a
            public void SetData(string filePath)
            {
                System.Xml.XmlDocument xmlDocument = new System.Xml.XmlDocument();
                xmlDocument.Load(filePath);
                System.Xml.XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/DSSV/ThiSinh");
                foreach (System.Xml.XmlNode node in xmlNodeList)
                {
                    ThiSinh ts = new ThiSinh();
                    ts.SBD = node["SBD"].InnerText;
                    ts.TEN = node["TEN"].InnerText;
                    ts.NAMSINH = int.Parse(node["NAMSINH"].InnerText);
                    ts.TOAN = double.Parse(node["TOAN"].InnerText);
                    ts.VAN = double.Parse(node["VAN"].InnerText);
                    ts.ANH = double.Parse(node["ANH"].InnerText);
                    lTS.Add(ts);
                }
            }

            //c
            public void Xuat()
            {
                Console.WriteLine("Danh sach thi sinh:");
                foreach (ThiSinh ts in lTS)
                {
                    ts.Xuat();
                }
            }

            //d Sap xep giam dan theo tong diem
            public void SortBySumPoint()
            {
                lTS = lTS.OrderByDescending(t => t.TongDiem()).ToList();
            }

            //e Sap xep tang dan theo ho ten
            public void SortByName()
            {
                lTS = lTS.OrderBy(t => t.TEN).ToList();
            }

            //f Lay danh sach co thi sinh DAU
            public List<ThiSinh> getThiSinhDau()
            {
                return lTS.Where(t => t.getKetQua() == true).ToList();
            }
            
            //g Lay danh sach co thi sinh sinh nam 1995 tro di hoac diem toan >= 9
            public List<ThiSinh> getThiSinhUnknown()
            {
                return lTS.Where(t => (t.NAMSINH > 1995 || t.TOAN >= 9)).ToList();
            }

        }

        static void Main(string[] args)
        {
            DSThiSinh ls = new DSThiSinh();
            ls.SetData("../../gv.xml");
            //ls.Xuat();
            //ls.SortByName();
            //ls.Xuat();
            DSThiSinh newlist = new DSThiSinh(ls.getThiSinhUnknown());
            newlist.Xuat();
            Console.ReadLine();
        }
    }
}
