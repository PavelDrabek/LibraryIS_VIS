using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public class AuthorMapperCSV : DataMapperCSV<Author>
    {
        public AuthorMapperCSV(string path) : base(path) { }

        protected override string TableName
        {
            get { return "author"; }
        }

        protected override Author ParseEntry(string[] parameters)
        {
            Author instance = new Author();
            instance.ID = int.Parse(parameters[0]);
            instance.FirstName = parameters[1];
            instance.MiddleName = parameters[2];
            instance.LastName = parameters[3];

            return instance;
        }

        protected override int GetID(Author instance)
        {
            return instance.ID;
        }

        protected override string ToCsvLine(Author instance)
        {
            string[] array = new string[] { instance.ID.ToString(), instance.FirstName, instance.MiddleName, instance.LastName };
            return string.Join(";", array);
        }
    }
}
