using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DesignPattern.CompositePattern
{
    public class Employee : IEmployed , IEnumerable<IEmployed>
    {
        private readonly List<IEmployed> _subordinates = new List<IEmployed>();
        public int EmpID { get; set; }
        public string Name { get; set; }
        public void Dispay(string role)
        {
            Console.WriteLine(role + $": EmpID={EmpID}, Name={Name}");
            foreach (var subordinate in this)
            {
                subordinate.Dispay(Name + "'s subordinate");
            }
        }

        public void AddSubordinate(IEmployed subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployed subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public IEmployed GetSubordinate(int index)
        {
            return _subordinates[index];
        }
        public IEnumerator<IEmployed> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
