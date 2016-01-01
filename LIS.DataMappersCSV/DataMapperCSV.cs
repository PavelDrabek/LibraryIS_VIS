using LIS.DAO;
using LIS.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public abstract class DataMapperCSV<T> : DataMapper<T> where T : Entity
    {
        private string path = "";

        protected int idCounter = 0;
        public int NextId { get { return idCounter; } }

        protected List<T> list = null;

        public DataMapperCSV(string filePath)
        {
            idCounter = 0;
            path = filePath + "\\" + TableName + ".csv";
            list = new List<T>();

            PreLoad(filePath);
            Load();
        }

        protected abstract string TableName { get; }
        protected abstract T ParseEntry(string[] parameters);
        protected abstract int GetID(T instance);
        protected abstract string ToCsvLine(T instance);

        protected virtual void PreLoad(string filePath) { }

        protected virtual void Load()
        {
            StreamReader reader = File.OpenText(path);
            string line;
            while ((line = reader.ReadLine()) != null) {
                T entity = ParseEntry(line.Split(';'));
                list.Add(entity);

                if (idCounter < GetID(entity)) {
                    idCounter = GetID(entity);
                }
            }
            reader.Close();
        }

        protected virtual void Save()
        {
            using (StreamWriter writer = new StreamWriter(path)) {
                for (int i = 0; i < list.Count; i++) {
                    string line = ToCsvLine(list[i]);
                    writer.WriteLine(line);
                }
            }
        }

        public override List<T> Select()
        {
            return new List<T>(list);
        }

        public override T Get(int ID)
        {
            for (int i = 0; i < list.Count; i++) {
                if (GetID(list[i]) == ID) {
                    return list[i];
                }
            }

            return default(T);
        }

        public override bool Insert(T instance)
        {
            list.Add(instance);
            Save();
            return true;
        }

        public override bool Update(T instance)
        {
            for (int i = 0; i < list.Count; i++) {
                if (GetID(list[i]) == GetID(instance)) {
                    list[i] = instance;
                    Save();
                    return true;
                }
            }
            return false;
        }

        public override bool Delete(int ID)
        {
            for (int i = 0; i < list.Count; i++) {
                if (GetID(list[i]) == ID) {
                    list.RemoveAt(i);
                    Save();
                    return true;
                }
            }
            return false;
        }

        public override List<T> Search(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
