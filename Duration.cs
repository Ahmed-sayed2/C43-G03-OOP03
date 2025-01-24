using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Duration
    {
        const int div = 3600;
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int h,int m ,int s)
        {
            Hours = h;
            Minutes = m;
                Seconds = s;
        }
        public Duration(int n)
        {
            Cal(n);
        }

        public Duration()
        {
        }

        private void Cal(int n )
        {

            if (n % div == 0)
            {
               Hours = n / div;
            }
            else
            {
                  Hours = n / div;
                n -= (Hours * div);
                Minutes = n / 60;
                n -= (Minutes * 60);
                Seconds = n ;

            }
        }
        private static void Cal(int n,ref int h,ref int m,ref int s)
        {

            if (n % div == 0)
            {
                h = n / div;
            }
            else
            {
                h = n / div;
                n -= (h * div);
                m = n / 60;
                n -= (m * 60);
                s = n;

            }
        }
        public static Duration operator +(Duration le, Duration ri)
        {
            return new Duration()
            {
                 Hours=le.Hours+ri.Hours,
                Minutes = le.Minutes + ri.Minutes
                 ,Seconds = le.Seconds + ri.Seconds

            };
        
        }
        public static Duration operator +(int n, Duration ri)
        {
            int h=0, m=0, s = 0;
            Cal(n, ref h, ref m, ref s);
            return new Duration()
            {
                Hours=h+ri.Hours,
                Minutes=m+ri.Minutes,
                Seconds=s+ri.Seconds,

            };

        }
        public static Duration operator +(Duration li,int n)
        {
            int h = 0, m = 0, s = 0;
            Cal(n, ref h, ref m, ref s);
            return new Duration()
            {
                Hours = h + li.Hours,
                Minutes = m + li.Minutes,
                Seconds = s + li.Seconds,

            };

        }
        public static Duration operator -(Duration le, Duration ri)
        {
            return new Duration()
            {
                Hours = le.Hours - ri.Hours,
                Minutes = le.Minutes - ri.Minutes
                 ,
                Seconds = le.Seconds - ri.Seconds

            };

        }
        public static Duration operator ++(Duration d)
        {
            if (d.Minutes <= 58)
                d.Minutes++;
            else
            {
                d.Hours++;
                if (d.Minutes == 59)
                    d.Minutes = 0;
            }
           
            
            return new Duration()
            {
                Hours=d.Hours,
                Minutes = d.Minutes,
                Seconds=d.Seconds

            };

        }
        public static Duration operator --(Duration d)
        {
            if (d.Minutes >= 2)
                d.Minutes--;
            else
            {
                d.Hours--;
               if(d.Minutes==0)
                d.Minutes = 59;
            }
            return new Duration()
            {
                Hours = d.Hours,
                Minutes = d.Minutes,
                Seconds = d.Seconds

            };

        }
        public static bool operator <(Duration le,Duration ri)
        {
            if (le.Hours < ri.Hours || le.Minutes < ri.Minutes ||
                  le.Seconds < ri.Seconds)
                return false;
            else
                return true;

        }
        public static bool operator >(Duration le, Duration ri)
        {
            if (le.Hours > ri.Hours || le.Minutes > ri.Minutes ||
                 le.Seconds > ri.Seconds)
                return true;
            else
                return false;

        }
        public static bool operator ==(Duration le, Duration ri)
        {
            if (le.Hours == ri.Hours && le.Minutes== ri.Minutes &&
                 le.Seconds == ri.Seconds)
                return true;
            else
                return false;

        }
        public static bool operator !=(Duration le, Duration ri)
        {
            if (le.Hours != ri.Hours && le.Minutes != ri.Minutes &&
                 le.Seconds  != ri.Seconds)
                return true;
            else
                return false;

        }
        public static bool operator <=(Duration le, Duration ri)
        {
            if (le==ri||le<ri )
                return true;
            else
                return false;

        }
        public static bool operator >=(Duration le, Duration ri)
        {
            if (le == ri || le > ri)
                return true;
            else
                return false;

        }
        public static explicit operator DateTime(Duration d)
        {
           return new DateTime(1,2,3,d.Hours,d.Minutes,d.Seconds);

        }
        public override string ToString()
        {
            return $"hours={Hours} ,Minutes={Minutes} , Seconds={Seconds} ";
        }
        public override bool Equals(object? obj)
        {
            return this.Minutes==((Duration)obj).Hours
                && this.Minutes == ((Duration)obj).Minutes &&
                this.Minutes == ((Duration)obj).Seconds;
        }
    }
}
