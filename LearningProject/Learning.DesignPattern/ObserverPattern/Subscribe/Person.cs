using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ObserverPattern.Subscribe
{
    public class EmailChangedEventArgs : EventArgs
    {
        public string Email { get; set; }
    }
    public class Person : ISubject<EmailChangedEventArgs>
    {
        private string _email;
        public event EventHandler<EmailChangedEventArgs> EmailChanged;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnEmailChanged(value);
            }
        }

        private void OnEmailChanged(string value)
        {
            EmailChanged?.Invoke(this, new EmailChangedEventArgs {Email = value});
        }
        public void Attach(IObserver<EmailChangedEventArgs> observer)
        {
            EmailChanged += observer.Update;
        }

        public void Detach(IObserver<EmailChangedEventArgs> observer)
        {
            EmailChanged -= observer.Update;
        }
    }
}
