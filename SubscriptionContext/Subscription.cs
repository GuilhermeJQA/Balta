using Balta.ContentContext;

namespace Balta.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}