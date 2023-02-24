using System.Data;

namespace DateModifier
{
    public class DateModifier
    {
        public static int CalculateDifference(string dateInput1, string dateInput2)
        {
            int[] tokens1 = dateInput1
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int year1 = tokens1[0];
            int month1 = tokens1[1];
            int day1 = tokens1[2];
            DateTime date1 = new DateTime(year1, month1, day1); 

            int[] tokens2 = dateInput2
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int year2 = tokens2[0];
            int month2 = tokens2[1];
            int day2 = tokens2[2];
            DateTime date2 = new DateTime(year2, month2, day2);

            return Math.Abs((date1 - date2).Days);
        }
    }
}