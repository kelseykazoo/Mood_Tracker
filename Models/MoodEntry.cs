using System;

namespace MoodTrackerWeb.Models
{
    public class MoodEntry
    {
        public DateTime MyDate { get; set; } = DateTime.Now;
        public string? Mood { get; set; }
        public string? Note { get; set; }
    }
}
