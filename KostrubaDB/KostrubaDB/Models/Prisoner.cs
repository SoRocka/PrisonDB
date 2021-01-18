using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisonDB.Models
{
    public class Prisoner : IModel
    {
        public int Prisoner_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public int Gender_id { get; set; }
        public string Gender { get; set; }
        public int Comment_id { get; set; }
        public string Comment { get; set; }
        public int Article_id { get; set; }
        public int ArticleNum { get; set; }
        public string ArtName { get; set; }
        public int Cell_id { get; set; }
        public string CorpsName { get; set; }


        public string DeleteQuery()
        {
            return "DELETE FROM [prison].[dbo].[Prisoner] " +
                   "WHERE Prisoner_id = @Prisoner_id";
        }

        public string GetAllQuery()
        {
            return "SELECT P.Prisoner_id, P.Name AS PriosonerName, P.Surname, P.Patronymic, P.Article_id AS PrisonerArt_Id, P.Cell_id, P.Birthday, " +
                    "G.Gender_id AS GenderID, G.Name AS GenderName, A.Article AS ArticleName, A.Article_id AS ArticleId, A.Article_Num AS ArticleNum, Co.Name AS CorpsName, Comm.Comment_id, Comm.Comment " +
              "FROM [prison].[dbo].[Prisoner] P INNER JOIN " +
                   "[prison].[dbo].[Gender] G ON " +
                   "P.Gender_id = G.Gender_id " +
                   "INNER JOIN [prison].[dbo].[Article] A " +
                   "ON P.Article_id = A.Article_id " +
                   "INNER JOIN [prison].[dbo].[BDCell] C ON " +
                   "P.Cell_id = C.Cell_id " +
                   "INNER JOIN [prison].[dbo].[BDCorps] Co " +
                   "ON C.Corps_Number = Co.Corps_Number " +
                   "LEFT JOIN [prison].[dbo].[Comment] Comm ON " +
                   "P.Comment_id = Comm.Comment_id "; 
        }

        public Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Prisoner_id", Prisoner_id);
            hashtable.Add("PrisonerName", Name);
            hashtable.Add("Surname", Surname);
            hashtable.Add("Patronymic", Patronymic);
            hashtable.Add("PrisonerArt_Id", Article_id);
            hashtable.Add("ArticleNum", ArticleNum);
            hashtable.Add("ArticleName", ArtName);
            hashtable.Add("Cell_id", Cell_id);
            hashtable.Add("CorpsName", CorpsName);
            hashtable.Add("Birthday", Birthday);
            hashtable.Add("GenderID", Gender_id);
            hashtable.Add("GenderName", Gender);
            hashtable.Add("Comment_id", Comment_id);
            hashtable.Add("Comment", Comment);
            return hashtable;
        }

        public string InsertQuery()
        {
            return "INSERT INTO [prison].[dbo].[Prisoner](Name, Surname, Patronymic, Birthday, Gender_id, Article_id, Comment_id, Cell_id) " +
                    "VALUES (@PrisonerName, @Surname, @Patronymic, @Birthday, @GenderID, @PrisonerArt_Id, @Comment_id, @Cell_id)";
                    
        }

        public string UpdateQuery()
        {
            return "UPDATE [prison].[dbo].[Prisoner] " +
                "   SET Name = @PrisonerName, Surname = @Surname, Patronymic = @Patronymic, " +
                "   Birthday = @Birthday, Gender_id = @GenderID, Article_id = @PrisonerArt_Id, Comment_id = @Comment_id, Cell_id = @Cell_id " + 
                "   WHERE Prisoner_id = @Prisoner_id";
        }
    }
}
