using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMarinerCabRentToOwn.Schema.Sql
{
    public class UserMaster
    {
        public UserMaster()
        {

        }
        public int Umt_UserCode { get; set; }
        public string Umt_FristName { get; set; }
        public string Umt_MiddleName { get; set; }
        public string Umt_LastName { get; set; }
        public string Umt_Email{ get; set; }
        public string Umt_Password { get; set; }
        public string Umt_ConfirmPassword { get; set; }
        public string Umt_Phone { get; set; }
        public string Umt_Gender { get; set; }
        public string Umt_CivilStatus { get; set; }
        public int Umt_Age { get; set; }
        public int Umt_AddressCode { get; set; }
        public string Umt_Image { get; set; }
        public string Umt_Attachments { get; set; }
        public string Umt_BackUpEmail { get; set; }
        public string Umt_Status { get; set; }
        public DateTime Umt_DateCreated { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ludatetime { get; set; }

    }
}
