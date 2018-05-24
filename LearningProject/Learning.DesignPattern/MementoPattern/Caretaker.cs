using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.MementoPattern
{
    public class Caretaker<T>
    {
        private static readonly List<Memento<T>> mementoList = new List<Memento<T>>();

        public static void SaveState(Originator<T> orig)
        {
            mementoList.Add(orig.CreateMemento());
        }

        public static void RestoreState(Originator<T> orig, int stateNumber)
        {
            orig.SetMemento(mementoList[stateNumber]);
        }
    }
}
