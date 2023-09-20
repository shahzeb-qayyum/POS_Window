using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PointOfSale.Model
{
    public  class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dateofbirth {get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string House_no { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
