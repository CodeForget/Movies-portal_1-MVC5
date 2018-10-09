using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies_portal_MVC5.Models;

namespace Movies_portal_MVC5.Models
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipType { get; set; }
        public Customer Customer { get; set; }
    }
}