using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public class BookMapperCSV : DataMapperCSV<Book>
    {
        protected override string TableName
        {
            get { return "book"; }
        }

        protected override Book ParseEntry(string[] parameters)
        {
            Book instance = new Book();
            instance.ID = int.Parse(parameters[0]);
            instance.Title = parameters[1];
            instance.ISBN = parameters[2];
            instance.Pages = int.Parse(parameters[3]);
            instance.GenreID = int.Parse(parameters[4]);
            instance.AuthorID = int.Parse(parameters[5]);
            instance.PublisherID = int.Parse(parameters[6]);

            return instance;
        }

        protected override int GetID(Book instance)
        {
            return instance.ID;
        }

        protected override string ToCsvLine(Book instance)
        {
            string[] array = new string[] { instance.ID.ToString(), instance.Title, instance.ISBN, instance.Pages.ToString(), instance.GenreID.ToString(), instance.AuthorID.ToString(), instance.PublisherID.ToString() };
            return string.Join(";", array);
        }
    }
}
