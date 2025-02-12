using System.ComponentModel;
using Balta.ContentContext;

namespace Balta.SubscriptionContext
{
    public class User : Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}