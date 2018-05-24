using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning.Common.Entities;
using Learning.Common.Enum;

namespace Learning.Common.Mapper
{
    public static class EntityMapper
    {
        public static List<niAcnTdo> ToNiAcnTdo(this ActionCase stepCase, AcnTodoType type, int actionStatus)
        {
            return stepCase.Cases.Select(x => new niAcnTdo
            {
                BookedBy = Const.Const.By,
                BookedFor = Const.Const.AcnTdoBookedFor,
                BookedDate = DateTime.Now,
                Date = DateTime.Now.Date,
                Priority = 1,
                TodoType = (byte)type,
                ObjectType = 1,
                ObjectNo = x.CaseNo,
                Action = stepCase.Step.TemplateId,
                SubNo = x.DebtorNo,
                CreditorNo = x.ClientNo * Const.Const.DatabaseConstInt,
                Status = actionStatus,
                Flags = 0,
                AutoCode = string.Empty,
                NextCode = string.Empty,
                Executed = 0,
                ResponseTime = string.Empty,
                DateAdjusted = string.Empty,
                Stack = string.Empty,
                ExtData = Encoding.GetEncoding(1252).GetBytes(string.Empty)
            }).ToList();
        }
    }
}
