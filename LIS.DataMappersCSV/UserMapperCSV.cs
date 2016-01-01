using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public class UserMapperCSV : DataMapperCSV<User>
    {
        public UserMapperCSV(string path) : base(path) { }
        
        protected override string TableName
        {
            get { return "user"; }
        }

        protected override User ParseEntry(string[] parameters)
        {
            User instance = new User();
            instance.ID = int.Parse(parameters[0]);
            instance.UserName = parameters[1];
            instance.FirstName = parameters[1];
            instance.FirstName = parameters[1];

            return instance;
        }

        protected override int GetID(User instance)
        {
            return instance.ID;
        }

        protected override string ToCsvLine(User instance)
        {
            string[] array = new string[] { instance.ID.ToString(), instance.UserName, instance.FirstName, instance.LastName };
            return string.Join(";", array);
        }
    }
}
