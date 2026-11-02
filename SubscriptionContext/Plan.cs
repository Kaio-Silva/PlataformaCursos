using PlataformaCursos.ShareContext;

namespace PlataformaCursos.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}