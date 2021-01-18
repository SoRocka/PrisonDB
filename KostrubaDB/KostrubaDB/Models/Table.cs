using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostrubaDB.Models
{
    public class Table : IModel
    {
        public int id_table { get; set; }
        public string name { get; set; }
        public int id_user { get; set; }
        public string user_name { get; set; }

        public string DeleteQuery()
        {
            return "DELETE FROM [Meta01].[dbo].[TTables] " +
                "   WHERE id_table = @id_table";
        }

        public string GetAllQuery()
        {
            return "SELECT TB.id_table, TB.name, TB.id_user, US.name AS user_name " +
                "   FROM [Meta01].[dbo].[TTables] TB JOIN " +
                "        [Meta01].[dbo].[UUsers] US ON " +
                "        US.id_user = TB.id_user";
        }

        public Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id_table", id_table);
            hashtable.Add("id_user", id_user);
            hashtable.Add("name", name);
            return hashtable;
        }

        public string InsertQuery()
        {
            return "INSERT INTO [Meta01].[dbo].[TTables](id_user, name) " +
                "   VALUES(@id_user, @name)";
        }

        public string UpdateQuery()
        {
            return "UPDATE [Meta01].[dbo].[TTables] " +
                "   SET name = @name, id_user = @id_user " +
                "   WHERE id_table = @id_table";
        }
    }
}
