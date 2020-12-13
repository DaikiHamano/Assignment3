using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Request
    {
        public int RequestId { get; set; } //pk
        public int CartId { get; set; }//FK
        public string Color { get; set; }
        public string Gift { get; set; }
        public string AnyOtherRequests { get; set; }

        //to link to the parent
        public Cart Cart { get; set; }
    }
}
