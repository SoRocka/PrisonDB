using PrisonDB.Helpers;
using PrisonDB.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB.DBUtils
{
    class StaticModelManager
    {
        public static string GetModelQuery<T>(QueryType queryType) where T : IModel, new()
        {
            T model = new T();
            switch (queryType)
            {
                case QueryType.INSERT:
                    return model.InsertQuery();
                case QueryType.UPDATE:
                    return model.UpdateQuery();
                case QueryType.DELETE:
                    return model.DeleteQuery();
                case QueryType.SELECT:
                    return model.GetAllQuery();
            }
            throw new ArgumentException();
        }
    }
}
