using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Entities
{
    public class Genre : Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "{ ID: " + ID +
                ", Name: " + Name;
        }
    }
}
