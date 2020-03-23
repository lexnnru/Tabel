using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace TabelLibrary
{

    public class OneDayData
    {
        public OneDayData(DataRow drow)
        {
            daynumber = new DateTime(Convert.ToInt16(drow[2]), Convert.ToInt16(drow[1]), Convert.ToInt32(drow[0]));
            startday = new DateTime(Convert.ToInt16(drow[2]), Convert.ToInt16(drow[1]), Convert.ToInt16(drow[0]), Convert.ToInt16(drow[3]), Convert.ToInt16(drow[4]), 0);
            endday = new DateTime(Convert.ToInt16(drow[2]), Convert.ToInt16(drow[1]), Convert.ToInt16(drow[0]), Convert.ToInt16(drow[5]), Convert.ToInt16(drow[6]), 0);
            dayDuration = (endday - startday);
            city = Convert.ToString(drow[8]);
            specCheck = Convert.ToString(drow[9]);
            achiv = Convert.ToString(drow[10]);
           


            
        }
        public OneDayData()
        {
        }
        public DateTime daynumber { get; set; }
        public DateTime startday { get; set; }
        public DateTime endday { get; set; }
        public string city { get; set; }
        public string specCheck { get; set; }
        public string achiv { get; set; }
        public TimeSpan dayDuration { get; set; }
        public string family { get; set; }
        public string name { get; set; }
        public string parentName { get; set; }
        public string mail { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public string tabelNumber { get; set; }

    }
    public class Db
    {
        public int month { get; set; }
        public int year { get; set; }
        public int day { get; set; }
        public int hStart { get; set; }
        public int minStart { get; set; }
        public int hEnd { get; set; }
        public int minEnd { get; set; }
        public string gip { get; set; }
        public string city { get; set; }
        public string pgvr { get; set; }
        public string specCheck { get; set; }
        public string specAchiv { get; set; }
        public int id { get; set; }
        public DateTime dtselected { get; set; }
        public SQLiteCommand sqlcmd { get; set; }

        SQLiteConnection sqlDbconn = new SQLiteConnection("Data Source=Tabeldb.db; Version=3");
        public SQLiteDataReader sqldr { get; set; }
        public DataTable sqlTable { get; set; }


        public List<OneDayData> GetTable(int year, int month)
        {
            sqlDbconn.Close();
            sqlDbconn.Open();
            this.year = year;
            this.month = month;
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM Main where Год = @year and  Месяц = @month ";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = month;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            sqlTable.Load(dr);
            List<OneDayData> odd = new List<OneDayData>();

            for (int i = 0; i < sqlTable.Rows.Count; i++)
            {
                odd.Add(new OneDayData(sqlTable.Rows[i]));
            }
            sqlDbconn.Close();
            return odd;

        }
        public DataTable GetReport(string command)
        {
            sqlDbconn.Close();
            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = command;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            sqlTable.Load(dr);
            sqlDbconn.Close();
            return sqlTable;


        }
        public DataTable GetTableSpecCheck()
        {

            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT SpecCheck FROM SpecCheck";
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            sqlTable.Load(dr);
            sqlDbconn.Close();
            return sqlTable;
        }
        public DataTable GetTableCity()
        {

            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT City FROM City";
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            sqlTable.Load(dr);
            sqlDbconn.Close();
            return sqlTable;
        }
        public DataTable GetTablePGVR()
        {

            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM PGVR";
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            sqlTable.Load(dr);
            sqlDbconn.Close();
            return sqlTable;
        }


        public void AddCity(string City)
        {
            this.city = City;

            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "select * from City where city =( @city )";
            sqlcmd.Parameters.Add("@city", System.Data.DbType.String).Value = city;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            if(dr.HasRows==false)
            {
                dr.Close();
                sqlDbconn.Close();
                sqlDbconn.Open();
                sqlcmd.CommandText = "INSERT INTO City (City) VALUES ( @city )";
                sqlcmd.ExecuteNonQuery();
                sqlDbconn.Close();
            }
            else
            {
                dr.Close();
                sqlDbconn.Close();
            }
        }
        public void AddPGVR(string PGVR, string Descr)
        {
            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "select * from PGVR where PGVR =( @pgvr )";
            sqlcmd.Parameters.Add("@pgvr", System.Data.DbType.String).Value = PGVR;
            sqlcmd.Parameters.Add("@descr", System.Data.DbType.String).Value = Descr;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                dr.Close();
                sqlDbconn.Close();
                sqlDbconn.Open();
                sqlcmd.CommandText = "INSERT INTO PGVR (PGVR, descr) VALUES ( @pgvr, @descr )  ";
                sqlcmd.ExecuteNonQuery();
                sqlDbconn.Close();
            }
            else
            {
                dr.Close();
                sqlDbconn.Close();
            }
        }
        public void DellCity(string City)
        {
            this.city = City;

            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "DELETE FROM City WHERE City like (@city)";
            sqlcmd.Parameters.Add("@city", System.Data.DbType.String).Value = city;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();
        }
        public void DellPGVR(string PGVR)
        {
            this.pgvr = PGVR;

            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "DELETE FROM PGVR WHERE PGVR like (@pgvr)";
            sqlcmd.Parameters.Add("@pgvr", System.Data.DbType.String).Value = pgvr;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();
        }
        public void GetSelectedRows(int id)
        {
            this.id = id;

            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM main WHERE ID like @id";
            sqlcmd.Parameters.Add("@id", System.Data.DbType.String).Value = id;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();

            dr.Read();


            object year = dr["Год"];
            object month = dr["Месяц"];
            object day = dr["День"];
            object hStart = dr["ЧасНачала"];
            object mStart = dr["МинутаНачала"];
            object hEnd = dr["ЧасЗавершения"];
            object mEnd = dr["МинутаЗавершения"];
            object gip = dr["ГИП"];
            object city = dr["Город"];
            object specCheck = dr["СпециальнаяОтметка"];
            object specAchiv = dr["ДостиженияЗаДень"];
            this.year = Convert.ToInt32(year);
            this.month = Convert.ToInt32(month);
            this.day = Convert.ToInt32(day);
            this.hStart = Convert.ToInt32(hStart);
            this.minStart = Convert.ToInt32(mStart);
            this.hEnd = Convert.ToInt32(hEnd);
            this.minEnd = Convert.ToInt32(mEnd);
            this.gip = gip.ToString();
            this.city = city.ToString();
            this.specCheck = specCheck.ToString();
            this.specAchiv = specAchiv.ToString();
            dr.Read();
            sqlDbconn.Close();



        }
        public void AddAllRows()
        {
            this.id = id;

            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "INSERT INTO main (Год, Месяц, День, ЧасНачала, МинутаНачала, ЧасЗавершения, МинутаЗавершения, ГИП, Город, СпециальнаяОтметка, ДостиженияЗаДень) VALUES(@year, @month, @day, @hStart, @minStart, @hEnd, @minEnd, @gip, @city, @specCheck, @specAchiv)";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = this.year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = this.month;
            sqlcmd.Parameters.Add("@day", System.Data.DbType.String).Value = this.day;
            sqlcmd.Parameters.Add("@hStart", System.Data.DbType.String).Value = this.hStart;
            sqlcmd.Parameters.Add("@minStart", System.Data.DbType.String).Value = this.minStart;
            sqlcmd.Parameters.Add("@hEnd", System.Data.DbType.String).Value = this.hEnd;
            sqlcmd.Parameters.Add("@minEnd", System.Data.DbType.String).Value = this.minEnd;
            sqlcmd.Parameters.Add("@gip", System.Data.DbType.String).Value = this.gip;
            sqlcmd.Parameters.Add("@city", System.Data.DbType.String).Value = this.city;
            sqlcmd.Parameters.Add("@specCheck", System.Data.DbType.String).Value = this.specCheck;
            sqlcmd.Parameters.Add("@specAchiv", System.Data.DbType.String).Value = this.specAchiv;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();
        }
        public void ChangeSelectedRow()
        {
            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "UPDATE main set Год=@year, Месяц=@month, День=@day, ЧасНачала=@hStart, МинутаНачала=@minStart, ЧасЗавершения=@hEnd, МинутаЗавершения=@minEnd, Город=@city, СпециальнаяОтметка=@specCheck, ДостиженияЗаДень=@specAchiv where День=@day and Месяц=@month and Год=@year";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = this.year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = this.month;
            sqlcmd.Parameters.Add("@day", System.Data.DbType.String).Value = this.day;
            sqlcmd.Parameters.Add("@hStart", System.Data.DbType.String).Value = this.hStart;
            sqlcmd.Parameters.Add("@minStart", System.Data.DbType.String).Value = this.minStart;
            sqlcmd.Parameters.Add("@hEnd", System.Data.DbType.String).Value = this.hEnd;
            sqlcmd.Parameters.Add("@minEnd", System.Data.DbType.String).Value = this.minEnd;
            //sqlcmd.Parameters.Add("@gip", System.Data.DbType.String).Value = this.gip;
            sqlcmd.Parameters.Add("@city", System.Data.DbType.String).Value = this.city;
            sqlcmd.Parameters.Add("@specCheck", System.Data.DbType.String).Value = this.specCheck;
            sqlcmd.Parameters.Add("@specAchiv", System.Data.DbType.String).Value = this.specAchiv;
            // sqlcmd.Parameters.Add("@id", System.Data.DbType.String).Value = this.id;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();

        }
        public void DelSelectedRow(DateTime dtselected)
        {
            using (SQLiteConnection c = new SQLiteConnection("Data Source=Tabeldb.db"))
            {
                this.dtselected = dtselected;
                day = dtselected.Day;
                month = dtselected.Month;
                year = dtselected.Year;
                c.Open();
                new SQLiteCommand($" DELETE FROM main WHERE День = {this.day} AND Месяц = {this.month} AND Год = {this.year}", c).ExecuteNonQuery();
                c.Close();
            }

        }
        public List<int> GetMonthHoliday(int year, int month)
        {
            sqlDbconn.Close();
            sqlDbconn.Open();
            this.year = year;
            this.month = month;
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT day FROM Holiday where year =  @year and  month = @month  ";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = month;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            List<int> monthHoliday = new List<int>();
            if (dr.HasRows)
            {

                while (dr.Read()) // построчно считываем данные
                {
                    int day = Convert.ToInt16(dr.GetValue(0));
                    monthHoliday.Add(day);
                }
            }
            sqlDbconn.Close();
            return monthHoliday;

        }
        public void SetMonthHoliday(int year, int month, int day)
        {
            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "INSERT INTO Holiday (Year, Month, Day) VALUES (@year, @month, @day)";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = month;
            sqlcmd.Parameters.Add("@day", System.Data.DbType.String).Value = day;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();
        }
        public void DelMonthHoliday(int year, int month, int day)
        {
            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "DELETE FROM Holiday  WHERE Year=@year AND Month=@month AND Day=@day";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = month;
            sqlcmd.Parameters.Add("@day", System.Data.DbType.String).Value = day;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();
        }
        public void SetMonthWorkDayOnHoloday(int year, int month, int day)
        {
            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "INSERT INTO WorkHoliday (Year, Month, Day) VALUES (@year, @month, @day)";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = month;
            sqlcmd.Parameters.Add("@day", System.Data.DbType.String).Value = day;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();
        }
        public void DelMonthWorkDayOnHoloday(int year, int month, int day)
        {
            sqlDbconn.Open();
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "DELETE FROM WorkHoliday WHERE Year=@year and Month=@month and Day=@day";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = month;
            sqlcmd.Parameters.Add("@day", System.Data.DbType.String).Value = day;
            sqlcmd.ExecuteNonQuery();
            sqlDbconn.Close();
        }

        public List<int> GetWorkDayOnHoliday(int year, int month)
        {
            sqlDbconn.Close();
            sqlDbconn.Open();
            this.year = year;
            this.month = month;
            DataTable sqlTable = new DataTable();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT day FROM WorkHoliday where year =  @year and  month = @month  ";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            sqlcmd.Parameters.Add("@month", System.Data.DbType.String).Value = month;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            List<int> monthHoliday = new List<int>();
            if (dr.HasRows)
            {

                while (dr.Read()) // построчно считываем данные
                {
                    int day = Convert.ToInt16(dr.GetValue(0));
                    monthHoliday.Add(day);
                }
            }
            sqlDbconn.Close();
            return monthHoliday;

        }

        public DateTime[] GetHoli(int Year, int Month)
        {
            int dayinmonth = DateTime.DaysInMonth(Year, Month);
            List<int> Weekend = new List<int>();
            for (int i = 1; i <= dayinmonth; i++)   // Add Weekend marking
            {
                if (new DateTime(Year, Month, i).DayOfWeek == DayOfWeek.Saturday || new DateTime(Year, Month, i).DayOfWeek == DayOfWeek.Sunday)
                {
                    Weekend.Add(i);
                }
            }
            List<int> monthHoliday = GetMonthHoliday(Year, Month);

            List<int> list1 = Weekend.Union(monthHoliday).ToList();
            list1.Distinct();
            List<int> workMonthHoliday = GetWorkDayOnHoliday(Year, Month);

            List<int> result = new List<int>();
            result = list1.Except(workMonthHoliday).ToList();
            List<DateTime> list2 = new List<DateTime>();
            for (int i = 0; i < result.Count; i++)
            {
                list2.Add(new DateTime(Year, Month, result[i]));
            }
            DateTime[] list3 = list2.ToArray();
            return list3;
        }
        public List<DateTime> GetHoliYear(int year)
        {
            sqlDbconn.Close();
            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM Holiday where year =  @year ";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            List<DateTime> yearHoliday = new List<DateTime>();
            if (dr.HasRows)
            {

                while (dr.Read()) // построчно считываем данные
                {
                    int day = Convert.ToInt16(dr.GetValue(3));
                    int month = Convert.ToInt16(dr.GetValue(2));
                    int yea = Convert.ToInt16(dr.GetValue(1));
                    yearHoliday.Add(new DateTime(yea, month, day).ToUniversalTime());
                }
            }
            sqlDbconn.Close();
            return yearHoliday;

        }
        public void ClearholiTable()
        {
            sqlDbconn.Open();
            new SQLiteCommand("DELETE FROM Holiday ", sqlDbconn).ExecuteNonQuery();
            new SQLiteCommand("DELETE FROM WorkHoliday ", sqlDbconn).ExecuteNonQuery();
            sqlDbconn.Close();
        }
        public List<DateTime> GetWorkHoliYear(int year)
        {
            sqlDbconn.Close();
            sqlDbconn.Open();
            SQLiteCommand sqlcmd = sqlDbconn.CreateCommand();
            sqlcmd.CommandText = "SELECT * FROM WorkHoliday where year =  @year ";
            sqlcmd.Parameters.Add("@year", System.Data.DbType.String).Value = year;
            SQLiteDataReader dr = sqlcmd.ExecuteReader();
            List<DateTime> yearHoliday = new List<DateTime>();
            if (dr.HasRows)
            {

                while (dr.Read()) // построчно считываем данные
                {
                    int day = Convert.ToInt16(dr.GetValue(3));
                    int month = Convert.ToInt16(dr.GetValue(2));
                    int yea = Convert.ToInt16(dr.GetValue(1));
                    yearHoliday.Add(new DateTime(yea, month, day).ToUniversalTime());
                }
            }
            sqlDbconn.Close();
            return yearHoliday;
        }
        /// <summary>
        /// Возвращает значение рабочий ли этот день
        /// </summary>
        public bool HoliIsThisDay (int Year, int Month, int Day)
        {
            bool HoliIsThisDay=false;

            int dayinmonth = DateTime.DaysInMonth(Year, Month);
            List<int> Weekend = new List<int>();
            for (int i = 1; i <= dayinmonth; i++)   // Add Weekend marking
            {
                if (new DateTime(Year, Month, i).DayOfWeek == DayOfWeek.Saturday || new DateTime(Year, Month, i).DayOfWeek == DayOfWeek.Sunday)
                {
                    Weekend.Add(i);
                }
            }
            List<int> monthHoliday = GetMonthHoliday(Year, Month);

            List<int> list1 = Weekend.Union(monthHoliday).ToList();
            list1.Distinct();
            List<int> workMonthHoliday = GetWorkDayOnHoliday(Year, Month);

            List<int> result = new List<int>();
            result = list1.Except(workMonthHoliday).ToList();
            for (int i=0; i<result.Count; i++ )
            {
                if (Day == result[i])
                { HoliIsThisDay = true; }
            }
           
            return HoliIsThisDay;
        }
        public List<int> GetRealHoliMonth(int year, int month)

        {
            List<int> Get = new List<int>();

            for (int i=1; i<=DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            if ( HoliIsThisDay(DateTime.Now.Year, DateTime.Now.Month, i)==true)
            {
                    Get.Add(i);
            }
            return Get;
        }
        }
}
