namespace PlataformaCursos.ContextNotification
{
    public class Notifiable
    {
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification)
        {
            this.Notifications.Add(notification);
        } 
        
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            this.Notifications.AddRange(notifications);
        } 

        public bool IsInvalid => Notifications.Any();
    }
}