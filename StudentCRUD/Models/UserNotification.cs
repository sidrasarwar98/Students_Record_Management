namespace StudentCRUD.Models
{
    public class UserNotification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsRead { get; set; }
        public string RelatedEntityType { get; set; }
        public int? RelatedEntityId { get; set; }
    }
}
