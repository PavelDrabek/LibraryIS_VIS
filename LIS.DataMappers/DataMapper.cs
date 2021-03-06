﻿using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DAO
{
    public abstract class DataMapper<T> where T : Entity
    {
        public static readonly string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";

        public abstract List<T> Select();
        public abstract T Get(int ID);
        //public abstract T Get(T instance);
        public abstract bool Insert(T instance);
        public abstract bool Update(T instance);
        public abstract bool Delete(int ID);
        //public abstract bool Delete(T instance);
        public abstract List<T> Search(string searchText);
    }
}
