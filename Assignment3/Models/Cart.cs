using System;
using System.Collections.Generic;

namespace Assignment3.Models
{
    public class Cart
    {
        public int CartId { get; set; } //pk
        public int ProductId { get; set; }
        public string Quontity { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Price { get; set; }

        //to link to the child
        public List<Request> Requests { get; set; }
        public List<Order> Orders { get; set; }

    }
}
