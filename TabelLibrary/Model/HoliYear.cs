using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelLibrary.Model
{
    public class HoliYear
    {
        public List<DateTime> HoliYea;
        public List<DateTime> HoliWorkYea;
        public int year;
        public HoliYear(int year)
        {
            Db db = new Db();
            HoliYea = db.GetHoliYear(DateTime.Now.Year);
            HoliWorkYea = db.GetWorkHoliYear(DateTime.Now.Year);
        }

        public HoliYear()
        { }

    }

}
