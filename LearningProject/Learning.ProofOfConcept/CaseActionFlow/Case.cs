using System.Collections;
using System.Collections.Generic;

namespace Learning.ProofOfConcept.CaseActionFlow
{
    public abstract class Case :ICase, IList<ICase>
    {
        public List<ICase> _cases = new List<ICase>();
        public int CaseNo { get; set; }
        public IClient Client { get; set; }

        public void AddCaseList(List<ICase> caseList)
        {
            _cases.AddRange(caseList);
        }

        public void SetCaseList(List<ICase> caseList)
        {
            _cases = caseList;
        }

        public bool TriggerNextAction()
        {
            return true;
        }

        public bool CaseValidation()
        {
            return true;
        }

        public IEnumerator<ICase> GetEnumerator()
        {
            foreach (var c in _cases)
            {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(ICase item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(ICase item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(ICase[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(ICase item)
        {
            throw new System.NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(ICase item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, ICase item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public ICase this[int index]
        {
            get { throw new System.NotImplementedException(); }
            set { throw new System.NotImplementedException(); }
        }
    }
}
