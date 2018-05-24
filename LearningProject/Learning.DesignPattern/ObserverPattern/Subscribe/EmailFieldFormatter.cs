using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ObserverPattern.Subscribe
{
    public class EmailFieldFormatter : IObserver<EmailChangedEventArgs>
    {
        public string ObserverName { get; set; }

        public EmailFieldFormatter(string name)
        {
            ObserverName = name;
        }


        public void Update(object sender, EmailChangedEventArgs e)
        {
            var highlightColor = "Red";
            if (!string.IsNullOrEmpty(e.Email))
            {
                highlightColor = "Yellow";
            }
            Console.WriteLine(highlightColor);
        }
    }
}
