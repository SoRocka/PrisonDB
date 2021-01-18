using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB.Models
{
    public interface IModel
    {
        Hashtable GetHashtable();
        string GetAllQuery();
        string InsertQuery();
        string UpdateQuery();
        string DeleteQuery();
    }
}
