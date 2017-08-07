using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Book_Store_Malathi
{
    class Date
    {
        int day;
        int month;
        int year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int GetDay()
        {
            return day;
        }
        public int GetMonth()
        {
            return month;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetDay(int day)
        {
            this.day = day;

        }
        public void SetMonth(int month)
        {

            this.month = month;
        }
        public void SetYear(int year)
        {

            this.year = year;
        }
        public void SetDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override String ToString()
        {
            return (day + "-" + month + "-" + year);
        }

    }
}
