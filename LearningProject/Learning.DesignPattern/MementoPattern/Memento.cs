using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.MementoPattern
{
    public class Memento<T>
    {
        private T state;

        public T GetState()
        {
            return state;
        }

        public void SetState(T currentState)
        {
            state = currentState;
        }
    }
}
