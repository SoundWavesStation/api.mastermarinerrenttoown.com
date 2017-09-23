using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMarinerCabRentToOwn.Schema.Sql
{
    public class TransactionDetailsMaster
    {
        public TransactionDetailsMaster()
        {

        }

        public int Tdmt_TransactionDetailsCode { get; set; }
        public int Tdmt_TransactionCode { get; set; }
        public TransactionMaster TransactionMaster { get; set; }
        public int Tdmt_CabCode { get; set; }
        public CabMaster CabMaster { get; set; }
        public decimal Tdmt_CabRentalData { get; set; }
        public decimal Tdmt_DefficiencyAmount { get; set; }
        public DateTime Tdmt_From { get; set; }
        public DateTime Tdmt_To { get; set; }
        public string Tmdt_Status { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ludatetime { get; set; }
    }
}
