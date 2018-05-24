using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ObserverPattern.Subscribe
{
    public class StatusUpdater : IObserver<EmailChangedEventArgs>
    {
        public void Update(object sender, EmailChangedEventArgs e)
        {
            Console.WriteLine($"Email address changed to: {e.Email}");
        }
    }
}
