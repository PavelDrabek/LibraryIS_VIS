using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Entities
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Name { get { return FirstName + " " + LastName; } }

        public override string ToString()
        {
            return "{ ID: " + ID +
                ", FirstName: " + FirstName +
                ", MiddleName: " + MiddleName +
                ", LastName: " + LastName;
        }
    }
}
