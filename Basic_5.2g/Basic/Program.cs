using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-time calculator
            int minute;
            minute = Convert.ToInt32(Console.ReadLine());
            double hour=0,e;
            if (minute > 0)
            {

                hour = minute / 60;
                if (minute % 60 != 0)
                {
                    e = (minute % 60.0);
                    
                    Console.WriteLine($"{hour}:{e}");
                }
                else
                {
                    e = minute % 60.0;
                    Console.WriteLine($"{hour}:{e}0 ");
                }
                
            }
            //2
            int Age;
            Age = Convert.ToInt32(Console.ReadLine());
            string Analysis="";
            if(Age>0)
            {
                if(Age<=12)
                {
                    Analysis = "bola";
                }
                if(Age>=13&&Age<=19)
                {
                    Analysis = "O'smir";
                }
                if(Age>=20&&Age<=59)
                {
                    Analysis = "kattalar";

                }
                if (Age >= 60 && Age <= 125)
                {
                    Analysis = "katta";
                }
                if(Age>125)
                {
                    Analysis = "Record";
                }
                Console.WriteLine(Analysis);
            }
            //3 overal score
            again:
            int s=Convert.ToInt32(Console.ReadLine());
           if(s>0&&s<100)
            {
                string d = (s < 40) ? "Qoniqarsiz" : (s > 40 && s < 59) ? "Qoniqarli" : (s >= 60 && s < 79) ? "Yaxshi" : (s >= 80 && s < 100) ? "Alo" : "";
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("s>0 ,s<100 ");
                goto again;
            }

        }
    }
}
