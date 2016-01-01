using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public class PublisherMapperCSV : DataMapperCSV<Publisher>
    {
        public PublisherMapperCSV(string path) : base(path) { }

        protected override string TableName
        {
            get { return "publisher"; }
        }

        protected override Publisher ParseEntry(string[] parameters)
        {
            Publisher instance = new Publisher();
            instance.ID = int.Parse(parameters[0]);
            instance.Name = parameters[1];

            return instance;
        }

        protected override int GetID(Publisher instance)
        {
            return instance.ID;
        }

        protected override string ToCsvLine(Publisher instance)
        {
            string[] array = new string[] { instance.ID.ToString(), instance.Name };
            return string.Join(";", array);
        }
    }
}
