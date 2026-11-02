using PlataformaCursos.ContextNotification;

namespace PlataformaCursos.ShareContext
{
    public class Base : Notifiable
    {
        public Base()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}