//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
//preliminary as array.

using System;
class Workdays
{
    static DateTime[] officialRestDays = new DateTime[] { 
                                                    new DateTime(2015, 1, 1),
                                                    new DateTime(2015, 1, 2),
                                                    new DateTime(2015, 3, 2),
                                                    new DateTime(2015, 3, 3),
                                                    new DateTime(2015, 4, 10),
                                                    new DateTime(2015, 4, 13),
                                                    new DateTime(2015, 5, 1),
                                                    new DateTime(2015, 5, 6),
                                                    new DateTime(2015, 6, 6),
                                                    new DateTime(2015, 9, 21),
                                                    new DateTime(2015, 9, 22),
                                                    new DateTime(2015, 11, 1),
                                                    new DateTime(2015, 12, 24),
                                                    new DateTime(2015, 12, 25),
                                                    new DateTime(2015, 12, 31),
                                               };
    static int NumberOfWorkDays(DateTime endDate)
    {
        int workDays = 0;
        DateTime startDate = DateTime.Now.Date;
        while (startDate <= endDate)
        {
            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int i = 0; i < officialRestDays.Length; i++)
                {
                    if (startDate == officialRestDays[i])
                    {
                        workDays--;
                    }
                }

                workDays++;
            }

            startDate = startDate.AddDays(1);
        }

        return workDays;
    }

    static void Main()
    {
        DateTime now = DateTime.Now;
        //initialize endDate
        DateTime endDate = now.AddDays(30);
        Console.WriteLine("Start date: {0}", now);
        Console.WriteLine("End date: {0}", endDate); 
        int workDays = NumberOfWorkDays(endDate);
        Console.WriteLine("Number of work days: {0}", workDays);
    }
}
