using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMarinerCabRentToOwn.Schema.Sql
{
    public class CabMaster
    {
        public CabMaster()
        {
            TransactionDetailsMaster = new HashSet<TransactionDetailsMaster>();
        }

        public int Cmt_CabCode { get; set; }
        public string Cmt_Name { get; set; }
        public string Cmt_Description { get; set; }
        public decimal Cmt_Price { get; set; }
        public decimal Cmt_MaintenanceCost { get; set; }
        public int Cmt_Rentler { get; set; }
        public UserMaster UserMaster { get; set; }
        public string Cmt_Status { get; set; }
        public int UpdatedBy { get; set; }
        public bool isDeleted { get; set; }
        public DateTime Cmt_Date { get; set; }
        public DateTime ludatetime { get; set; }
        public Byte[] Cmt_Image { get; set; }

        public ICollection<TransactionDetailsMaster> TransactionDetailsMaster { get; set; }
    }
}
