using FinSAD.Domain.Enums;

namespace FinSAD.Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public string Message { get; set; } = string.Empty;
        public NotificationStatus Status { get; set; }
        public string Type { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }

        public void MarkAsRead() => Status = NotificationStatus.Read;
    }
}