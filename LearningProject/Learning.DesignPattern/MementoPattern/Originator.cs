using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.MementoPattern
{
    public class Originator<T>
    {
        private T state;

        public Memento<T> CreateMemento ()
        {
            var m = new Memento<T>();
            m.SetState(state);
            return m;
        }

        public void SetMemento(Memento<T> m)
        {
            state = m.GetState();
        }

        public void SetState(T newState)
        {
            this.state = newState;
        }

        public void ShowState()
        {
            Console.WriteLine(state.ToString());
        }
    }
}
