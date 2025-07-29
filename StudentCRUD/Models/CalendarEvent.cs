namespace StudentCRUD.Models
{
    public class CalendarEvent
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string EventType { get; set; }
        public int? RelatedId { get; set; }
        public bool ReminderSent { get; set; }
        public DateTime? ReminderDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
