using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDB.Models
{
    
    public class Gender : IModel
    {
        public int Gender_id { get; set; }
        public string Name { get; set; }

        public string DeleteQuery()
        {
            return "DELETE FROM [Prison].[dbo].[Gender] " +
                "   WHERE Gender_id = @Gender_id";
        }

        public string GetAllQuery()
        {
            return "SELECT * " +
                "   FROM [Prison].[dbo].[Gender]";
        }

        public Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Gender_id", Gender_id);
            hashtable.Add("Name", Name);
            return hashtable;
        }

        public string InsertQuery()
        {
            return "INSERT INTO [Prison].[dbo].[Gender](Name) " +
                "   VALUES (@Name)";
        }

        public void LoadListToDGV<T>(List<T> list, DataGridView dgv) where T : IModel
        {
            dgv.DataSource = list;
            dgv.Columns["Gender_id"].Visible = false;
            dgv.Columns["Name"].HeaderText = "Пол";
        }

        public string UpdateQuery()
        {
            return "UPDATE [Prison].[dbo].[Gender] " +
                "   SET Name = @Name WHERE " +
                "   Gender_id = @Gender_id";
        }
    }
}

