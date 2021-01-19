using PrisonDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB
{
    class SqlModelReader
    {
        public static T GetModel<T>(SqlDataReader reader) where T : IModel
        {
            if (typeof(T) == typeof(Prisoner))
            {
                return (T)GetPrisoner(reader);
            }
            if (typeof(T) == typeof(Cell))
            {
                return (T)GetCells(reader);
            }
            if (typeof(T) == typeof(Gender))
            {
                return (T)GetGender(reader);
            }
            throw new ArgumentException();
            //return default;
        }

        private static IModel GetGender(SqlDataReader reader)
        {
            Gender gender = new Gender()
            {
                Gender_id = (Int32)reader["Gender_id"],
                Name = reader["Name"].ToString().Trim(),
            };
            return gender;
        }

        private static IModel GetPrisoner(SqlDataReader reader)
        {
            Prisoner prisoner = new Prisoner()
            {
                Prisoner_id = (Int32)reader["Prisoner_id"],
                Name = reader["PriosonerName"].ToString().Trim(),
                Surname = reader["Surname"].ToString(),
                Patronymic = reader["Patronymic"].ToString(),
                Birthday = (DateTime)reader["Birthday"],
                Gender_id = (Int32)reader["GenderID"],
                Gender = reader["GenderName"].ToString().Trim(),
                ArtName = reader["ArticleName"].ToString().Trim(),
                ArticleNum = (Int32)reader["ArticleNum"],
                Article_id = (Int32)reader["PrisonerArt_Id"],
                CorpsName = reader["CorpsName"].ToString().Trim(),
                Cell_id = (Int32)reader["Cell_id"],
            };


            if (reader["Comment"] != DBNull.Value)
            {
                prisoner.Comment_id = (Int32)reader["Comment_id"];
                prisoner.Comment = reader["Comment"].ToString().Trim();
            }
            

            //prisoner.Gender = reader["Surname"].ToString().Trim();
            // prisoner.Birthday = (DateTime)reader["Birthday"];
            return prisoner;
        }

        private static IModel GetCells(SqlDataReader reader)
        {
            Cell cell = new Cell()
            {
                Cell_id = (Int32)reader["Cell_id"],
                Capacity = (Int32)reader["Capacity"],
                Corps_name = reader["CorpsName"].ToString().Trim(),
                //Corps_number = reader["Corps_number"].ToString().Trim()
            };
            return cell;
        }

        
    }
}
