using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonDB.Models
{
    public class Cell : IModel
    {
        public int Cell_id { get; set; }
        public int Capacity { get; set; }
        public string Corps_name { get; set; }

        public string DeleteQuery()
        {
            return "DELETE FROM [prison].[dbo].[BDCell] " +
                "   WHERE Cell_id = @Cell_id";
        }

        public string GetAllQuery()
        {
            return "SELECT C.Cell_id, C.Capacity, Co.Name as CorpsName " +
                    "FROM [prison].[dbo].[BDCell] C " +
                        "INNER JOIN [prison].[dbo].[BDCorps] Co ON " +
                        "C.Corps_Number = Co.Corps_Number";
        }

        public Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Cell_id", Cell_id);
            hashtable.Add("Capacity", Capacity);
            hashtable.Add("CorpsName", Corps_name);
            return hashtable;
        }

        public string InsertQuery()
        {
            return "INSERT INTO [prison].[dbo].[BDCell](Cell_id, Capacity) " +
                "   VALUES(@Cell_id, @Capacity)";
        }

        public string UpdateQuery()
        {
            return "UPDATE [prison].[dbo].[BDCell] " +
                "   SET Cell_id = @Cell_id, Capacity= @Capacity" +
                "   WHERE Cell_id = @Cell_id";
        }
    }
}
