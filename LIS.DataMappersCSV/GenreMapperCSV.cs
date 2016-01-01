using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public class GenreMapperCSV : DataMapperCSV<Genre>
    {
        public GenreMapperCSV(string path) : base(path) { }

        protected override string TableName
        {
            get { return "genre"; }
        }

        protected override Genre ParseEntry(string[] parameters)
        {
            Genre instance = new Genre();
            instance.ID = int.Parse(parameters[0]);
            instance.Name = parameters[1];

            return instance;
        }

        protected override int GetID(Genre instance)
        {
            return instance.ID;
        }

        protected override string ToCsvLine(Genre instance)
        {
            string[] array = new string[] { instance.ID.ToString(), instance.Name };
            return string.Join(";", array);
        }
    }
}
