namespace DateTest
{
    public class Date
    {
        private int Month { get; set; }
        private int Day { get; set; }
        private int Year { get; set; }

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public string DisplayDate()
        {
            return $"{Month}/{Day}/{Year}";
        }

        
    }
}