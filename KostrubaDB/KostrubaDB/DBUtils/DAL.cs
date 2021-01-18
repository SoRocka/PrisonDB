using PrisonDB.DBUtils;
using PrisonDB.Helpers;
using PrisonDB.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB
{
    class DAL
    {
        public static void LoadToDGV<T>(DataGridView dgv) where T : IModel, new()
        {
            List<T> list = GetAll<T>();
            ModelToDGVLoader.LoadListToDGV(list, dgv);
        }
        public static List<T> GetAll<T>() where T : IModel, new()
        {
            List<T> result = new List<T>();
            using (DBManager db = new DBManager())
            {
                db.Open();
                using (SqlDataReader reader = db.ExecuteQuery(StaticModelManager.GetModelQuery<T>(QueryType.SELECT)))
                {
                    while (reader.Read())
                    {
                        T model = SqlModelReader.GetModel<T>(reader);
                        result.Add(model);
                    }
                    reader.Close();
                }
                db.Close();
            }
            return result;
        }
        public static List<T> GetAll<T>(string query) where T : IModel, new()
        {
            List<T> result = new List<T>();
            using (DBManager db = new DBManager())
            {
                db.Open();
                using (SqlDataReader reader = db.ExecuteQuery(query))
                {
                    while (reader.Read())
                    {
                        T model = SqlModelReader.GetModel<T>(reader);
                        result.Add(model);
                    }
                    reader.Close();
                }
                db.Close();
            }
            return result;
        }

        public static void ExecQuery<T>(QueryType queryType, T model) where T : IModel
        {
            using (DBManager db = new DBManager())
            {
                db.Open();
                string query = "";
                switch (queryType)
                {
                    case QueryType.INSERT:
                        query = model.InsertQuery();
                        break;
                    case QueryType.UPDATE:
                        query = model.UpdateQuery();
                        break;
                    case QueryType.DELETE:
                        query = model.DeleteQuery();
                        break;
                    default:
                        throw new ArgumentException();
                }
                db.ExecuteNonQuery(query, model.GetHashtable());
                db.Close();
            }
        }

    }
}
