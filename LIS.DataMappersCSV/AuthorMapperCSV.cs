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

            /*
            Book newBook = new Book();
            newBook.ID = int.Parse(items[0]);
            newBook.Title = items[1];
            newBook.Author = items[2];
            newBook.Genre = items[3];
            newBook.ISBN = items[4];
            newBook.Publisher = items[5];
            newBook.Language = items[6];
            newBook.Pages = int.Parse(items[7]);
            books.Add(newBook);
            */
        }

        protected override int GetID(Author instance)
        {
            return instance.ID;
        }

        protected override string BookToCsvLine(Author instance)
        {
            string[] array = new string[] { instance.ID.ToString(), instance.FirstName, instance.MiddleName, instance.LastName };
            return string.Join(";", array);
        }
    }
}
