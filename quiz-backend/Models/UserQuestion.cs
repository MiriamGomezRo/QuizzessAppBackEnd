using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend.Models
{
    public class UserQuestion
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string ZipCode { get; set; }
    }
}
