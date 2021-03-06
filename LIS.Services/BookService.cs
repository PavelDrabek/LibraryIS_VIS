﻿using LIS.Entities;
using LIS.DAO;
using LIS.MapperLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Services
{
    public class BookService : EntityService<Book> {

        protected override DataMapper<Book> GetDataMapper()
        {
            return MapperFactory.CreateBookMapper();
        }
    }
}
