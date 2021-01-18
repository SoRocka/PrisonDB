using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostrubaDB.Models
{
    public class User : IModel
    {
        public int id_user { get; set; }
        public string name { get; set; }
        public string ppassword { get; set; }
        public DateTime registration_DATE { get; set; }
        public DateTime last_login_DATE { get; set; }
        public DateTime last_logout_DATE { get; set; }


        public string DeleteQuery()
        {
            return "DELETE FROM [Meta01].[dbo].[UUsers] " +
                "   WHERE id_user = @id_user";
        }

        public string GetAllQuery()
        {
            return "SELECT * " +
                "   FROM [Meta01].[dbo].[UUsers]";
        }

        public Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("id_user", id_user);
            hashtable.Add("name", name);
            if (ppassword != null && ppassword != "")
            {
                hashtable.Add("ppassword", ppassword);
            }
            else
            {
                hashtable.Add("ppassword", DBNull.Value);
            }

            hashtable.Add("registration_DATE", registration_DATE);
            if (last_login_DATE != DateTime.MinValue)
            {
                hashtable.Add("last_login_DATE", last_login_DATE);
            }
            else
            {
                hashtable.Add("last_login_DATE", DBNull.Value);
            }

            if (last_logout_DATE != DateTime.MinValue)
            {
                hashtable.Add("last_logout_DATE", last_logout_DATE);
            }
            else
            {
                hashtable.Add("last_logout_DATE", DBNull.Value);
            }
            return hashtable;
        }

        public string InsertQuery()
        {
            return "INSERT INTO [Meta01].[dbo].[UUsers](name, ppassword, registration_DATE, last_login_DATE, last_logout_DATE) " +
                "   VALUES (@name, @ppassword, @registration_DATE, @last_login_DATE, @last_logout_DATE)";
        }

        public string UpdateQuery()
        {
            return "UPDATE [Meta01].[dbo].[UUsers] " +
                "   SET name = @name, ppassword = @ppassword, registration_DATE = @registration_DATE, " +
                "       last_login_DATE = @last_login_DATE, last_logout_DATE = @last_logout_DATE" +
                "   WHERE id_user = @id_user";
        }
    }
}
