namespace Balta.NotificationContext
{
    public sealed class Notification
    {
        public string Property { get; set; }
        public string Message { get; set; }

        public Notification(string property, string message)
        {
            Message = message;
            Property = property;
        }
    }

}