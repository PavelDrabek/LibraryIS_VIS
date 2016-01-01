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
        private GenreMapperCSV genreMapper;
        private AuthorMapperCSV authorMapper;
        private PublisherMapperCSV publisherMapper;

        public BookMapperCSV(string path) : base(path) { }

        protected override void PreLoad(string filePath)
        {
            base.PreLoad(filePath);
            genreMapper = new GenreMapperCSV(filePath);
            authorMapper = new AuthorMapperCSV(filePath);
            publisherMapper = new PublisherMapperCSV(filePath);
        }
       
        protected override string TableName
        {
            get { return "book"; }
        }

        protected override void Load()
        {
            base.Load();

            for (int i = 0; i < list.Count; i++) {
                list[i].author = authorMapper.Get(list[i].AuthorID);
                list[i].genre = genreMapper.Get(list[i].GenreID);
                list[i].publisher = publisherMapper.Get(list[i].PublisherID);
            }
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
