using LIS.DAO;
using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public class BorrowMapperCSV : DataMapperCSV<Borrow>
    {
        protected override string TableName
        {
            get { return "borrow"; }
        }

        protected override Borrow ParseEntry(string[] parameters)
        {
            Borrow instance = new Borrow();
            instance.ID = int.Parse(parameters[0]);
            instance.Date = DateTime.Parse(parameters[1]);
            instance.Returned = (parameters[2].Equals("") ? DateTime.MinValue : DateTime.Parse(parameters[2]));
            instance.BookID = int.Parse(parameters[3]);
            instance.UserID = int.Parse(parameters[4]);

            return instance;
        }

        protected override int GetID(Borrow instance)
        {
            return instance.ID;
        }

        protected override string BookToCsvLine(Borrow instance)
        {
            string[] array = new string[] { 
                instance.ID.ToString(), 
                (!instance.IsReturned ? null : instance.Returned.ToString(DataMapper<Borrow>.DATE_FORMAT)), 
                instance.BookID.ToString(), 
                instance.UserID.ToString() 
            };
            return string.Join(";", array);
        }
    }
}
