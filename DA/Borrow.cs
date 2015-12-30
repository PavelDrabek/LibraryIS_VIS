using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Entities
{
    public class Borrow : Entity
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Returned { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }

        public User user { get; set; }
        public Book book { get; set; }

        public bool IsReturned { get { return !Returned.Equals(DateTime.MinValue); } }

        public override string ToString()
        {
            return "{ ID: " + ID +
                ", Date: " + Date.ToString() +
                ", Returned: " + (Returned == null ? "null" : Returned.ToString()) +
                ", BookID: " + BookID +
                ", UserID: " + UserID;
        }
    }
}
