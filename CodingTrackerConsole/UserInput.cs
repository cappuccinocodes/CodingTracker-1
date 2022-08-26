﻿namespace CodingTrackerConsole
{
    internal class UserInput
    {
        private string _date;
        private string _startTime;
        private string _endTime;

        public string Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        public string GetDate()
        {
            Console.Write("Enter date (dd-mm-yyyy): ");

            this.Date = Console.ReadLine();

            return this.Date;
        }

        public string GetStartTime()
        {
            Console.Write("Enter start time (hh:mm): ");

            this.StartTime = Console.ReadLine();

            return this.StartTime;
        }

        public string GetEndTime()
        {
            Console.Write("Enter end time (hh:mm): ");

            this.EndTime = Console.ReadLine();

            return this.EndTime;
        }
    }
}
