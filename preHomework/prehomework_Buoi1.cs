using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preHomework
{
    class prehomework_Buoi1
    {
        // Bai 8
        static void IsSquareNumber(int n)
        {
            double j = Math.Sqrt(n);
            if (j * j == n)
                Console.WriteLine("{0} la so chinh phuong\n", n);
            else
                Console.WriteLine("{0} khong la so chinh phuong\n", n);

        }

        // Bai 9
        public class Date
        {
            private int _day;
            private int _month;
            private int _year;

            public Date()
            {
                this._day = this._month = 1;
                this._year = 2000;
            }

            public Date(int day, int month, int year)
            {
                this._day = day;
                this._month = month;
                this._year = year;
            }

            public Date(Date date)
            {
                this._day = date._day;
                this._month = date._month;
                this._year = date._year;
            }

            private bool is31DaysMonth(int month) 
            {
                return month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12;
            }

            public bool isLeapYear()
            {
                return this._year % 400 == 0 || (this._year % 4 == 0 && this._year % 400 != 0);
            }

            public Date nextDay()
            {
                bool _triggerMONTH = false;
                bool _triggerYEAR = false;

                int _newDay = this._day + 1;
                int _newMonth = this._month;
                int _newYear = this._year;

                if (_newDay > 28 && this._month == 2 && this.isLeapYear())
                {
                    _newDay = 1;
                    _triggerMONTH = true;
                }
                else if (_newDay > 29 && this._month == 2)
                {
                    _newDay = 1;
                    _triggerMONTH = true;
                }
                else if (_newDay > 31 && is31DaysMonth(this._month))
                {
                    _newDay = 1;
                    _triggerMONTH = true;
                }
                else if (_newDay > 30 && !is31DaysMonth(this._month))
                {
                    _newDay = 1;
                    _triggerMONTH = true;
                }

                if (_triggerMONTH)
                {
                    ++_newMonth;
                    if (_newMonth > 12)
                    {
                        _newMonth = 1;
                        _triggerYEAR = true;
                    }   
                }

                if (_triggerYEAR)
                {
                    ++_newYear;
                }

                return new Date(_newDay, _newMonth, _newYear);
            }

            public Date previousDay()
            {
                bool _triggerMONTH = false;
                bool _triggerYEAR = false;

                int _newDay = this._day - 1;
                int _newMonth = this._month;
                int _newYear = this._year;

                if (_newDay < 1 && this._month == 3 && this.isLeapYear())
                {
                    _newDay = 28;
                    _triggerMONTH = true;
                }
                else if (_newDay < 1 && this._month == 3)
                {
                    _newDay = 29;
                    _triggerMONTH = true;
                }
                else if (_newDay < 1 && is31DaysMonth(this._month - 1))
                {
                    _newDay = 31;
                    _triggerMONTH = true;
                }
                else if (_newDay < 1)
                {
                    _newDay = 30;
                    _triggerMONTH = true;
                }

                if (_triggerMONTH)
                {
                    --_newMonth;
                    if (_newMonth < 1)
                    {
                        _newMonth = 12;
                        _triggerYEAR = true;
                    }
                }

                if (_triggerYEAR)
                {
                    --_newYear;
                }

                return new Date(_newDay, _newMonth, _newYear);
            }

            public override string ToString()
            {
                return "The date is: {this._day}/{this._month}/{this._year}{Environment.NewLine}";
            }
        }



        // Bai 10
        static void print(List<int> list)
        {
            for (int i = 0; i < list.Capacity; ++i)
                Console.WriteLine(list[i] + " ");
            Console.ReadLine();
        }

        static void findX(List<int> list)
        {
            int x;
            Console.WriteLine("Enter x: ");
            x = int.Parse(Console.ReadLine());
            int n = list.IndexOf(x);
            if (n >= 0)
                Console.WriteLine("Tim thay x tai vi tri " + n);
            else
                Console.WriteLine("Khong tim thay x");
            Console.ReadLine();
        }

        static bool isTwoDigitsNumber(int x)
        {
            int count = 1;
            int temp = x;
            while (temp / 10 > 0)
            {
                ++count;
                temp /= 10;
            }
            if (count == 2)
                return true;
            return false;
        }
        static void twoDigits(List<int> list)
        {
            for (int i = 0; i < list.Capacity; ++i)
                if (isTwoDigitsNumber(list[i]))
                    Console.WriteLine(list[i] + " ");
            Console.ReadLine();
        }

        // ehh 
        // .. :<
        // .. 
        static void HeHe()
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 20; ++i)
                list.Add(r.Next(100));
        }

        static void Main(string[] args)
        {

        }
    }
}
