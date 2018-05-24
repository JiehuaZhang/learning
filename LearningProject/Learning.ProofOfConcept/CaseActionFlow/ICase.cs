using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ProofOfConcept.CaseActionFlow
{
    public interface ICase
    {
        int CaseNo { get; set; }
        IClient Client { get; set; }

    }
}
