using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Common.Const
{
    public static class Const
    {
        public static string SMSOkStatus = "OK - SMS Sendt";
        public static int DatabaseConstInt = 65536;
        public static string By = "SMEAI";
        public static string AICaseFlowActionText = "SME AI ";
        public static string ManuallyDoneText = "Manually Stop";
        public static string CaseFlowEndText = "Case Flow End";
        public static string AgreementVerdicttype = "Frivilligt forlig";
        public static string CaseResultTextPaymentOrAgreement = "Has Payment or Agreement or closed case";
        public static string AcnTdoBookedFor = "SMEAI_CALL";
        public static string SMEAICallActionText = "SME AI Call";
        public static string RemoveActionText = "SMEAIDel";
        public static int EmailAcnTdoListCutNumber = 2500;
        public static string PaymentReason = "Payment";
        public static string PayplanReason = "payplan";
        public static string FundamentPayplanReason = "Foundation_payplan";
        public static string FundamentReason = "Foundation";
        public static string RejectedReason = "Rejected";
        public static string NoResponseResult = "None";
        public static string AIHistStartText = "AI flow startet";
        public static string AIHistEndText = "AI flow stoppet";
        public static string UnknownReason = "Unknown reason";
    }
}
