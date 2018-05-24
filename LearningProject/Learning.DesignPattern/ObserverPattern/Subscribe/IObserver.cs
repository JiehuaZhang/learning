using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.ObserverPattern.Subscribe
{
    public interface IObserver<in T> where T: EventArgs
    {
        void Update(object sender, T e);
    }
}
