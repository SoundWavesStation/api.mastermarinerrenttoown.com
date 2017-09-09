using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMarinerCabRentToOwn.Schema.Sql
{
    public class AddressMaster
    {
        public AddressMaster()
        {

        }
        public int Admt_AddressCode { get; set; }
        public int Admt_UserCode { get; set; }
        public DateTime Admt_Date { get; set; }
    }
}
