using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMarinerCabRentToOwn.Schema.Sql
{
    public class TransactionMaster
    {
        public TransactionMaster()
        {
            TransactionDetailsMaster = new HashSet<TransactionDetailsMaster>();

        }
        public int Tmt_TransactionCode { get; set; }
        public int Tmt_UserCode { get; set; }
        public UserMaster UserMaster { get; set; }
        public decimal Tmt_PaymentPerDay { get; set; }
        public decimal Tmt_TotalQuotation { get; set; }
        public decimal Tmt_CurrentBalance { get; set; }
        public decimal Tmt_AccumulatedBalance { get; set; }
        public string Tmt_TransactionStatus { get; set; }

        public ICollection<TransactionDetailsMaster> TransactionDetailsMaster { get; set; }
    }
}
