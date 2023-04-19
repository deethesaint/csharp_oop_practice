using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Buoi1
{
    class Program
    {
        // Bai 1
        // Sum method
        static int Sum(int a, int b)
        {
            return a + b;
        }
        // Diff method
        static int Diff(int a, int b)
        {
            return a - b;
        }
        // Prod method
        static int Prod(int a, int b)
        {
            return a * b;
        }
        // Quot method
        static int Quot(int a, int b)
        {
            return a / b;
        }

        //Bai 2
        static void SinhVienMethod()
        {
            String MSSV, HoTen, Rank;
            double AvgPoint;
            Console.WriteLine("Enter MSSV: ");
            MSSV = Console.ReadLine();
            Console.WriteLine("Enter Ho va ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Enter Diem trung binh: ");
            AvgPoint = double.Parse(Console.ReadLine());
            if (AvgPoint >= 8)
                Rank = "Gioi";
            else if (AvgPoint >= 6.5)
                Rank = "Kha";
            else if (AvgPoint >= 5)
                Rank = "Trung binh";
            else
                Rank = "Yeu";
            Console.WriteLine("Xep loai: " + Rank);
        }

        //Bai 3

        static void RandomIntArrayList()
        {
            int n;
            List<int> list = new List<int>();
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Random r = new Random();

            Console.WriteLine("The list is: \n");
            for (int i = 0; i < n; ++i)
            {
                list.Add(r.Next(100));
                Console.WriteLine(list[i] + " ");
            }
        }

        // Bai 4. Phuong trinh bac 1

        static void PhuongTrinhBac1()
        {
            int a, b;
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
                Console.WriteLine("X = " + (double)b / a);
        }

        static void PhuongTrinhBac2()
        {
            int a, b, c;
            double delta;

            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (a * b * c == 0)
            {
                Console.WriteLine("X1 = 1, X2 = " + (c / a));
            }
            else if (a + b + c == 0)
            {
                Console.WriteLine("X1 = -1, X2 = " + (-(c / a)));
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("X1 = X2 = " + (-(b / (2 * a))));
                }
                else
                {
                    Console.WriteLine("X1 = {0}, X2 = {1}", ((-b + Math.Sqrt(delta)) / (2 * a)), ((-b - Math.Sqrt(delta)) / (2 * a)));
                }
            }
        }

        //Bai 6
        static void NgayThangNam()
        {
            int day, month, year;
            Console.WriteLine("Enter day: ");
            do
            {
                day = int.Parse(Console.ReadLine());

            } while (day < 1 || day > 31);
            Console.WriteLine("Enter month: ");
            do
            {
                month = int.Parse(Console.ReadLine());

            } while (month < 1 || month > 12);
            Console.WriteLine("Enter year: ");
            year = int.Parse(Console.ReadLine());
            String thu = String.Empty;
            int n;
            if (month < 3)
                year -= 1;
            n = ((day + 2 * month + (3 * month + 1)) / 5 + year + (year / 4)) % 7;
            switch (n)
            {
                case 0: thu = "Chu Nhat";
                    break;
                case 1: thu = "Thu Hai";
                    break;
                case 2: thu = "Thu Ba";
                    break;
                case 3: thu = "Thu Tu";
                    break;
                case 4: thu = "Thu Nam";
                    break;
                case 5: thu = "Thu Sau";
                    break;
                case 6: thu = "Thu Bay";
                    break;
            }
            Console.WriteLine(thu);
        }

        // Bai 7


        static bool isPrime(int num)
        {
            for (int i = 2; i < Math.Sqrt(num); ++i)
                if (num % i == 0)
                    return false;
            return true;
        }

        static int nextPrime(int primeNumber)
        {
            int x = primeNumber;
            while (true)
            {
                ++x;
                if (isPrime(x))
                    break;
            }
            return x;
        }

        // Bai 7
        static void Number()
        {
            int n;
            Console.WriteLine("Nhap so n: ");
            n = int.Parse(Console.ReadLine());

            String tich = String.Empty;

            int temp = n;

            int prime = 2;
            while (temp > 1)
            {
                if (prime > temp) break;
                if (temp % prime == 0)
                {
                    temp /= prime;
                    tich += Convert.ToString(prime);
                    if (temp > 1)
                        tich += "*";
                }
                else
                {
                    prime = nextPrime(prime);
                }
            }
            temp = n;
            int count = 1;
            while (temp / 10 > 0)
            {
                ++count;
                temp /= 10;
            }
            Console.WriteLine("Thua so nguyen to: " + tich);
            Console.WriteLine("So chu so cua n: " + count);
        }

        static void Main(string[] args)
        {

            //SinhVienMethod();
            //RandomIntArrayList();
            int choice = -1;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Bai 1\n2. Bai 2\n3. Bai 3\n4. Bai 4\n5. Bai 5\n6. Bai 6\n7. Bai 7\n");
                Console.WriteLine("Nhap lua chon: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        int a, b;
                        Console.WriteLine("Enter a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sum: " + Sum(a, b));
                        Console.WriteLine("Difference: " + Diff(a, b));
                        Console.WriteLine("Product: " + Prod(a, b));
                        Console.WriteLine("Quotion: " + Quot(a, b));
                        break;
                    case 2:
                        Console.Clear();
                        SinhVienMethod();
                        break;
                    case 3:
                        Console.Clear();
                        RandomIntArrayList();
                        break;
                    case 4:
                        Console.Clear();
                        PhuongTrinhBac1();
                        break;
                    case 5:
                        Console.Clear();
                        PhuongTrinhBac2();
                        break;
                    case 6:
                        Console.Clear();
                        NgayThangNam();
                        break;
                    case 7:
                        Console.Clear();
                        Number();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            } while (choice != 0);
        }
    }
}
