using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoApp
{
    class Order
    {
        public long id { get; set; }
        public String description { get; set; }
        public DateTime dateOrder { get; set; }
        public String dishPhoto { get; set; }
        public Double price { get; set; }

        public Order() 
        { 
            
        }
    }
}
