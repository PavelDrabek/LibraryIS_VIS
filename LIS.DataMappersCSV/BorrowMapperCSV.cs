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
        private BookMapperCSV bookMapper;
        private UserMapperCSV userMapper;

        public BorrowMapperCSV(string path) : base(path) { }

        protected override void PreLoad(string filePath)
        {
            base.PreLoad(filePath);
            bookMapper = new BookMapperCSV(filePath);
            userMapper = new UserMapperCSV(filePath);
        }
        
        protected override string TableName
        {
            get { return "borrow"; }
        }

        protected override void Load()
        {
            base.Load();

            for (int i = 0; i < list.Count; i++) {
                list[i].book = bookMapper.Get(list[i].BookID);
                list[i].user = userMapper.Get(list[i].UserID);
            }
        }

        protected override Borrow ParseEntry(string[] parameters)
        {
            Borrow instance = new Borrow();
            instance.ID = int.Parse(parameters[0]);
            instance.Date = DateTime.Parse(parameters[1]);
            DateTime returned = DateTime.MinValue;
            DateTime.TryParseExact(parameters[2], DataMapper<Borrow>.DATE_FORMAT, null, System.Globalization.DateTimeStyles.None, out returned);
            //instance.Returned = (parameters[2].Equals("") ? DateTime.MinValue : DateTime.ParseExact(parameters[2], DataMapper<Borrow>.DATE_FORMAT, null));
            instance.Returned = returned;
            instance.BookID = int.Parse(parameters[3]);
            instance.UserID = int.Parse(parameters[4]);

            return instance;
        }

        protected override int GetID(Borrow instance)
        {
            return instance.ID;
        }

        protected override string ToCsvLine(Borrow instance)
        {
            string[] array = new string[] { 
                instance.ID.ToString(), 
                instance.Date.ToString(DataMapper<Borrow>.DATE_FORMAT),
                (!instance.IsReturned ? "" : instance.Returned.ToString(DataMapper<Borrow>.DATE_FORMAT)), 
                instance.BookID.ToString(), 
                instance.UserID.ToString() 
            };
            return string.Join(";", array);
        }
    }
}
