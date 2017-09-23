using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMarinerCabRentToOwn.Schema.Sql
{
    public class AddressMaster
    {
        public AddressMaster()
        {
            AddressMasterDetails = new HashSet<AddressMasterDetails>();
        }
        public int Admt_AddressCode { get; set; }
        public int Admt_UserCode { get; set; }
        public UserMaster UserMaster { get; set; }
        public DateTime Admt_Date { get; set; }

        public ICollection<AddressMasterDetails> AddressMasterDetails { get; set; }
       
    }
}
