using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Movies_portal_MVC5.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public short signUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        //base on Refrence Data Membership Dropdown
        public static readonly byte Unknown=0;
        public static readonly byte PayAsYouGo=1;
    }
}