using PlataformaCursos.ShareContext;

namespace PlataformaCursos.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; } // Se o endDate estiver no passado o plano ainda está ativo
        public bool IsInactive => EndDate < DateTime.Now;
    }
}