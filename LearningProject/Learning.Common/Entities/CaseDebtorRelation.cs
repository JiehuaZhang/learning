using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Common.Entities
{
    public class CaseDebtorPair
    {
        public int ActNo { get; set; }
        public int DebtorNo { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var caseDebtor = (CaseDebtorPair)obj;
            return ActNo.Equals(caseDebtor.ActNo) && DebtorNo.Equals(caseDebtor.DebtorNo);
        }

        public override int GetHashCode()
        {
            return ActNo.GetHashCode() ^ DebtorNo.GetHashCode();
        }
    }
}
