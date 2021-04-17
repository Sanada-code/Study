using System;


class test
{

    static void Main()
    {
        CalcDate calcDate1 = new CalcDate(DateTime.Today);

        CalcDate calcDate2 = new CalcDate(2021,5);


        Console.WriteLine(calcDate1.CountWeekDays());
        Console.WriteLine(calcDate2.CountWeekDays());
    }
}
class CalcDate
{
    int year;
    int month;

    public CalcDate(int year, int month)
    {
        this.year = year;
        this.month = month;
    }

    public CalcDate(DateTime dt): this(dt.Year, dt.Month) { }

     /// <summary>
     /// 平日をカウント
     /// </summary>
     public int CountWeekDays()
    {
        int weekdayCnt = 0;
        for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
        { 

            DateTime day = new DateTime(year, month, i); 

            if (IsWeekday(day))
            {
                weekdayCnt += 1; 
            }
        }
        return weekdayCnt; 
    }
    
    /// <summary>
    /// 休日か判定
    /// 平日ならTrue 休日ならFalse
    /// </summary>
    private Boolean IsWeekday(DateTime day)
    {
        if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
        {
            return true;
        }
        return false;
    }
}
