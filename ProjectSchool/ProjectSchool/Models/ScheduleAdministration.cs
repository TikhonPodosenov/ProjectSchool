﻿namespace ProjectSchool.Models
{
    public class ScheduleAdministration
    {
        public int Id { get; set; }
        public string Group { get; set; }

        public string Day { get; set; }

        public string Subject { get; set; }

        public int NumberSubject {  get; set; }
    }
}