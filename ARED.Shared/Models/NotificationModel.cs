namespace ARED.Shared.Models
{
    public class NotificationModel
    {
        public string? Title { get; set; } = "";
        public string? Message { get; set; } = "";
        public int ButtonType { get; set; } = 0;
        public int Icon { get; set; } = 0;
    }
}
