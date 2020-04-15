using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelLibrary;

namespace Tabel
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SendForm First_form = new SendForm();
            Form3 FormBD = new Form3 ();
        
            //int dayX = 1;
            //Reg triger = new Reg();
            //int b=triger.reed();

            //if (triger.reed() == 0)  //выполняется проверка созданности параметра в реестре
            //{
            //    triger.write(1);
            //}
            //for (;;)
            //{
                FormBD.ShowDialog();
               
            //    int dayinmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            //    DateTime currentday = DateTime.Now;
            //    var dayofweek15 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15).DayOfWeek;
            //    var dayofweekLastday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayinmonth).DayOfWeek;

            //    if (currentday.Day <= 15)
            //    {
            //        if (dayofweek15 == DayOfWeek.Sunday)
            //        {
            //            dayX = 13;
            //        }
            //        else if (dayofweek15 == DayOfWeek.Saturday)
            //        {
            //            dayX = 14;
            //        }
            //        else dayX = 15;
            //    }
            //    else if (currentday.Day > 15)
            //    {
            //        if (dayofweekLastday == DayOfWeek.Sunday)
            //        {
            //            dayX = dayinmonth - 2;
            //        }
            //        else if (dayofweekLastday == DayOfWeek.Saturday)
            //        {
            //            dayX = dayinmonth - 1;
            //        }
            //        else dayX = dayinmonth;
            //    }

            //    if (dayX == currentday.Day && currentday.Hour >= 8 && currentday.Hour <= 15 && triger.reed() == 1)
            //    {

            //        First_form.ShowDialog();

            //    }

            //    else if (dayX == currentday.Day && currentday.Hour >= 8 && currentday.Hour <= 15 && triger.reed() == 3)
            //    {
            //        Thread.Sleep(3600000);
            //        triger.write(1);
            //    }
            //    else if (dayX == currentday.Day && currentday.Hour >= 0 && currentday.Hour <= 15 && triger.reed() == 2)
            //    {
            //        Thread.Sleep(10000);
            //    }
            //    else
            //    {
            //        triger.write(1);
            //        Thread.Sleep(TimeSpan.FromMinutes(5));
            //    }

            //}

        }
    }
}
