using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMarinerCabRentToOwn.Schema.Sql
{
    public class AddressMasterDetails
    {
        public AddressMasterDetails()
        {

        }
        public int Addmt_AddressDetailCode { get; set; }
        public int Addmt_AddressCode { get; set; }
        public AddressMaster AddressMaster { get; set; }
        public string Addmt_Country { get; set; }
        public int Addmt_ZipCode { get; set; }
        public string Addmt_CompleteAddress { get; set; }
        public string Addmt_OtherAddressDetails { get; set; }
        public string Addmt_Description { get; set; }
        public string Addmt_Status { get; set; }
        public DateTime Addmt_Date { get; set; }
        public bool IsDeleted { get; set; }
        public int UpdatedBy { get; set; }
        public UserMaster UserMaster { get; set; }
        public DateTime ludatetime { get; set; }
    }
}
