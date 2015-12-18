using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Entities
{
    public class User : Entity
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return "{ ID: " + ID +
                ", UserName: " + UserName +
                ", FirstName: " + FirstName +
                ", LastName: " + LastName;
        }
    }
}
