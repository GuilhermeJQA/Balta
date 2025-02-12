using Balta.ContentContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User user { get; set; }

        public IList<Subscription> Subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium){
                AddNotification(new NotificationContext.Notification("Premium", "O aluno já possue uma assinatura ativa!"));
                return;
            }

            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}