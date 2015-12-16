using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Entities
{
    class Borrow
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Returned { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }

        public User user { get; set; }
        public Book book { get; set; }
    }
}
