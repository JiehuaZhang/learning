using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ObserverPattern.Subscribe
{
    public interface ISubject<out T> where T: EventArgs
    {
        void Attach(IObserver<T> observer);
        void Detach(IObserver<T> observer);
    }
}
