using System;

namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatetimeCompere();
            //DatetimeCompere_SameDay();
            //DateCompere();
            DatePropatyTest();
        }

        static void DatetimeCompere()
        {
            DateTime dt1 = new DateTime(2021, 4, 10);
            DateTime dt2 = new DateTime(2021, 4, 9);
            DateTime dt3 = new DateTime(2021, 4, 11);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);

            // 04/10と04/10の比較
            Console.WriteLine(DateTime.Compare(dt1, dt1));
            // 04/10と04/9の比較
            Console.WriteLine(DateTime.Compare(dt1, dt2));
            // 04/10と04/11の比較
            Console.WriteLine(DateTime.Compare(dt1, dt3));

            Console.ReadLine();
        }

        static void DatetimeCompere_SameDay()
        {
            //Compereは同一の日付でも時刻まで見ている

            DateTime dt1 = new DateTime(2021, 4, 10, 12, 00, 00);
            DateTime dt2 = new DateTime(2021, 4, 10, 00, 00, 00);
            DateTime dt3 = new DateTime(2021, 4, 10, 23, 59, 59);

            // 04/10 12:00 と04/10 12:00の比較
            Console.WriteLine(DateTime.Compare(dt1, dt1));
            // 04/10 12:00 と04/10 00:00の比較
            Console.WriteLine(DateTime.Compare(dt1, dt2));
            // 04/10 12:00 と04/10 23:59の比較
            Console.WriteLine(DateTime.Compare(dt1, dt3));

            Console.ReadLine();
        }

        static void DateCompere()
        {
            DateTime dt1 = new DateTime(2021, 4, 10, 12, 00, 00);
            DateTime dt2 = new DateTime(2021, 4, 10, 00, 00, 00);
            DateTime dt3 = new DateTime(2021, 4, 10, 23, 59, 59);

            // 04/10 12:00 と04/10 12:00の比較
            Console.WriteLine(DateTime.Compare(dt1, dt1));
            // 04/10 12:00 と04/10 00:00の比較
            Console.WriteLine(DateTime.Compare(dt1.Date, dt2.Date));
            // 04/10 12:00 と04/10 23:59の比較
            Console.WriteLine(DateTime.Compare(dt1.Date, dt3.Date));

            Console.ReadLine();
        }

        static void DatePropatyTest()
        {
            DateTime dt1 = new DateTime(2021, 4, 10, 12, 00, 00);
            DateTime dt2 = new DateTime(2021, 4, 10, 00, 00, 00);
            DateTime dt3 = new DateTime(2021, 4, 10, 23, 59, 59);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);

            Console.WriteLine("------------------");
            Console.WriteLine(dt1.Date);
            Console.WriteLine(dt2.Date);
            Console.WriteLine(dt3.Date);

            Console.ReadLine();
        }
    }
}
