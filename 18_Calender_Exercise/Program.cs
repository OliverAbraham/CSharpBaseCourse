namespace Cal
{
	class Program
    {
        static string Space = "   ";

        static void Main(string[] args)
        {
            PrintYear(2018);
            Console.ReadKey();
        }

        static int[,] GenerateMonthCalendarValues(int year, int month)
        {
            int[,] Values       = new int[5,7];
            var StartDate       = new DateTime(year, month, 1);
            var EndDate         = StartDate.AddMonths(1).AddDays(-1);
            int StartDayOfMonth = (int)StartDate.DayOfWeek;
            int EndDayOfMonth   = (int)EndDate.DayOfWeek;
            int LastDayOfMonth  = EndDate.Day;

            int Day = 1;
            for (int row=0; row<5; row++)
            {
                for (int col=0; col<7; col++)
                {
                    if (row==0 && col<=StartDayOfMonth)
                        Values[row,col] = 0;
                    else if (row == 4 && col>EndDayOfMonth)
                        Values[row,col] = 0;
                    else
                        Values[row,col] = Day++;
                }
            }
            return Values;
        }

        static string[] FormatMonth(int[,] Values)
        {
            var Rows = new string[8];
            int row=0;
            //Rows[row++] = "    " + DateTime.Now.ToString("M YYYY");
            Rows[row++] = "So Mo Di Mi Do Fr Sa " + Space;
            
            for ( ; row<6; row++)
            {
                Rows[row] = ""; 
                for (int col=0; col<7; col++)
                {
                    if (Values[row-1,col] > 0) 
                        Rows[row] += string.Format("{0,2} ", Values[row-1,col]);
                    else
                        Rows[row] += "   ";
                }
                Rows[row] += Space;
            }
            Rows[row] = "";
            return Rows;
        }

        static void PrintMonth(int year, int month)
        {
            var Values = FormatMonth(GenerateMonthCalendarValues(year, month));
            foreach(var Value in Values)
                Console.WriteLine(Value);
        }

        static void Print3Months(int year, int month)
        {
            var Values1 = FormatMonth(GenerateMonthCalendarValues(year, month));
            var Values2 = FormatMonth(GenerateMonthCalendarValues(year, month+1));
            var Values3 = FormatMonth(GenerateMonthCalendarValues(year, month+2));
            for(int i=0; i < Values1.GetLength(0); i++)
            {
                Console.Write(Values1[i]);
                Console.Write(Values2[i]);
                Console.Write(Values3[i]);
                Console.WriteLine();
            }
        }

        static void PrintYear(int year)
        {
            Print3Months(year,1);
            Print3Months(year,4);
            Print3Months(year,7);
            Print3Months(year,10);
        }
    }
}
