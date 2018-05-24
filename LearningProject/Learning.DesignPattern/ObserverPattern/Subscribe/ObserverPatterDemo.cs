using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ObserverPattern.Subscribe
{
    public class ObserverPatterDemo
    {
        public void TryObserverPatter()
        {
            var person = new Person
            {
                Email = "jz@collectia.dk",
                FirstName = "Judy",
                LastName = "Zhang"
            };

            person.Attach(new StatusUpdater());
            person.Attach(new EmailFieldFormatter(person.Email));

            person.Email = "jz@test.dk";
        }
    }
}
